using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Projects.Views
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.EmpButton = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.IconDashbord = new FontAwesome.Sharp.IconButton();
            this.IcoMachinery = new FontAwesome.Sharp.IconButton();
            this.IconOrders = new FontAwesome.Sharp.IconButton();
            this.iconCustomers = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.BtnMinialize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.iconChildForm = new FontAwesome.Sharp.IconButton();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.EmpButton);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.IconDashbord);
            this.panelMenu.Controls.Add(this.IcoMachinery);
            this.panelMenu.Controls.Add(this.IconOrders);
            this.panelMenu.Controls.Add(this.iconCustomers);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(232, 613);
            this.panelMenu.TabIndex = 0;
            // 
            // EmpButton
            // 
            this.EmpButton.FlatAppearance.BorderSize = 0;
            this.EmpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpButton.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmpButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.EmpButton.IconChar = FontAwesome.Sharp.IconChar.PersonDigging;
            this.EmpButton.IconColor = System.Drawing.Color.Gainsboro;
            this.EmpButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.EmpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmpButton.Location = new System.Drawing.Point(6, 284);
            this.EmpButton.Name = "EmpButton";
            this.EmpButton.Size = new System.Drawing.Size(226, 60);
            this.EmpButton.TabIndex = 5;
            this.EmpButton.Text = "Employees";
            this.EmpButton.UseVisualStyleBackColor = true;
            this.EmpButton.Click += new System.EventHandler(this.EmpButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Location = new System.Drawing.Point(0, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(232, 153);
            this.panelLogo.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(232, 153);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHome.TabIndex = 2;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // IconDashbord
            // 
            this.IconDashbord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IconDashbord.FlatAppearance.BorderSize = 0;
            this.IconDashbord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconDashbord.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IconDashbord.ForeColor = System.Drawing.Color.Gainsboro;
            this.IconDashbord.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.IconDashbord.IconColor = System.Drawing.Color.Gainsboro;
            this.IconDashbord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconDashbord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconDashbord.Location = new System.Drawing.Point(3, 162);
            this.IconDashbord.Name = "IconDashbord";
            this.IconDashbord.Size = new System.Drawing.Size(226, 50);
            this.IconDashbord.TabIndex = 6;
            this.IconDashbord.Text = "Dashbord";
            this.IconDashbord.UseVisualStyleBackColor = true;
            this.IconDashbord.Click += new System.EventHandler(this.IconDashbord_Click);
            // 
            // IcoMachinery
            // 
            this.IcoMachinery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IcoMachinery.FlatAppearance.BorderSize = 0;
            this.IcoMachinery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IcoMachinery.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IcoMachinery.ForeColor = System.Drawing.Color.Gainsboro;
            this.IcoMachinery.IconChar = FontAwesome.Sharp.IconChar.Robot;
            this.IcoMachinery.IconColor = System.Drawing.Color.Gainsboro;
            this.IcoMachinery.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcoMachinery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IcoMachinery.Location = new System.Drawing.Point(6, 416);
            this.IcoMachinery.Name = "IcoMachinery";
            this.IcoMachinery.Size = new System.Drawing.Size(226, 60);
            this.IcoMachinery.TabIndex = 7;
            this.IcoMachinery.Text = "Machinery";
            this.IcoMachinery.Click += new System.EventHandler(this.IcoMachinery_Click);
            // 
            // IconOrders
            // 
            this.IconOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IconOrders.FlatAppearance.BorderSize = 0;
            this.IconOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconOrders.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IconOrders.ForeColor = System.Drawing.Color.Gainsboro;
            this.IconOrders.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.IconOrders.IconColor = System.Drawing.Color.Gainsboro;
            this.IconOrders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconOrders.Location = new System.Drawing.Point(3, 218);
            this.IconOrders.Name = "IconOrders";
            this.IconOrders.Size = new System.Drawing.Size(226, 60);
            this.IconOrders.TabIndex = 8;
            this.IconOrders.Text = "Orders";
            this.IconOrders.Click += new System.EventHandler(this.IconOrders_Click);
            // 
            // iconCustomers
            // 
            this.iconCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCustomers.FlatAppearance.BorderSize = 0;
            this.iconCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCustomers.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconCustomers.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconCustomers.IconChar = FontAwesome.Sharp.IconChar.PeopleArrows;
            this.iconCustomers.IconColor = System.Drawing.Color.Gainsboro;
            this.iconCustomers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconCustomers.Location = new System.Drawing.Point(6, 350);
            this.iconCustomers.Name = "iconCustomers";
            this.iconCustomers.Size = new System.Drawing.Size(226, 60);
            this.iconCustomers.TabIndex = 10;
            this.iconCustomers.Text = "Customers";
            this.iconCustomers.Click += new System.EventHandler(this.iconCustomers_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.BtnMinialize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.ExitButton);
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(232, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1300, 54);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // BtnMinialize
            // 
            this.BtnMinialize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinialize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinialize.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnMinialize.FlatAppearance.BorderSize = 2;
            this.BtnMinialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinialize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMinialize.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnMinialize.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnMinialize.IconSize = 22;
            this.BtnMinialize.Location = new System.Drawing.Point(1195, 3);
            this.BtnMinialize.Name = "BtnMinialize";
            this.BtnMinialize.Size = new System.Drawing.Size(30, 27);
            this.BtnMinialize.TabIndex = 7;
            this.BtnMinialize.UseVisualStyleBackColor = true;
            this.BtnMinialize.Click += new System.EventHandler(this.BtnMinialize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.FlatAppearance.BorderSize = 2;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMaximize.IconSize = 38;
            this.btnMaximize.Location = new System.Drawing.Point(1231, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 27);
            this.btnMaximize.TabIndex = 6;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.ExitButton.FlatAppearance.BorderSize = 2;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ExitButton.IconColor = System.Drawing.Color.Gainsboro;
            this.ExitButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ExitButton.IconSize = 22;
            this.ExitButton.Location = new System.Drawing.Point(1267, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(30, 27);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleChildForm.Location = new System.Drawing.Point(44, 18);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(50, 20);
            this.labelTitleChildForm.TabIndex = 1;
            this.labelTitleChildForm.Text = "Home";
            // 
            // iconChildForm
            // 
            this.iconChildForm.FlatAppearance.BorderSize = 0;
            this.iconChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconChildForm.IconColor = System.Drawing.Color.Coral;
            this.iconChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconChildForm.IconSize = 40;
            this.iconChildForm.Location = new System.Drawing.Point(6, 12);
            this.iconChildForm.Name = "iconChildForm";
            this.iconChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconChildForm.TabIndex = 0;
            this.iconChildForm.UseVisualStyleBackColor = true;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(232, 54);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1300, 7);
            this.panelShadow.TabIndex = 4;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(232, 61);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1300, 552);
            this.panelDesktop.TabIndex = 7;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(442, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(410, 224);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1532, 613);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.Text = "MainView";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton IconOrders;
        private FontAwesome.Sharp.IconButton iconCustomers;
        private FontAwesome.Sharp.IconButton IcoMachinery;
        private FontAwesome.Sharp.IconButton IconDashbord;
        private Panel panelLogo;
        private PictureBox btnHome;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton iconChildForm;
        private Label labelTitleChildForm;
        private Panel panelShadow;
        private Panel panelDesktop;
        private PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton BtnMinialize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton ExitButton;
        private FontAwesome.Sharp.IconButton EmpButton;
    }
}