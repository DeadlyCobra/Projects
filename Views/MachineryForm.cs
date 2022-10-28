using EmployeesForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Projects.Views
{
    public partial class MachineryForm : Form , MachineryView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public MachineryForm()
        {
            InitializeComponent();
            AssociateAndRaiseVIewEvents();
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage4);
            MachExitButton.Click += delegate { this.Close(); };
        }
        private void AssociateAndRaiseVIewEvents()
        {
            SqlConnection cd = new SqlConnection("Data Source=\"localhost, 1433\";Initial Catalog=Transporting;User ID=sa;Password=Monster1@3");
            cd.Open();
            SqlCommand cmd = new SqlCommand("SELECT TrName  From TrucksName", cd);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("TrName", typeof(string));
            dt.Load(reader);
            comboBoxTruck.ValueMember = "TrName";
            comboBoxTruck.DataSource = dt;
            cd.Close();

           
            buttonSerchTruck.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            textSearchTruck.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            //Add new
            buttonAddedTruck.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1?.TabPages.Remove(tabPage1);
                tabControl1?.TabPages.Remove(tabPage3);
                tabControl1?.TabPages.Add(tabPage2);
                tabPage2.Text = "Add New Truck";
            };
            //Edit
            buttonEditTruck.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1?.TabPages.Remove(tabPage1);
                tabControl1?.TabPages.Remove(tabPage3);
                tabControl1?.TabPages.Add(tabPage2);
                tabPage2.Text = "Edit Truck";
            };
            //Save
            buttonSaveTruck.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1?.TabPages.Remove(tabPage2);               
                    tabControl1?.TabPages.Add(tabPage1);
                    tabControl1?.TabPages.Add(tabPage2);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            buttonCancelTruck.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1?.TabPages.Remove(tabPage2);
                tabControl1?.TabPages.Add(tabPage1);
                tabControl1?.TabPages.Add(tabPage3);
            };
            //Dellete
            buttonDeleteTruck.Click += delegate
            {

                var result = MessageBox.Show("Are you wont to delete the selected Truck?", "Warning",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }
        public void SetMachListBindingSource(BindingSource Machinerylist)
        {
            dataGridViewTruck.DataSource = Machinerylist;
        }
        private static MachineryForm? instance;
        internal static MachineryForm GetInstanceMach(Form parentContaine)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new MachineryForm();
                instance.MdiParent = parentContaine;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }

            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
        //events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Prepertis
        public string TrId { get => textTrID.Text; set => textTrID.Text = value; }
        public string TrName { get => comboBoxTruck.Text; set => comboBoxTruck.Text = value; }
        public string TrRegistration { get => TruckRegistration.Text; set => TruckRegistration.Text = value; }
        public string TrServ { get => TruckServDate.Text; set => TruckServDate.Text = value; }
        /*
        public string ForId { get => ForkliftsID.Text; set => ForkliftsID.Text = value; }
        public string ForName { get => ForkliftsName.Text; set => ForkliftsName.Text = value; }
        public string ForModel { get => ForkliftsModel.Text; set => ForkliftsModel.Text = value; }
        public string ForServ { get => ForkliftsServDate.Text; set => ForkliftsServDate.Text = value; }
        */
        public string SerchValue { get => textSearchTruck.Text; set => textSearchTruck.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAddedTruck_Click(object sender, EventArgs e)
        {

        }

        private void MachineryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
