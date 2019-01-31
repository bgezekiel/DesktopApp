namespace ThreadedProject2
{
    partial class Suppliers
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suppliers));
			this.lblProductsSuppliers = new System.Windows.Forms.Label();
			this.LBSuppliers = new System.Windows.Forms.ListBox();
			this.BtnCreateSupplier = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.LBProducts = new System.Windows.Forms.ListBox();
			this.btnCreateProduct = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblProductsSuppliers
			// 
			this.lblProductsSuppliers.AutoSize = true;
			this.lblProductsSuppliers.BackColor = System.Drawing.Color.Transparent;
			this.lblProductsSuppliers.Font = new System.Drawing.Font("Calisto MT", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProductsSuppliers.ForeColor = System.Drawing.Color.Khaki;
			this.lblProductsSuppliers.Location = new System.Drawing.Point(12, 9);
			this.lblProductsSuppliers.Name = "lblProductsSuppliers";
			this.lblProductsSuppliers.Size = new System.Drawing.Size(511, 42);
			this.lblProductsSuppliers.TabIndex = 3;
			this.lblProductsSuppliers.Text = "Create New Supplier/ Products";
			// 
			// LBSuppliers
			// 
			this.LBSuppliers.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.LBSuppliers.FormattingEnabled = true;
			this.LBSuppliers.Location = new System.Drawing.Point(16, 45);
			this.LBSuppliers.Name = "LBSuppliers";
			this.LBSuppliers.Size = new System.Drawing.Size(333, 368);
			this.LBSuppliers.TabIndex = 4;
			// 
			// BtnCreateSupplier
			// 
			this.BtnCreateSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
			this.BtnCreateSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnCreateSupplier.Location = new System.Drawing.Point(61, 428);
			this.BtnCreateSupplier.Name = "BtnCreateSupplier";
			this.BtnCreateSupplier.Size = new System.Drawing.Size(244, 40);
			this.BtnCreateSupplier.TabIndex = 5;
			this.BtnCreateSupplier.Text = "Add Supplier";
			this.BtnCreateSupplier.UseVisualStyleBackColor = false;
			this.BtnCreateSupplier.Click += new System.EventHandler(this.BtnCreateSupplier_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(7, 522);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(165, 40);
			this.button2.TabIndex = 8;
			this.button2.Text = "Back";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(178, 522);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(244, 40);
			this.button1.TabIndex = 7;
			this.button1.Text = "Exit Program";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.LBSuppliers);
			this.groupBox1.Controls.Add(this.BtnCreateSupplier);
			this.groupBox1.Location = new System.Drawing.Point(480, 63);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(363, 488);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Khaki;
			this.label1.Location = new System.Drawing.Point(99, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 28);
			this.label1.TabIndex = 6;
			this.label1.Text = "Supplier List";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.LBProducts);
			this.groupBox2.Controls.Add(this.btnCreateProduct);
			this.groupBox2.Location = new System.Drawing.Point(37, 54);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(367, 450);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Khaki;
			this.label2.Location = new System.Drawing.Point(104, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 28);
			this.label2.TabIndex = 6;
			this.label2.Text = "Products List";
			// 
			// LBProducts
			// 
			this.LBProducts.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.LBProducts.FormattingEnabled = true;
			this.LBProducts.Location = new System.Drawing.Point(16, 45);
			this.LBProducts.Name = "LBProducts";
			this.LBProducts.Size = new System.Drawing.Size(333, 342);
			this.LBProducts.TabIndex = 4;
			// 
			// btnCreateProduct
			// 
			this.btnCreateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
			this.btnCreateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreateProduct.Location = new System.Drawing.Point(53, 393);
			this.btnCreateProduct.Name = "btnCreateProduct";
			this.btnCreateProduct.Size = new System.Drawing.Size(244, 40);
			this.btnCreateProduct.TabIndex = 5;
			this.btnCreateProduct.Text = "Add Product";
			this.btnCreateProduct.UseVisualStyleBackColor = false;
			this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
			// 
			// Suppliers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(871, 574);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblProductsSuppliers);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Suppliers";
			this.Text = "Suppliers";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductsSuppliers;
        private System.Windows.Forms.ListBox LBSuppliers;
        private System.Windows.Forms.Button BtnCreateSupplier;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LBProducts;
        private System.Windows.Forms.Button btnCreateProduct;
    }
}