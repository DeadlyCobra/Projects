namespace Projects.Views
{
    partial class FormOrders
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
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxExpenses = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.dtpDeliver = new System.Windows.Forms.DateTimePicker();
            this.dtpDeparture = new System.Windows.Forms.DateTimePicker();
            this.CbTrucker = new System.Windows.Forms.ComboBox();
            this.CbTruck = new System.Windows.Forms.ComboBox();
            this.CbTrailer = new System.Windows.Forms.ComboBox();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CbComName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textCargType = new System.Windows.Forms.TextBox();
            this.textPostal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textContry = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.label.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1198, 69);
            this.panel1.TabIndex = 2;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ExitButton.IconColor = System.Drawing.Color.Black;
            this.ExitButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ExitButton.IconSize = 22;
            this.ExitButton.Location = new System.Drawing.Point(1165, 3);
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
            this.label1.Location = new System.Drawing.Point(553, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orders";
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
            this.tabControl1.Size = new System.Drawing.Size(1198, 434);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1190, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "OrdersList";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.ButtoSearch);
            this.panel2.Controls.Add(this.ButtonDelete);
            this.panel2.Controls.Add(this.ButtonEdit);
            this.panel2.Controls.Add(this.ButtonAdd);
            this.panel2.Controls.Add(this.dataGridViewOrders);
            this.panel2.Controls.Add(this.textSearch);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 395);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.ButtoSearch.Location = new System.Drawing.Point(967, 28);
            this.ButtoSearch.Name = "ButtoSearch";
            this.ButtoSearch.Size = new System.Drawing.Size(109, 35);
            this.ButtoSearch.TabIndex = 17;
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
            this.ButtonDelete.Location = new System.Drawing.Point(1085, 171);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(94, 44);
            this.ButtonDelete.TabIndex = 16;
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
            this.ButtonEdit.Location = new System.Drawing.Point(1085, 119);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(94, 46);
            this.ButtonEdit.TabIndex = 15;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = false;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAdd.BackColor = System.Drawing.Color.Green;
            this.ButtonAdd.FlatAppearance.BorderSize = 0;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonAdd.Location = new System.Drawing.Point(1085, 69);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(94, 44);
            this.ButtonAdd.TabIndex = 14;
            this.ButtonAdd.Text = "Add new";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrders.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOrders.ColumnHeadersHeight = 29;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrders.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOrders.GridColor = System.Drawing.Color.White;
            this.dataGridViewOrders.Location = new System.Drawing.Point(33, 69);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewOrders.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewOrders.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewOrders.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PeachPuff;
            this.dataGridViewOrders.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewOrders.RowTemplate.Height = 29;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(1043, 240);
            this.dataGridViewOrders.TabIndex = 14;
            // 
            // textSearch
            // 
            this.textSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textSearch.Location = new System.Drawing.Point(188, 29);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(773, 34);
            this.textSearch.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(33, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search Orders:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.ForeColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1190, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label.Controls.Add(this.label19);
            this.label.Controls.Add(this.label18);
            this.label.Controls.Add(this.textBoxExpenses);
            this.label.Controls.Add(this.label17);
            this.label.Controls.Add(this.textAddress);
            this.label.Controls.Add(this.buttonSave);
            this.label.Controls.Add(this.buttonCancel);
            this.label.Controls.Add(this.label16);
            this.label.Controls.Add(this.textPrice);
            this.label.Controls.Add(this.dtpDeliver);
            this.label.Controls.Add(this.dtpDeparture);
            this.label.Controls.Add(this.CbTrucker);
            this.label.Controls.Add(this.CbTruck);
            this.label.Controls.Add(this.CbTrailer);
            this.label.Controls.Add(this.textWeight);
            this.label.Controls.Add(this.label15);
            this.label.Controls.Add(this.label14);
            this.label.Controls.Add(this.label13);
            this.label.Controls.Add(this.label12);
            this.label.Controls.Add(this.label11);
            this.label.Controls.Add(this.label10);
            this.label.Controls.Add(this.label9);
            this.label.Controls.Add(this.CbComName);
            this.label.Controls.Add(this.label8);
            this.label.Controls.Add(this.textCargType);
            this.label.Controls.Add(this.textPostal);
            this.label.Controls.Add(this.label7);
            this.label.Controls.Add(this.label6);
            this.label.Controls.Add(this.textContry);
            this.label.Controls.Add(this.textCity);
            this.label.Controls.Add(this.label5);
            this.label.Controls.Add(this.label3);
            this.label.Controls.Add(this.textID);
            this.label.Controls.Add(this.label4);
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Location = new System.Drawing.Point(3, 3);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(1184, 395);
            this.label.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(815, 286);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 30);
            this.label19.TabIndex = 37;
            this.label19.Text = "€";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(425, 287);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 28);
            this.label18.TabIndex = 36;
            this.label18.Text = "Expenses:";
            // 
            // textBoxExpenses
            // 
            this.textBoxExpenses.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExpenses.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxExpenses.Location = new System.Drawing.Point(580, 285);
            this.textBoxExpenses.Name = "textBoxExpenses";
            this.textBoxExpenses.Size = new System.Drawing.Size(229, 30);
            this.textBoxExpenses.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(5, 126);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 28);
            this.label17.TabIndex = 34;
            this.label17.Text = "Address:";
            // 
            // textAddress
            // 
            this.textAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textAddress.Location = new System.Drawing.Point(178, 124);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(229, 30);
            this.textAddress.TabIndex = 33;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(413, 343);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(176, 47);
            this.buttonSave.TabIndex = 32;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(694, 343);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(176, 47);
            this.buttonCancel.TabIndex = 31;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(815, 237);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 30);
            this.label16.TabIndex = 30;
            this.label16.Text = "€";
            // 
            // textPrice
            // 
            this.textPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textPrice.Location = new System.Drawing.Point(580, 237);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(229, 30);
            this.textPrice.TabIndex = 29;
            // 
            // dtpDeliver
            // 
            this.dtpDeliver.CustomFormat = "";
            this.dtpDeliver.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeliver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpDeliver.Location = new System.Drawing.Point(1029, 131);
            this.dtpDeliver.Name = "dtpDeliver";
            this.dtpDeliver.Size = new System.Drawing.Size(142, 34);
            this.dtpDeliver.TabIndex = 28;
            this.dtpDeliver.Value = new System.DateTime(2022, 12, 21, 0, 0, 0, 0);
            this.dtpDeliver.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dtpDeparture
            // 
            this.dtpDeparture.CustomFormat = "";
            this.dtpDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeparture.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpDeparture.Location = new System.Drawing.Point(1029, 80);
            this.dtpDeparture.Name = "dtpDeparture";
            this.dtpDeparture.Size = new System.Drawing.Size(142, 34);
            this.dtpDeparture.TabIndex = 27;
            this.dtpDeparture.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // CbTrucker
            // 
            this.CbTrucker.FormattingEnabled = true;
            this.CbTrucker.Location = new System.Drawing.Point(522, 165);
            this.CbTrucker.Name = "CbTrucker";
            this.CbTrucker.Size = new System.Drawing.Size(290, 36);
            this.CbTrucker.TabIndex = 26;
            // 
            // CbTruck
            // 
            this.CbTruck.FormattingEnabled = true;
            this.CbTruck.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CbTruck.Location = new System.Drawing.Point(522, 123);
            this.CbTruck.Name = "CbTruck";
            this.CbTruck.Size = new System.Drawing.Size(290, 36);
            this.CbTruck.TabIndex = 25;
            this.CbTruck.SelectedIndexChanged += new System.EventHandler(this.CbTruck_SelectedIndexChanged);
            // 
            // CbTrailer
            // 
            this.CbTrailer.FormattingEnabled = true;
            this.CbTrailer.Location = new System.Drawing.Point(522, 82);
            this.CbTrailer.Name = "CbTrailer";
            this.CbTrailer.Size = new System.Drawing.Size(290, 36);
            this.CbTrailer.TabIndex = 24;
            // 
            // textWeight
            // 
            this.textWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textWeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textWeight.Location = new System.Drawing.Point(178, 303);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(229, 30);
            this.textWeight.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(425, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 28);
            this.label15.TabIndex = 22;
            this.label15.Text = "Truck:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(425, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 28);
            this.label14.TabIndex = 21;
            this.label14.Text = "Trailer:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(425, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 28);
            this.label13.TabIndex = 20;
            this.label13.Text = "Trucker:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(425, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 28);
            this.label12.TabIndex = 19;
            this.label12.Text = "Carriage price:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(835, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 28);
            this.label11.TabIndex = 18;
            this.label11.Text = "Delivery Date:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(835, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 28);
            this.label10.TabIndex = 17;
            this.label10.Text = "Date of departure:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(5, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 28);
            this.label9.TabIndex = 16;
            this.label9.Text = "Weight:";
            // 
            // CbComName
            // 
            this.CbComName.FormattingEnabled = true;
            this.CbComName.Location = new System.Drawing.Point(178, 82);
            this.CbComName.Name = "CbComName";
            this.CbComName.Size = new System.Drawing.Size(229, 36);
            this.CbComName.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cargo type:";
            // 
            // textCargType
            // 
            this.textCargType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textCargType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCargType.Location = new System.Drawing.Point(178, 267);
            this.textCargType.Name = "textCargType";
            this.textCargType.Size = new System.Drawing.Size(229, 30);
            this.textCargType.TabIndex = 13;
            // 
            // textPostal
            // 
            this.textPostal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPostal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textPostal.Location = new System.Drawing.Point(178, 231);
            this.textPostal.Name = "textPostal";
            this.textPostal.Size = new System.Drawing.Size(229, 30);
            this.textPostal.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(5, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "Postal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(5, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Country:";
            // 
            // textContry
            // 
            this.textContry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textContry.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textContry.Location = new System.Drawing.Point(178, 195);
            this.textContry.Name = "textContry";
            this.textContry.Size = new System.Drawing.Size(229, 30);
            this.textContry.TabIndex = 9;
            // 
            // textCity
            // 
            this.textCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textCity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCity.Location = new System.Drawing.Point(178, 159);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(229, 30);
            this.textCity.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(5, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Company Name:";
            // 
            // textID
            // 
            this.textID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textID.Location = new System.Drawing.Point(612, 18);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(50, 34);
            this.textID.TabIndex = 4;
            this.textID.Text = "0";
            this.textID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(546, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "IdNr:";
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 503);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "FormOrders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.label.ResumeLayout(false);
            this.label.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton ExitButton;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel2;
        private TabPage tabPage2;
        private Panel label;
        private Label label2;
        private TextBox textSearch;
        private DataGridView dataGridViewOrders;
        public Button ButtonEdit;
        private Button ButtonAdd;
        public Button ButtonDelete;
        public Button ButtoSearch;
        private Label label4;
        private TextBox textID;
        private Label label3;
        private Label label6;
        private TextBox textContry;
        private TextBox textCity;
        private Label label5;
        private Label label8;
        private TextBox textCargType;
        private TextBox textPostal;
        private Label label7;
        private DateTimePicker dtpDeparture;
        private ComboBox CbTrucker;
        private ComboBox CbTruck;
        private ComboBox CbTrailer;
        private TextBox textWeight;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private ComboBox CbComName;
        private Label label16;
        private TextBox textPrice;
        private Button buttonCancel;
        private Button buttonSave;
        private Label label17;
        private TextBox textAddress;
        private Label label19;
        private Label label18;
        private TextBox textBoxExpenses;
        private DateTimePicker dtpDeliver;
    }
}