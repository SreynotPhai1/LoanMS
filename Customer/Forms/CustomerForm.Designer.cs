﻿namespace LoanMs.Forms
{
    partial class CustomerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgCustomer = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgAddress = new System.Windows.Forms.DataGridView();
            this.dtpDoB = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPoB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.epPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPoB = new System.Windows.Forms.ErrorProvider(this.components);
            this.epGender = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDateOfBirth = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCustomerName = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPoB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDateOfBirth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCustomerName)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 58);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1122, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 28);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnEdit);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.btnNew);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 58);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.panel5.Size = new System.Drawing.Size(1172, 37);
            this.panel5.TabIndex = 10;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(85)))), ((int)(((byte)(131)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(97, 4);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 29);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 4);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(8, 29);
            this.panel8.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1164, 4);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(8, 29);
            this.panel7.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(85)))), ((int)(((byte)(131)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(185, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(85)))), ((int)(((byte)(131)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(0, 4);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(93, 29);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgCustomer
            // 
            this.dgCustomer.AllowUserToAddRows = false;
            this.dgCustomer.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgCustomer.Location = new System.Drawing.Point(0, 95);
            this.dgCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgCustomer.Name = "dgCustomer";
            this.dgCustomer.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(206)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.dgCustomer.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgCustomer.RowTemplate.Height = 24;
            this.dgCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCustomer.Size = new System.Drawing.Size(268, 436);
            this.dgCustomer.TabIndex = 11;
            this.dgCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomer_CellClick_1);
            this.dgCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCustomer_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgAddress);
            this.panel3.Controls.Add(this.dtpDoB);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.rdFemale);
            this.panel3.Controls.Add(this.rdMale);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtPhone);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtPoB);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtCustomerName);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(268, 95);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(904, 436);
            this.panel3.TabIndex = 12;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dgAddress
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAddress.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAddress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgAddress.Location = new System.Drawing.Point(0, 228);
            this.dgAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgAddress.MultiSelect = false;
            this.dgAddress.Name = "dgAddress";
            this.dgAddress.ReadOnly = true;
            this.dgAddress.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.dgAddress.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgAddress.RowTemplate.Height = 24;
            this.dgAddress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAddress.Size = new System.Drawing.Size(904, 208);
            this.dgAddress.TabIndex = 7;
            this.dgAddress.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAddress_CellContentClick);
            // 
            // dtpDoB
            // 
            this.dtpDoB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDoB.Font = new System.Drawing.Font("Garamond", 12F);
            this.dtpDoB.Location = new System.Drawing.Point(564, 37);
            this.dtpDoB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.Size = new System.Drawing.Size(216, 25);
            this.dtpDoB.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(85)))), ((int)(((byte)(131)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(688, 163);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 37);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(17, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // rdFemale
            // 
            this.rdFemale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdFemale.AutoSize = true;
            this.rdFemale.Font = new System.Drawing.Font("Garamond", 12F);
            this.rdFemale.Location = new System.Drawing.Point(312, 85);
            this.rdFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(72, 22);
            this.rdFemale.TabIndex = 4;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdMale.AutoSize = true;
            this.rdMale.Font = new System.Drawing.Font("Garamond", 12F);
            this.rdMale.Location = new System.Drawing.Point(204, 85);
            this.rdMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(57, 22);
            this.rdMale.TabIndex = 4;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Font = new System.Drawing.Font("Garamond", 12F);
            this.txtEmail.Location = new System.Drawing.Point(204, 161);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(204, 25);
            this.txtEmail.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label6.Location = new System.Drawing.Point(98, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Gender :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label5.Location = new System.Drawing.Point(106, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email :";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Font = new System.Drawing.Font("Garamond", 12F);
            this.txtPhone.Location = new System.Drawing.Point(204, 120);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(204, 25);
            this.txtPhone.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label4.Location = new System.Drawing.Point(106, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phone :";
            // 
            // txtPoB
            // 
            this.txtPoB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPoB.Font = new System.Drawing.Font("Garamond", 12F);
            this.txtPoB.Location = new System.Drawing.Point(517, 85);
            this.txtPoB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPoB.Multiline = true;
            this.txtPoB.Name = "txtPoB";
            this.txtPoB.Size = new System.Drawing.Size(263, 75);
            this.txtPoB.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label8.Location = new System.Drawing.Point(454, 87);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "POB :";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCustomerName.Font = new System.Drawing.Font("Garamond", 12F);
            this.txtCustomerName.Location = new System.Drawing.Point(204, 39);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(204, 25);
            this.txtCustomerName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label7.Location = new System.Drawing.Point(454, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Date of Birth :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(32)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(34, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Name :";
            // 
            // epPhone
            // 
            this.epPhone.ContainerControl = this;
            // 
            // epPoB
            // 
            this.epPoB.ContainerControl = this;
            // 
            // epGender
            // 
            this.epGender.ContainerControl = this;
            // 
            // epDateOfBirth
            // 
            this.epDateOfBirth.ContainerControl = this;
            // 
            // epCustomerName
            // 
            this.epCustomerName.ContainerControl = this;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 531);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgCustomer);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPoB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDateOfBirth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCustomerName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgCustomer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgAddress;
        private System.Windows.Forms.DateTimePicker dtpDoB;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPoB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider epPhone;
        private System.Windows.Forms.ErrorProvider epPoB;
        private System.Windows.Forms.ErrorProvider epGender;
        private System.Windows.Forms.ErrorProvider epDateOfBirth;
        private System.Windows.Forms.ErrorProvider epCustomerName;
    }
}