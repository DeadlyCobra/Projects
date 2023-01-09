namespace Projects.Views
{
    partial class MachineryForm
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
            this.MachExitButton = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCancelTruck = new System.Windows.Forms.Button();
            this.buttonSaveTruck = new System.Windows.Forms.Button();
            this.TruckServDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTruck = new System.Windows.Forms.ComboBox();
            this.TruckRegistration = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textTrID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDeleteTruck = new System.Windows.Forms.Button();
            this.buttonEditTruck = new System.Windows.Forms.Button();
            this.buttonAddedTruck = new System.Windows.Forms.Button();
            this.buttonSerchTruck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textSearchTruck = new System.Windows.Forms.TextBox();
            this.dataGridViewTruck = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTruck)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.MachExitButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1324, 70);
            this.panel1.TabIndex = 2;
            // 
            // MachExitButton
            // 
            this.MachExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MachExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MachExitButton.IconChar = FontAwesome.Sharp.IconChar.X;
            this.MachExitButton.IconColor = System.Drawing.Color.Black;
            this.MachExitButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.MachExitButton.IconSize = 22;
            this.MachExitButton.Location = new System.Drawing.Point(1291, 3);
            this.MachExitButton.Name = "MachExitButton";
            this.MachExitButton.Size = new System.Drawing.Size(30, 27);
            this.MachExitButton.TabIndex = 3;
            this.MachExitButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(564, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Machinery";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1316, 415);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Truck Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel3.Controls.Add(this.buttonCancelTruck);
            this.panel3.Controls.Add(this.buttonSaveTruck);
            this.panel3.Controls.Add(this.TruckServDate);
            this.panel3.Controls.Add(this.comboBoxTruck);
            this.panel3.Controls.Add(this.TruckRegistration);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textTrID);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel3.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1310, 409);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // buttonCancelTruck
            // 
            this.buttonCancelTruck.BackColor = System.Drawing.Color.Red;
            this.buttonCancelTruck.FlatAppearance.BorderSize = 0;
            this.buttonCancelTruck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelTruck.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelTruck.ForeColor = System.Drawing.Color.White;
            this.buttonCancelTruck.Location = new System.Drawing.Point(643, 353);
            this.buttonCancelTruck.Name = "buttonCancelTruck";
            this.buttonCancelTruck.Size = new System.Drawing.Size(176, 47);
            this.buttonCancelTruck.TabIndex = 13;
            this.buttonCancelTruck.Text = "Cancel";
            this.buttonCancelTruck.UseVisualStyleBackColor = false;
            // 
            // buttonSaveTruck
            // 
            this.buttonSaveTruck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSaveTruck.FlatAppearance.BorderSize = 0;
            this.buttonSaveTruck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveTruck.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveTruck.ForeColor = System.Drawing.Color.White;
            this.buttonSaveTruck.Location = new System.Drawing.Point(305, 353);
            this.buttonSaveTruck.Name = "buttonSaveTruck";
            this.buttonSaveTruck.Size = new System.Drawing.Size(176, 47);
            this.buttonSaveTruck.TabIndex = 12;
            this.buttonSaveTruck.Text = "Save";
            this.buttonSaveTruck.UseVisualStyleBackColor = false;
            // 
            // TruckServDate
            // 
            this.TruckServDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TruckServDate.Location = new System.Drawing.Point(483, 177);
            this.TruckServDate.Name = "TruckServDate";
            this.TruckServDate.Size = new System.Drawing.Size(194, 34);
            this.TruckServDate.TabIndex = 9;
            // 
            // comboBoxTruck
            // 
            this.comboBoxTruck.FormattingEnabled = true;
            this.comboBoxTruck.Location = new System.Drawing.Point(483, 73);
            this.comboBoxTruck.Name = "comboBoxTruck";
            this.comboBoxTruck.Size = new System.Drawing.Size(194, 36);
            this.comboBoxTruck.TabIndex = 8;
            // 
            // TruckRegistration
            // 
            this.TruckRegistration.Location = new System.Drawing.Point(483, 127);
            this.TruckRegistration.Name = "TruckRegistration";
            this.TruckRegistration.Size = new System.Drawing.Size(194, 34);
            this.TruckRegistration.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(344, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Service Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(344, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Registration:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(344, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Truck Name:";
            // 
            // textTrID
            // 
            this.textTrID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textTrID.Location = new System.Drawing.Point(623, 8);
            this.textTrID.Name = "textTrID";
            this.textTrID.Size = new System.Drawing.Size(44, 34);
            this.textTrID.TabIndex = 3;
            this.textTrID.Text = "0";
            this.textTrID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(557, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "IdNr:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1316, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Truck Liste";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.buttonDeleteTruck);
            this.panel2.Controls.Add(this.buttonEditTruck);
            this.panel2.Controls.Add(this.buttonAddedTruck);
            this.panel2.Controls.Add(this.buttonSerchTruck);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textSearchTruck);
            this.panel2.Controls.Add(this.dataGridViewTruck);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1310, 409);
            this.panel2.TabIndex = 2;
            // 
            // buttonDeleteTruck
            // 
            this.buttonDeleteTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteTruck.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteTruck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteTruck.FlatAppearance.BorderSize = 0;
            this.buttonDeleteTruck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteTruck.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteTruck.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDeleteTruck.Location = new System.Drawing.Point(1211, 160);
            this.buttonDeleteTruck.Name = "buttonDeleteTruck";
            this.buttonDeleteTruck.Size = new System.Drawing.Size(94, 44);
            this.buttonDeleteTruck.TabIndex = 10;
            this.buttonDeleteTruck.Text = "Delete";
            this.buttonDeleteTruck.UseVisualStyleBackColor = false;
            // 
            // buttonEditTruck
            // 
            this.buttonEditTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditTruck.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonEditTruck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditTruck.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.buttonEditTruck.FlatAppearance.BorderSize = 0;
            this.buttonEditTruck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditTruck.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditTruck.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonEditTruck.Location = new System.Drawing.Point(1211, 108);
            this.buttonEditTruck.Name = "buttonEditTruck";
            this.buttonEditTruck.Size = new System.Drawing.Size(94, 46);
            this.buttonEditTruck.TabIndex = 9;
            this.buttonEditTruck.Text = "Edit";
            this.buttonEditTruck.UseVisualStyleBackColor = false;
            // 
            // buttonAddedTruck
            // 
            this.buttonAddedTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddedTruck.BackColor = System.Drawing.Color.Green;
            this.buttonAddedTruck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddedTruck.FlatAppearance.BorderSize = 0;
            this.buttonAddedTruck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddedTruck.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddedTruck.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddedTruck.Location = new System.Drawing.Point(1211, 58);
            this.buttonAddedTruck.Name = "buttonAddedTruck";
            this.buttonAddedTruck.Size = new System.Drawing.Size(94, 44);
            this.buttonAddedTruck.TabIndex = 8;
            this.buttonAddedTruck.Text = "Add new";
            this.buttonAddedTruck.UseVisualStyleBackColor = false;
            this.buttonAddedTruck.Click += new System.EventHandler(this.buttonAddedTruck_Click);
            // 
            // buttonSerchTruck
            // 
            this.buttonSerchTruck.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonSerchTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSerchTruck.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonSerchTruck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSerchTruck.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSerchTruck.FlatAppearance.BorderSize = 0;
            this.buttonSerchTruck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSerchTruck.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSerchTruck.ForeColor = System.Drawing.Color.Black;
            this.buttonSerchTruck.Location = new System.Drawing.Point(1096, 22);
            this.buttonSerchTruck.Name = "buttonSerchTruck";
            this.buttonSerchTruck.Size = new System.Drawing.Size(109, 31);
            this.buttonSerchTruck.TabIndex = 7;
            this.buttonSerchTruck.Text = "Serach";
            this.buttonSerchTruck.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(42, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search Truck:";
            // 
            // textSearchTruck
            // 
            this.textSearchTruck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearchTruck.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textSearchTruck.Location = new System.Drawing.Point(186, 25);
            this.textSearchTruck.Name = "textSearchTruck";
            this.textSearchTruck.Size = new System.Drawing.Size(904, 27);
            this.textSearchTruck.TabIndex = 5;
            // 
            // dataGridViewTruck
            // 
            this.dataGridViewTruck.AllowUserToAddRows = false;
            this.dataGridViewTruck.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTruck.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTruck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTruck.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTruck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewTruck.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewTruck.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTruck.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTruck.ColumnHeadersHeight = 29;
            this.dataGridViewTruck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTruck.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTruck.GridColor = System.Drawing.Color.White;
            this.dataGridViewTruck.Location = new System.Drawing.Point(5, 58);
            this.dataGridViewTruck.Name = "dataGridViewTruck";
            this.dataGridViewTruck.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTruck.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTruck.RowHeadersWidth = 51;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTruck.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTruck.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTruck.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.PeachPuff;
            this.dataGridViewTruck.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTruck.RowTemplate.Height = 29;
            this.dataGridViewTruck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTruck.Size = new System.Drawing.Size(1200, 246);
            this.dataGridViewTruck.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1324, 448);
            this.tabControl1.TabIndex = 1;
            // 
            // MachineryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MachineryForm";
            this.Text = "Machinery";
            this.Load += new System.EventHandler(this.MachineryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTruck)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconButton MachExitButton;
        private TabPage tabPage2;
        private Panel panel3;
        private Button buttonCancelTruck;
        private Button buttonSaveTruck;
        private DateTimePicker TruckServDate;
        private ComboBox comboBoxTruck;
        private TextBox TruckRegistration;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox textTrID;
        private Label label4;
        private TabPage tabPage1;
        private Panel panel2;
        public Button buttonDeleteTruck;
        public Button buttonEditTruck;
        public Button buttonAddedTruck;
        public Button buttonSerchTruck;
        private Label label2;
        private TextBox textSearchTruck;
        private DataGridView dataGridViewTruck;
        private TabControl tabControl1;
    }
}