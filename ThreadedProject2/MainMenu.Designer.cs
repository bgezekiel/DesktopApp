namespace ThreadedProject2
{
    partial class MainMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
			this.btnViewPackages = new System.Windows.Forms.Button();
			this.btnAddPackages = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.BtnSuppliers = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.LblAgent = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnViewPackages
			// 
			this.btnViewPackages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
			this.btnViewPackages.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnViewPackages.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnViewPackages.FlatAppearance.BorderSize = 5;
			this.btnViewPackages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(167)))), ((int)(((byte)(25)))));
			this.btnViewPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnViewPackages.Location = new System.Drawing.Point(80, 284);
			this.btnViewPackages.Name = "btnViewPackages";
			this.btnViewPackages.Size = new System.Drawing.Size(251, 136);
			this.btnViewPackages.TabIndex = 0;
			this.btnViewPackages.Text = "View/Edit Packages";
			this.btnViewPackages.UseVisualStyleBackColor = false;
			this.btnViewPackages.Click += new System.EventHandler(this.btnViewPackages_Click);
			// 
			// btnAddPackages
			// 
			this.btnAddPackages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
			this.btnAddPackages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnAddPackages.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddPackages.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnAddPackages.FlatAppearance.BorderSize = 5;
			this.btnAddPackages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(167)))), ((int)(((byte)(25)))));
			this.btnAddPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddPackages.Location = new System.Drawing.Point(80, 133);
			this.btnAddPackages.Name = "btnAddPackages";
			this.btnAddPackages.Size = new System.Drawing.Size(251, 128);
			this.btnAddPackages.TabIndex = 1;
			this.btnAddPackages.Text = "Add / Create New Packages";
			this.btnAddPackages.UseVisualStyleBackColor = false;
			this.btnAddPackages.Click += new System.EventHandler(this.btnAddPackages_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.BackColor = System.Drawing.Color.Transparent;
			this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(25)))));
			this.lblTitle.Location = new System.Drawing.Point(22, 44);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(410, 65);
			this.lblTitle.TabIndex = 2;
			this.lblTitle.Text = "Travel Experts";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(12, 448);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(172, 37);
			this.button2.TabIndex = 19;
			this.button2.Text = "Exit Program";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// BtnSuppliers
			// 
			this.BtnSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
			this.BtnSuppliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.BtnSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnSuppliers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.BtnSuppliers.FlatAppearance.BorderSize = 5;
			this.BtnSuppliers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(167)))), ((int)(((byte)(25)))));
			this.BtnSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnSuppliers.Location = new System.Drawing.Point(473, 131);
			this.BtnSuppliers.Name = "BtnSuppliers";
			this.BtnSuppliers.Size = new System.Drawing.Size(256, 132);
			this.BtnSuppliers.TabIndex = 20;
			this.BtnSuppliers.Text = "Create / Delete Suppliers and Products";
			this.BtnSuppliers.UseVisualStyleBackColor = false;
			this.BtnSuppliers.Click += new System.EventHandler(this.BtnSuppliers_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.button1.FlatAppearance.BorderSize = 5;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(167)))), ((int)(((byte)(25)))));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(473, 284);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(256, 136);
			this.button1.TabIndex = 21;
			this.button1.Text = "Modify Products and Suppliers";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// LblAgent
			// 
			this.LblAgent.AutoSize = true;
			this.LblAgent.BackColor = System.Drawing.Color.Transparent;
			this.LblAgent.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblAgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.LblAgent.Location = new System.Drawing.Point(428, 70);
			this.LblAgent.Name = "LblAgent";
			this.LblAgent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.LblAgent.Size = new System.Drawing.Size(122, 39);
			this.LblAgent.TabIndex = 22;
			this.LblAgent.Text = "AGENT";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.label1.Location = new System.Drawing.Point(428, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 24);
			this.label1.TabIndex = 23;
			this.label1.Text = "Logged In";
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(796, 497);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LblAgent);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.BtnSuppliers);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnAddPackages);
			this.Controls.Add(this.btnViewPackages);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainMenu";
			this.Text = "Main Menu";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewPackages;
        private System.Windows.Forms.Button btnAddPackages;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnSuppliers;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label LblAgent;
		private System.Windows.Forms.Label label1;
	}
}

