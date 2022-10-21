using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;

namespace Projects.Views
{
    public partial class MainView : Form,IMainView
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public MainView()
        {
            InitializeComponent();
            EmpButton.Click += delegate { ShowEmpForms?.Invoke(this, EventArgs.Empty); };
            leftBorderBtn=new Panel();
            leftBorderBtn.Size = new Size(7,50);
            panelMenu.Controls.Add(leftBorderBtn);
        }
        //Structs
        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 1238, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Methods
        private void ActivateButton(object senderBtn,Color color)
        {
            if(senderBtn != null)
            {
                DisabelButton();
                //BUtton
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37,36,81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign= ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor= color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
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
        public event EventHandler ShowEmpForms;
        public event EventHandler ShowOwnerView;
        public event EventHandler ShowVestsView;
       

        private void MainView_Load(object sender, EventArgs e)
        {
                   
        }
                private void EmpButton_Click(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {

        }

        private void IconOrders_Click(object sender, EventArgs e)
        {

        }
    }
}
