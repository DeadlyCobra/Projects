using System.Windows.Forms;

namespace Projects.Views
{
    partial class CustomersForms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtoSearch = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonAdded = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textPhonNum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textPostal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textProvince = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textStrAddress = new System.Windows.Forms.TextBox();
            this.textContry = new System.Windows.Forms.TextBox();
            this.textNip = new System.Windows.Forms.TextBox();
            this.textCompanyName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 69);
            this.panel1.TabIndex = 1;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ExitButton.IconColor = System.Drawing.Color.Black;
            this.ExitButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ExitButton.IconSize = 22;
            this.ExitButton.Location = new System.Drawing.Point(1175, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(30, 27);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(529, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1209, 415);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1201, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CustomersList";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ButtoSearch);
            this.panel2.Controls.Add(this.ButtonDelete);
            this.panel2.Controls.Add(this.ButtonEdit);
            this.panel2.Controls.Add(this.ButtonAdded);
            this.panel2.Controls.Add(this.textSearch);
            this.panel2.Controls.Add(this.dataGridViewCustomers);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1195, 376);
            this.panel2.TabIndex = 1;
            // 
            // ButtoSearch
            // 
            this.ButtoSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ButtoSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtoSearch.BackColor = System.Drawing.Color.DarkOrange;
            this.ButtoSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtoSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtoSearch.FlatAppearance.BorderSize = 0;
            this.ButtoSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtoSearch.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtoSearch.ForeColor = System.Drawing.Color.Black;
            this.ButtoSearch.Location = new System.Drawing.Point(981, 37);
            this.ButtoSearch.Name = "ButtoSearch";
            this.ButtoSearch.Size = new System.Drawing.Size(109, 35);
            this.ButtoSearch.TabIndex = 13;
            this.ButtoSearch.Text = "Serach";
            this.ButtoSearch.UseVisualStyleBackColor = false;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDelete.BackColor = System.Drawing.Color.Red;
            this.ButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDelete.FlatAppearance.BorderSize = 0;
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonDelete.Location = new System.Drawing.Point(1096, 180);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(94, 44);
            this.ButtonDelete.TabIndex = 12;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEdit.BackColor = System.Drawing.Color.DarkBlue;
            this.ButtonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEdit.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.ButtonEdit.FlatAppearance.BorderSize = 0;
            this.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEdit.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonEdit.Location = new System.Drawing.Point(1096, 128);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(94, 46);
            this.ButtonEdit.TabIndex = 11;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = false;
            // 
            // ButtonAdded
            // 
            this.ButtonAdded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAdded.BackColor = System.Drawing.Color.Green;
            this.ButtonAdded.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAdded.FlatAppearance.BorderSize = 0;
            this.ButtonAdded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdded.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAdded.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonAdded.Location = new System.Drawing.Point(1096, 78);
            this.ButtonAdded.Name = "ButtonAdded";
            this.ButtonAdded.Size = new System.Drawing.Size(94, 44);
            this.ButtonAdded.TabIndex = 10;
            this.ButtonAdded.Text = "Add new";
            this.ButtonAdded.UseVisualStyleBackColor = false;
            // 
            // textSearch
            // 
            this.textSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textSearch.Location = new System.Drawing.Point(220, 38);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(755, 34);
            this.textSearch.TabIndex = 9;
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AllowUserToAddRows = false;
            this.dataGridViewCustomers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCustomers.ColumnHeadersHeight = 29;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCustomers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCustomers.GridColor = System.Drawing.Color.White;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(27, 78);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCustomers.RowHeadersWidth = 51;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewCustomers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCustomers.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewCustomers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PeachPuff;
            this.dataGridViewCustomers.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewCustomers.RowTemplate.Height = 29;
            this.dataGridViewCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(1063, 240);
            this.dataGridViewCustomers.TabIndex = 0;
            this.dataGridViewCustomers.Resize += new System.EventHandler(this.dataGridViewCustomers_Resize);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(27, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search Employees:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1201, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Custmers Details";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonCancel);
            this.panel3.Controls.Add(this.buttonSave);
            this.panel3.Controls.Add(this.textPhonNum);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.textEmail);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.textPostal);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.textProvince);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.textCity);
            this.panel3.Controls.Add(this.textStrAddress);
            this.panel3.Controls.Add(this.textContry);
            this.panel3.Controls.Add(this.textNip);
            this.panel3.Controls.Add(this.textCompanyName);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textID);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1195, 376);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(673, 314);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(176, 47);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(352, 314);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(176, 47);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // textPhonNum
            // 
            this.textPhonNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPhonNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textPhonNum.Location = new System.Drawing.Point(695, 203);
            this.textPhonNum.Name = "textPhonNum";
            this.textPhonNum.Size = new System.Drawing.Size(230, 30);
            this.textPhonNum.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(522, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 28);
            this.label12.TabIndex = 20;
            this.label12.Text = "Phone number:";
            // 
            // textEmail
            // 
            this.textEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textEmail.Location = new System.Drawing.Point(695, 164);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(230, 30);
            this.textEmail.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(522, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 28);
            this.label11.TabIndex = 18;
            this.label11.Text = "Email:";
            // 
            // textPostal
            // 
            this.textPostal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPostal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textPostal.Location = new System.Drawing.Point(695, 126);
            this.textPostal.Name = "textPostal";
            this.textPostal.Size = new System.Drawing.Size(230, 30);
            this.textPostal.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(522, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 28);
            this.label10.TabIndex = 16;
            this.label10.Text = "Postal:";
            // 
            // textProvince
            // 
            this.textProvince.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textProvince.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textProvince.Location = new System.Drawing.Point(695, 87);
            this.textProvince.Name = "textProvince";
            this.textProvince.Size = new System.Drawing.Size(230, 30);
            this.textProvince.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(522, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 28);
            this.label9.TabIndex = 14;
            this.label9.Text = "Province:";
            // 
            // textCity
            // 
            this.textCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textCity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCity.Location = new System.Drawing.Point(204, 245);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(230, 30);
            this.textCity.TabIndex = 5;
            // 
            // textStrAddress
            // 
            this.textStrAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textStrAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textStrAddress.Location = new System.Drawing.Point(204, 203);
            this.textStrAddress.Name = "textStrAddress";
            this.textStrAddress.Size = new System.Drawing.Size(230, 30);
            this.textStrAddress.TabIndex = 4;
            // 
            // textContry
            // 
            this.textContry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textContry.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textContry.Location = new System.Drawing.Point(204, 164);
            this.textContry.Name = "textContry";
            this.textContry.Size = new System.Drawing.Size(230, 30);
            this.textContry.TabIndex = 3;
            // 
            // textNip
            // 
            this.textNip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textNip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNip.Location = new System.Drawing.Point(204, 126);
            this.textNip.Name = "textNip";
            this.textNip.Size = new System.Drawing.Size(230, 30);
            this.textNip.TabIndex = 2;
            // 
            // textCompanyName
            // 
            this.textCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textCompanyName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCompanyName.Location = new System.Drawing.Point(204, 85);
            this.textCompanyName.Name = "textCompanyName";
            this.textCompanyName.Size = new System.Drawing.Size(230, 30);
            this.textCompanyName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(31, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 28);
            this.label8.TabIndex = 8;
            this.label8.Text = "City:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(31, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Street address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(31, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Contry:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(31, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "NIP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Company Name:";
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textID.Location = new System.Drawing.Point(610, 11);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(50, 34);
            this.textID.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(544, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "IdNr:";
            // 
            // CustomersForms
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1209, 484);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomersForms";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.CustomersForms_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton ExitButton;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private DataGridView dataGridViewCustomers;
        private TextBox textSearch;
        public Button ButtonAdded;
        public Button ButtonEdit;
        public Button ButtonDelete;
        public Button ButtoSearch;
        private Label label4;
        private TextBox textID;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox textCity;
        private TextBox textStrAddress;
        private TextBox textContry;
        private TextBox textNip;
        private TextBox textCompanyName;
        private TextBox textPhonNum;
        private Label label12;
        private TextBox textEmail;
        private Label label11;
        private TextBox textPostal;
        private Label label10;
        private TextBox textProvince;
        private Label label9;
        private Button buttonSave;
        private Button buttonCancel;
    }
}