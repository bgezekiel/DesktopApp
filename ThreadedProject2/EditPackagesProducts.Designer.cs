namespace ThreadedProject2 {
	partial class EditPackagesProducts {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPackagesProducts));
			this.lblPackages = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnReturn = new System.Windows.Forms.Button();
			this.CBProducts = new System.Windows.Forms.ComboBox();
			this.LBAll = new System.Windows.Forms.ListBox();
			this.LBIn = new System.Windows.Forms.ListBox();
			this.BtnAdd = new System.Windows.Forms.Button();
			this.BtnRemove = new System.Windows.Forms.Button();
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
			this.lblPackages.Size = new System.Drawing.Size(220, 42);
			this.lblPackages.TabIndex = 4;
			this.lblPackages.Text = "All Suppliers";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Calisto MT", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Khaki;
			this.label1.Location = new System.Drawing.Point(589, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(191, 42);
			this.label1.TabIndex = 5;
			this.label1.Text = "In Package";
			// 
			// BtnReturn
			// 
			this.BtnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
			this.BtnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnReturn.Location = new System.Drawing.Point(326, 521);
			this.BtnReturn.Name = "BtnReturn";
			this.BtnReturn.Size = new System.Drawing.Size(264, 48);
			this.BtnReturn.TabIndex = 20;
			this.BtnReturn.Text = "Return";
			this.BtnReturn.UseVisualStyleBackColor = false;
			this.BtnReturn.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// CBProducts
			// 
			this.CBProducts.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.CBProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CBProducts.FormattingEnabled = true;
			this.CBProducts.Location = new System.Drawing.Point(20, 65);
			this.CBProducts.Name = "CBProducts";
			this.CBProducts.Size = new System.Drawing.Size(300, 21);
			this.CBProducts.TabIndex = 22;
			this.CBProducts.SelectedValueChanged += new System.EventHandler(this.VCChange);
			// 
			// LBAll
			// 
			this.LBAll.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.LBAll.FormattingEnabled = true;
			this.LBAll.Location = new System.Drawing.Point(20, 91);
			this.LBAll.Name = "LBAll";
			this.LBAll.Size = new System.Drawing.Size(300, 420);
			this.LBAll.TabIndex = 21;
			// 
			// LBIn
			// 
			this.LBIn.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.LBIn.FormattingEnabled = true;
			this.LBIn.Location = new System.Drawing.Point(596, 83);
			this.LBIn.Name = "LBIn";
			this.LBIn.Size = new System.Drawing.Size(327, 433);
			this.LBIn.TabIndex = 23;
			// 
			// BtnAdd
			// 
			this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
			this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnAdd.Location = new System.Drawing.Point(20, 521);
			this.BtnAdd.Name = "BtnAdd";
			this.BtnAdd.Size = new System.Drawing.Size(300, 48);
			this.BtnAdd.TabIndex = 24;
			this.BtnAdd.Text = "Add";
			this.BtnAdd.UseVisualStyleBackColor = false;
			this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// BtnRemove
			// 
			this.BtnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
			this.BtnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnRemove.Location = new System.Drawing.Point(596, 521);
			this.BtnRemove.Name = "BtnRemove";
			this.BtnRemove.Size = new System.Drawing.Size(327, 48);
			this.BtnRemove.TabIndex = 25;
			this.BtnRemove.Text = "Remove";
			this.BtnRemove.UseVisualStyleBackColor = false;
			this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
			// 
			// EditPackagesProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(935, 581);
			this.Controls.Add(this.BtnRemove);
			this.Controls.Add(this.BtnAdd);
			this.Controls.Add(this.LBIn);
			this.Controls.Add(this.CBProducts);
			this.Controls.Add(this.LBAll);
			this.Controls.Add(this.BtnReturn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblPackages);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "EditPackagesProducts";
			this.Text = "EditPackagesProducts";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblPackages;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnReturn;
		private System.Windows.Forms.ComboBox CBProducts;
		private System.Windows.Forms.ListBox LBAll;
		private System.Windows.Forms.ListBox LBIn;
		private System.Windows.Forms.Button BtnAdd;
		private System.Windows.Forms.Button BtnRemove;
	}
}