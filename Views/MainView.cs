using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeesForms;

using FontAwesome.Sharp;
using Projects._Repositories;
using Projects.Models;

namespace Projects.Views
{
    public partial class MainView : Form, IMainView
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public event EventHandler ShowEmpForms;
        public event EventHandler ShowMachForms;
        public event EventHandler ShowCustForms;
        public event EventHandler ShowOrdForms;

        public MainView()
        {
            InitializeComponent();
           
           EmpButton.Click += delegate { ShowEmpForms?.Invoke(this, EventArgs.Empty); };
           IcoMachinery.Click+= delegate { ShowMachForms?.Invoke(this, EventArgs.Empty); };
           iconCustomers.Click += delegate { ShowCustForms?.Invoke(this, EventArgs.Empty); };
           IconOrders.Click += delegate { ShowOrdForms?.Invoke(this, EventArgs.Empty); };
            
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //From
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Structs
        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 123, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisabelButton();
                //BUtton
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Chil form
                iconChildForm.IconChar = currentBtn.IconChar;
                iconChildForm.IconColor = color;
            }
        }
        private void DisabelButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(37, 36, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }
        private void OpenChildForm(Form childFrom)
        {
            if(currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm=childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle=FormBorderStyle.None; 
            childFrom.Dock=DockStyle.Fill;
            childFrom.BringToFront();
            childFrom.Show();
            labelTitleChildForm.Text = childFrom.Text;
        }
        


        private void IconDashbord_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color1);
        }

        private void EmpButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color4);
            OpenChildForm(new EmployeesForm());
            panelDesktop.Visible = false;
        }

        private void IconOrders_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color3);
            OpenChildForm(new FormOrders());
            panelDesktop.Visible = false;
        }

        private void iconCustomers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color5);
            OpenChildForm(new CustomersForms());
            panelDesktop.Visible = false;
        }

        private void IcoMachinery_Click(object sender, EventArgs e)
        {
           ActivateButton(sender, RGBColor.color6);
            OpenChildForm(new MachineryForm());
            panelDesktop.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
            panelDesktop.Visible = true;
        }

        private void Reset()
        {
            DisabelButton();
            leftBorderBtn.Visible = false;
            iconChildForm.IconChar = IconChar.Home;
            iconChildForm.IconColor = Color.Coral;
            labelTitleChildForm.Text = "Home";
            panelDesktop.Visible = true;
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0X112, 0xf012, 0);
        }

        public void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            WindowState=FormWindowState.Maximized;
            else
            WindowState=FormWindowState.Normal;
        }

        private void BtnMinialize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelDesktop_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
