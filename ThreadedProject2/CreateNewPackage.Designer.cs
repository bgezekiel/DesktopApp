namespace ThreadedProject2
{
    partial class CreateNewPackage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewPackage));
            this.lblPackages = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSelectSuppliers = new System.Windows.Forms.Label();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.lstSuppliers = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fieldDesc = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCreatePackage = new System.Windows.Forms.Button();
            this.numAgentComm = new System.Windows.Forms.NumericUpDown();
            this.numBasePrice = new System.Windows.Forms.NumericUpDown();
            this.DTPackageEnd = new System.Windows.Forms.DateTimePicker();
            this.DTPackageStart = new System.Windows.Forms.DateTimePicker();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPackageProducts = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAgentComm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBasePrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPackages
            // 
            this.lblPackages.AutoSize = true;
            this.lblPackages.BackColor = System.Drawing.Color.Transparent;
            this.lblPackages.Font = new System.Drawing.Font("Calisto MT", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackages.ForeColor = System.Drawing.Color.Khaki;
            this.lblPackages.Location = new System.Drawing.Point(12, 9);
            this.lblPackages.Name = "lblPackages";
            this.lblPackages.Size = new System.Drawing.Size(344, 42);
            this.lblPackages.TabIndex = 5;
            this.lblPackages.Text = "Create New Package";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblSelectSuppliers);
            this.groupBox1.Controls.Add(this.comboBoxProducts);
            this.groupBox1.Controls.Add(this.lstSuppliers);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 431);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lblSelectSuppliers
            // 
            this.lblSelectSuppliers.AutoSize = true;
            this.lblSelectSuppliers.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSuppliers.ForeColor = System.Drawing.Color.Khaki;
            this.lblSelectSuppliers.Location = new System.Drawing.Point(73, 12);
            this.lblSelectSuppliers.Name = "lblSelectSuppliers";
            this.lblSelectSuppliers.Size = new System.Drawing.Size(159, 28);
            this.lblSelectSuppliers.TabIndex = 5;
            this.lblSelectSuppliers.Text = "Select Product";
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(7, 43);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(298, 21);
            this.comboBoxProducts.TabIndex = 1;
            this.comboBoxProducts.SelectedValueChanged += new System.EventHandler(this.SelectValChanged);
            // 
            // lstSuppliers
            // 
            this.lstSuppliers.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstSuppliers.FormattingEnabled = true;
            this.lstSuppliers.Location = new System.Drawing.Point(6, 69);
            this.lstSuppliers.Name = "lstSuppliers";
            this.lstSuppliers.Size = new System.Drawing.Size(299, 355);
            this.lstSuppliers.TabIndex = 0;
            this.lstSuppliers.DoubleClick += new System.EventHandler(this.BtnAddSelected);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(336, 164);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 37);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAddSelected);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(337, 246);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(98, 37);
            this.btnRemove.TabIndex = 21;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemoveSelected);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.fieldDesc);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnCreatePackage);
            this.groupBox2.Controls.Add(this.numAgentComm);
            this.groupBox2.Controls.Add(this.numBasePrice);
            this.groupBox2.Controls.Add(this.DTPackageEnd);
            this.groupBox2.Controls.Add(this.DTPackageStart);
            this.groupBox2.Controls.Add(this.txtPackageName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lstPackageProducts);
            this.groupBox2.Location = new System.Drawing.Point(446, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 504);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // fieldDesc
            // 
            this.fieldDesc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.fieldDesc.Location = new System.Drawing.Point(5, 321);
            this.fieldDesc.Name = "fieldDesc";
            this.fieldDesc.Size = new System.Drawing.Size(497, 110);
            this.fieldDesc.TabIndex = 24;
            this.fieldDesc.Text = "Package Description";
            this.fieldDesc.TextChanged += new System.EventHandler(this.FChangeValue);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Khaki;
            this.label7.Location = new System.Drawing.Point(2, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "New Package Description";
            // 
            // btnCreatePackage
            // 
            this.btnCreatePackage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
            this.btnCreatePackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePackage.Location = new System.Drawing.Point(146, 449);
            this.btnCreatePackage.Name = "btnCreatePackage";
            this.btnCreatePackage.Size = new System.Drawing.Size(213, 37);
            this.btnCreatePackage.TabIndex = 22;
            this.btnCreatePackage.Text = "Create Package";
            this.btnCreatePackage.UseVisualStyleBackColor = false;
            this.btnCreatePackage.Click += new System.EventHandler(this.BtnCreate);
            // 
            // numAgentComm
            // 
            this.numAgentComm.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.numAgentComm.DecimalPlaces = 2;
            this.numAgentComm.Location = new System.Drawing.Point(270, 273);
            this.numAgentComm.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numAgentComm.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numAgentComm.Name = "numAgentComm";
            this.numAgentComm.Size = new System.Drawing.Size(215, 20);
            this.numAgentComm.TabIndex = 19;
            this.numAgentComm.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numBasePrice
            // 
            this.numBasePrice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.numBasePrice.DecimalPlaces = 2;
            this.numBasePrice.Location = new System.Drawing.Point(272, 225);
            this.numBasePrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBasePrice.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numBasePrice.Name = "numBasePrice";
            this.numBasePrice.Size = new System.Drawing.Size(215, 20);
            this.numBasePrice.TabIndex = 18;
            this.numBasePrice.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // DTPackageEnd
            // 
            this.DTPackageEnd.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.DTPackageEnd.Location = new System.Drawing.Point(272, 168);
            this.DTPackageEnd.Name = "DTPackageEnd";
            this.DTPackageEnd.Size = new System.Drawing.Size(215, 20);
            this.DTPackageEnd.TabIndex = 17;
            this.DTPackageEnd.ValueChanged += new System.EventHandler(this.ChangeDTPs);
            // 
            // DTPackageStart
            // 
            this.DTPackageStart.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.DTPackageStart.Location = new System.Drawing.Point(272, 106);
            this.DTPackageStart.Name = "DTPackageStart";
            this.DTPackageStart.Size = new System.Drawing.Size(215, 20);
            this.DTPackageStart.TabIndex = 16;
            this.DTPackageStart.ValueChanged += new System.EventHandler(this.ChangeDTPs);
            // 
            // txtPackageName
            // 
            this.txtPackageName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPackageName.Location = new System.Drawing.Point(272, 49);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(218, 20);
            this.txtPackageName.TabIndex = 11;
            this.txtPackageName.Text = "Package Name";
            this.txtPackageName.TextChanged += new System.EventHandler(this.FChangeValue);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Khaki;
            this.label6.Location = new System.Drawing.Point(266, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Agent Commision : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Khaki;
            this.label5.Location = new System.Drawing.Point(268, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Package Base Price : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(268, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Package End Date : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(268, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Package Start Date : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(268, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Package Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "New Package Products";
            // 
            // lstPackageProducts
            // 
            this.lstPackageProducts.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstPackageProducts.FormattingEnabled = true;
            this.lstPackageProducts.Location = new System.Drawing.Point(6, 49);
            this.lstPackageProducts.Name = "lstPackageProducts";
            this.lstPackageProducts.Size = new System.Drawing.Size(248, 238);
            this.lstPackageProducts.TabIndex = 0;
            this.lstPackageProducts.DoubleClick += new System.EventHandler(this.BtnRemoveSelected);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(19, 503);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 37);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BackClick);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(167, 503);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(241, 37);
            this.btnMainMenu.TabIndex = 24;
            this.btnMainMenu.Text = "Exit Program";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.ExitApp);
            // 
            // CreateNewPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(965, 570);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPackages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CreateNewPackage";
            this.Text = "Add New Package";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAgentComm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBasePrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPackages;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSelectSuppliers;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.ListBox lstSuppliers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPackageProducts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numAgentComm;
        private System.Windows.Forms.NumericUpDown numBasePrice;
        private System.Windows.Forms.DateTimePicker DTPackageEnd;
        private System.Windows.Forms.DateTimePicker DTPackageStart;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.Button btnCreatePackage;
        private System.Windows.Forms.RichTextBox fieldDesc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMainMenu;
	}
}