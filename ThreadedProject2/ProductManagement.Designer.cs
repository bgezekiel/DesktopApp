namespace ThreadedProject2
{
    partial class ProductManagement
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagement));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnCreatePackage = new System.Windows.Forms.Button();
			this.lblSelectSuppliers = new System.Windows.Forms.Label();
			this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
			this.lstProducts = new System.Windows.Forms.ListBox();
			this.lblPackages = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.listProducts = new System.Windows.Forms.ListBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnExitApp = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.btnCreatePackage);
			this.groupBox1.Controls.Add(this.lblSelectSuppliers);
			this.groupBox1.Controls.Add(this.comboBoxSupplier);
			this.groupBox1.Controls.Add(this.lstProducts);
			this.groupBox1.Location = new System.Drawing.Point(507, 60);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(328, 494);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			// 
			// btnCreatePackage
			// 
			this.btnCreatePackage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
			this.btnCreatePackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreatePackage.Location = new System.Drawing.Point(59, 430);
			this.btnCreatePackage.Name = "btnCreatePackage";
			this.btnCreatePackage.Size = new System.Drawing.Size(213, 37);
			this.btnCreatePackage.TabIndex = 23;
			this.btnCreatePackage.Text = "Update";
			this.btnCreatePackage.UseVisualStyleBackColor = false;
			// 
			// lblSelectSuppliers
			// 
			this.lblSelectSuppliers.AutoSize = true;
			this.lblSelectSuppliers.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSelectSuppliers.ForeColor = System.Drawing.Color.Khaki;
			this.lblSelectSuppliers.Location = new System.Drawing.Point(73, 12);
			this.lblSelectSuppliers.Name = "lblSelectSuppliers";
			this.lblSelectSuppliers.Size = new System.Drawing.Size(164, 28);
			this.lblSelectSuppliers.TabIndex = 5;
			this.lblSelectSuppliers.Text = "Select Supplier";
			// 
			// comboBoxSupplier
			// 
			this.comboBoxSupplier.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.comboBoxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSupplier.FormattingEnabled = true;
			this.comboBoxSupplier.Location = new System.Drawing.Point(14, 43);
			this.comboBoxSupplier.Name = "comboBoxSupplier";
			this.comboBoxSupplier.Size = new System.Drawing.Size(298, 21);
			this.comboBoxSupplier.TabIndex = 1;
			// 
			// lstProducts
			// 
			this.lstProducts.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.lstProducts.FormattingEnabled = true;
			this.lstProducts.Location = new System.Drawing.Point(14, 69);
			this.lstProducts.Name = "lstProducts";
			this.lstProducts.Size = new System.Drawing.Size(299, 342);
			this.lstProducts.TabIndex = 0;
			// 
			// lblPackages
			// 
			this.lblPackages.AutoSize = true;
			this.lblPackages.BackColor = System.Drawing.Color.Transparent;
			this.lblPackages.Font = new System.Drawing.Font("Calisto MT", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPackages.ForeColor = System.Drawing.Color.Khaki;
			this.lblPackages.Location = new System.Drawing.Point(12, 9);
			this.lblPackages.Name = "lblPackages";
			this.lblPackages.Size = new System.Drawing.Size(512, 42);
			this.lblPackages.TabIndex = 8;
			this.lblPackages.Text = "Manage Products and Suppliers";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.listProducts);
			this.groupBox2.Location = new System.Drawing.Point(19, 60);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(311, 431);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Khaki;
			this.label1.Location = new System.Drawing.Point(98, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 28);
			this.label1.TabIndex = 5;
			this.label1.Text = "Products";
			// 
			// listProducts
			// 
			this.listProducts.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.listProducts.FormattingEnabled = true;
			this.listProducts.Location = new System.Drawing.Point(6, 43);
			this.listProducts.Name = "listProducts";
			this.listProducts.Size = new System.Drawing.Size(299, 381);
			this.listProducts.TabIndex = 0;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(365, 129);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(98, 37);
			this.btnAdd.TabIndex = 21;
			this.btnAdd.Text = ">>";
			this.btnAdd.UseVisualStyleBackColor = false;
			// 
			// btnRemove
			// 
			this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
			this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemove.Location = new System.Drawing.Point(365, 189);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(98, 37);
			this.btnRemove.TabIndex = 22;
			this.btnRemove.Text = "<<";
			this.btnRemove.UseVisualStyleBackColor = false;
			// 
			// btnExitApp
			// 
			this.btnExitApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
			this.btnExitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExitApp.Location = new System.Drawing.Point(173, 507);
			this.btnExitApp.Name = "btnExitApp";
			this.btnExitApp.Size = new System.Drawing.Size(150, 37);
			this.btnExitApp.TabIndex = 26;
			this.btnExitApp.Text = "Exit";
			this.btnExitApp.UseVisualStyleBackColor = false;
			this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
			this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Location = new System.Drawing.Point(25, 507);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(125, 37);
			this.btnBack.TabIndex = 25;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// ProductManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(895, 566);
			this.Controls.Add(this.btnExitApp);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.lblPackages);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ProductManagement";
			this.Text = "ProductManagement";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSelectSuppliers;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Label lblPackages;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listProducts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreatePackage;
    }
}