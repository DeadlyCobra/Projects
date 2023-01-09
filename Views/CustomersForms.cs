using EmployeesForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projects.Views
{
    public partial class CustomersForms : Form ,ICustomersView
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        
        //Constructor
        public CustomersForms()
        {
            InitializeComponent();
            AssociateAndRaiseVIewEvents();
            tabControl1.TabPages.Remove(tabPage2);
            ExitButton.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseVIewEvents()
        {

            ButtoSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            textSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            //Add new
            ButtonAdded.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1?.TabPages.Remove(tabPage1);
                tabControl1?.TabPages.Add(tabPage2);
                tabPage2.Text = "Add New Customer";
            };
            //Edit
            ButtonEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1?.TabPages.Remove(tabPage1);
                tabControl1?.TabPages.Add(tabPage2);
                tabPage2.Text = "Edit Customer";
            };
            //Save
            buttonSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1?.TabPages.Remove(tabPage2);
                    tabControl1?.TabPages.Add(tabPage1);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            buttonCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1?.TabPages.Remove(tabPage2);
                tabControl1?.TabPages.Add(tabPage1);
            };
            //Dellete
            ButtonDelete.Click += delegate
            {

                var result = MessageBox.Show("Are you wont to delete the selected Customer?", "Warning",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };



        }

        //Prepertis
        public string CostId { get => textID.Text; set => textID.Text=value; }
        public string CostCompName { get => textCompanyName.Text; set => textCompanyName.Text=value; }
        public string CostNip { get => textNip.Text; set => textNip.Text=value; }
        public string CostContry { get => textContry.Text; set => textContry.Text=value; }
        public string CostStreetAdres { get => textStrAddress.Text; set => textStrAddress.Text=value; }
        public string CostCity { get => textCity.Text; set => textCity.Text=value; }
        public string CostProvince { get => textProvince.Text; set => textProvince.Text=value; }
        public string CostPostal { get => textPostal.Text; set => textPostal.Text=value; }
        public string CostEmail { get => textEmail.Text; set => textEmail.Text=value; }
        public string CostPhonneNum { get => textPhonNum.Text; set => textPhonNum.Text=value; }
        public string SerchValue { get => textSearch.Text; set => textSearch.Text=value; }
        public bool IsEdit { get => isEdit; set => isEdit=value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful=value; }
        public string Message { get => message; set => message=value; }

        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetCostListBindingSource(BindingSource Customerslist)
        {
            dataGridViewCustomers.DataSource = Customerslist;
        }
        private static CustomersForms? instance;
        internal static CustomersForms GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CustomersForms();
                instance.MdiParent = parentContainer;
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

        private void CustomersForms_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewCustomers_Resize(object sender, EventArgs e)
        {
            dataGridViewCustomers.Columns[0].Width = 50;  // or whatever width works well for abbrev
            dataGridViewCustomers.Columns[2].Width = 100;  // or whatever width works well for abbrev
            dataGridViewCustomers.Columns[3].Width = 90;  // or whatever width works well for abbrev
            dataGridViewCustomers.Columns[7].Width = 90;  // or whatever width works well for abbrev
            dataGridViewCustomers.Columns[8].Width = 140;  // or whatever width works well for abbrev

        }
    }
}
