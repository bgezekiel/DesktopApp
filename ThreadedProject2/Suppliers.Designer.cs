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
            this.BtnCreate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LBProducts = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
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
            this.LBSuppliers.Location = new System.Drawing.Point(61, 67);
            this.LBSuppliers.Name = "LBSuppliers";
            this.LBSuppliers.Size = new System.Drawing.Size(333, 381);
            this.LBSuppliers.TabIndex = 4;
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
            this.BtnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.Location = new System.Drawing.Point(94, 454);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(244, 40);
            this.BtnCreate.TabIndex = 5;
            this.BtnCreate.Text = "Add Supplier";
            this.BtnCreate.UseVisualStyleBackColor = false;

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
            // LBProducts
            // 
            this.LBProducts.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LBProducts.FormattingEnabled = true;
            this.LBProducts.Location = new System.Drawing.Point(495, 67);
            this.LBProducts.Name = "LBProducts";
            this.LBProducts.Size = new System.Drawing.Size(333, 381);
            this.LBProducts.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(544, 454);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 40);
            this.button3.TabIndex = 10;
            this.button3.Text = "Add Product";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(871, 574);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LBProducts);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.LBSuppliers);
            this.Controls.Add(this.lblProductsSuppliers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Suppliers";
            this.Text = "Suppliers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductsSuppliers;
        private System.Windows.Forms.ListBox LBSuppliers;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox LBProducts;
        private System.Windows.Forms.Button button3;
    }
}