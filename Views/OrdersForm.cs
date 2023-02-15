using Projects.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Mapping;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Projects.Views
{
    public partial class FormOrders : Form, IOrdersView
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public FormOrders()
        {
            InitializeComponent();
            AssociateAndRaiseVIewEvents();
            tabControl1.TabPages.Remove(tabPage2);
            ExitButton.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseVIewEvents()
        {
            //Company name
            SqlConnection cd = new SqlConnection("Data Source=\"localhost, 1433\";Initial Catalog=Transporting;User ID=sa;Password=Monster1@3");
            cd.Open();
            SqlCommand cmd = new SqlCommand("select CostCompName from Costomers", cd);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("CostCompName", typeof(string));
            dt.Load(reader);
            CbComName.ValueMember = "CostCompName";
            CbComName.DataSource = dt;
            cd.Close();
            //Trailer
            SqlConnection con = new SqlConnection("Data Source=\"localhost, 1433\";Initial Catalog=Transporting;User ID=sa;Password=Monster1@3");
            con.Open();
            SqlCommand commd = new SqlCommand("select TreType From Trailers", con);
            
            SqlDataReader readerv2;
            readerv2 = commd.ExecuteReader();
            DataTable dataT = new DataTable();

            dataT.Columns.Add("TreType", typeof(string));
            dataT.Load(readerv2);
            CbTrailer.ValueMember = "TreType";
            CbTrailer.DataSource = dataT;
            con.Close();

            //Trucker
            
            SqlConnection co = new SqlConnection("Data Source=\"localhost, 1433\";Initial Catalog=Transporting;User ID=sa;Password=Monster1@3");
            co.Open();
            string select = @"SELECT CONCAT(EmpFirstName,' ',EmpLastName)as Trucker from Employees where EmpPosition=5";
            SqlCommand comd = new SqlCommand(select, co);
            
            SqlDataReader readertr;
            readertr = comd.ExecuteReader();
            DataTable data = new DataTable();
            data.Columns.Add("Trucker", typeof(string));
            data.Load(readertr);
            CbTrucker.ValueMember = "Trucker";
            CbTrucker.DataSource = data;
            co.Close();
            
            //Truck
            SqlConnection conn = new SqlConnection("Data Source=\"localhost, 1433\";Initial Catalog=Transporting;User ID=sa;Password=Monster1@3");
            conn.Open();
            SqlCommand commad = new SqlCommand("SelectTruckerName", conn);
            commad.CommandType = CommandType.StoredProcedure;
            SqlDataReader readerv4;
            readerv4 = commad.ExecuteReader();
            DataTable dataTa = new DataTable();

            dataTa.Columns.Add("Trnametruck", typeof(string));
            dataTa.Load(readerv4);
            CbTruck.ValueMember = "Trnametruck";
  
            CbTruck.DataSource = dataTa;
            conn.Close();

            //Serch
            ButtoSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            textSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            //Add new
            ButtonAdd.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1?.TabPages.Remove(tabPage1);
                tabControl1?.TabPages.Add(tabPage2);
                tabPage2.Text = "Add New Order";
            };
            //Edit
            ButtonEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1?.TabPages.Remove(tabPage1);
                tabControl1?.TabPages.Add(tabPage2);
                tabPage2.Text = "Edit Order";
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

                var result = MessageBox.Show("Are you wont to delete the selected Order?", "Warning",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }
        //Methods
        public void SetOrdListBindingSource(BindingSource OrdersLista)
        {

            dataGridViewOrders.DataSource = OrdersLista;
        }

        private static FormOrders? instance;
        internal static FormOrders GetInstance(Form parentContaine)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FormOrders();
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

        //Prepertis
        public string OrdId { get => textID.Text; set =>textID.Text=value; }
        public string OrdCompName { get => CbComName.Text; set => CbComName.Text=value; }
        public string OrdCountry { get => textContry.Text; set => textContry.Text=value; }
        public string OrdStreetAdres { get => textAddress.Text; set => textAddress.Text=value; }
        public string OrdCity { get => textCity.Text; set => textCity.Text=value; }
        public string OrdPostal { get => textPostal.Text; set => textPostal.Text=value; }
        public string OrdCargoType { get => textCargType.Text; set => textCargType.Text=value; }
        public string OrdWeight { get => textWeight.Text; set => textWeight.Text=value; }
        public string OrdTrailer { get => CbTrailer.Text; set => CbTrailer.Text=value; }
        public string Ordtruck { get => CbTruck.Text; set => CbTruck.Text=value; }
        public string Ordtrucker { get => CbTrucker.Text; set =>CbTrucker.Text=value; }
        public string OrdDateofdeparture { get => label.Text; set => label.Text=value; }
        public string OrdDeliverydate { get => dtpDeliver.Text; set => dtpDeliver.Text=value; }
        public string OrdCarriageprice { get => textPrice.Text; set => textPrice.Text=value; }
        public string SerchValue { get => textSearch.Text; set => textSearch.Text=value; }
        public bool IsEdit { get => isEdit; set => isEdit=value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful=value; }
        public string Message { get => message; set => message=value; }
        public string OrdExpenses { get => textBoxExpenses.Text; set => textBoxExpenses.Text=value; }

        //events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        

        private void FormOrders_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {

        }

        private void CbTruck_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
