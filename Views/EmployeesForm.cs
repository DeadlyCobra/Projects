using Projects.Models;
using Projects.Views;
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

namespace EmployeesForms
{
    public partial class EmployeesForm : Form, EmployeesView
    {

        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        

        //Constructor
        public EmployeesForm()
        {
            InitializeComponent();
            AssociateAndRaiseVIewEvents();
            tabControl1.TabPages.Remove(tabPage2);
            ExitButton.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseVIewEvents()
        {
            SqlConnection cd = new SqlConnection("Data Source=\"localhost, 1433\";Initial Catalog=Transporting;User ID=sa;Password=Mo" +
"nster1@3");
            cd.Open();
            SqlCommand cmd = new SqlCommand("Select (PositName) from Position", cd);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PositName", typeof(string));
            dt.Load(reader);
            comboPosition.ValueMember = "PositName";
            comboPosition.DataSource = dt;
            cd.Close();
            
            ButtoSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            textSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter )
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            //Add new
            ButtonAdded.Click += delegate 
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty); 
                tabControl1?.TabPages.Remove(tabPage1);
                tabControl1?.TabPages.Add(tabPage2);
                tabPage2.Text = "Add New Employes";
            };
            //Edit
            ButtonEdit.Click += delegate 
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1?.TabPages.Remove(tabPage1);
                tabControl1?.TabPages.Add(tabPage2);
                tabPage2.Text = "Edit Employes";
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
                DeleteEvent?.Invoke(this, EventArgs.Empty); 
             var result =   MessageBox.Show("Are you wont to delete the selected Employes?","Warning",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
           


        }

      

        //Prepertis
        public string EmpId { get => textID.Text; set => textID.Text=value; }
        public string EmpFirstName { get => textFirstName.Text; set => textFirstName.Text=value; }
        public string EmpLastName { get => textLastName.Text; set => textLastName.Text=value; }
        public string EmpStreatAdres { get => textAddres.Text; set => textAddres.Text=value; }
        public string EmpCity { get => textCity.Text; set => textCity.Text=value; }
        public string EmpProvince { get => textProvince.Text; set => textProvince.Text=value; }
        public string EmpPostal { get => textPostal.Text; set => textPostal.Text=value; }
        public string EmpEmail { get => textEmail.Text; set => textEmail.Text=value; }
        public string EmpPhonneNum { get => textPhonneNr.Text; set => textPhonneNr.Text=value; }
        public string EmpPosition { get => comboPosition.Text; set => comboPosition.Text=value; }
        public string SerchValue { get => textSearch.Text;  set => textSearch.Text = value;  }
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

        public void SetEmpListBindingSource(BindingSource Employesslist)
        {
            dataGridView1.DataSource=Employesslist;
        }
        private static EmployeesForm? instance;
        internal static EmployeesForm GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            { 
            instance = new EmployeesForm();
            instance.MdiParent = parentContainer;
            instance.FormBorderStyle=FormBorderStyle.None;
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonAdded_Click(object sender, EventArgs e)
        {

        }


        private void comboPosition_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }

}
