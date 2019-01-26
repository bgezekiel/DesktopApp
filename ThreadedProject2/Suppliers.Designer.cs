namespace ThreadedProject2 {
	partial class Suppliers {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suppliers));
            this.LBSuppliers = new System.Windows.Forms.ListBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblName = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.CBYacht = new System.Windows.Forms.CheckBox();
            this.CBTravel = new System.Windows.Forms.CheckBox();
            this.CBTours = new System.Windows.Forms.CheckBox();
            this.CBRail = new System.Windows.Forms.CheckBox();
            this.CBMotor = new System.Windows.Forms.CheckBox();
            this.CBHotel = new System.Windows.Forms.CheckBox();
            this.CBCruise = new System.Windows.Forms.CheckBox();
            this.CBCar = new System.Windows.Forms.CheckBox();
            this.CBAttractions = new System.Windows.Forms.CheckBox();
            this.CBAir = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBSuppliers
            // 
            this.LBSuppliers.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LBSuppliers.FormattingEnabled = true;
            this.LBSuppliers.Location = new System.Drawing.Point(12, 67);
            this.LBSuppliers.Name = "LBSuppliers";
            this.LBSuppliers.Size = new System.Drawing.Size(333, 433);
            this.LBSuppliers.TabIndex = 0;
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
            this.BtnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.Location = new System.Drawing.Point(55, 506);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(244, 40);
            this.BtnCreate.TabIndex = 1;
            this.BtnCreate.Text = "Add Supplier";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.CreateNewSupplier);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Suppliers";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.LblName);
            this.groupBox1.Controls.Add(this.BtnDelete);
            this.groupBox1.Controls.Add(this.CBYacht);
            this.groupBox1.Controls.Add(this.CBTravel);
            this.groupBox1.Controls.Add(this.CBTours);
            this.groupBox1.Controls.Add(this.CBRail);
            this.groupBox1.Controls.Add(this.CBMotor);
            this.groupBox1.Controls.Add(this.CBHotel);
            this.groupBox1.Controls.Add(this.CBCruise);
            this.groupBox1.Controls.Add(this.CBCar);
            this.groupBox1.Controls.Add(this.CBAttractions);
            this.groupBox1.Controls.Add(this.CBAir);
            this.groupBox1.Font = new System.Drawing.Font("Calisto MT", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Khaki;
            this.groupBox1.Location = new System.Drawing.Point(362, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 503);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier Details";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(2, 187);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(0, 24);
            this.LblName.TabIndex = 10;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Gray;
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.Black;
            this.BtnDelete.Location = new System.Drawing.Point(6, 454);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(273, 40);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Delete Supplier";
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // CBYacht
            // 
            this.CBYacht.AutoSize = true;
            this.CBYacht.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBYacht.Location = new System.Drawing.Point(6, 344);
            this.CBYacht.Name = "CBYacht";
            this.CBYacht.Size = new System.Drawing.Size(214, 28);
            this.CBYacht.TabIndex = 9;
            this.CBYacht.Text = "Yacht/Boat Charters";
            this.CBYacht.UseVisualStyleBackColor = true;
            // 
            // CBTravel
            // 
            this.CBTravel.AutoSize = true;
            this.CBTravel.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTravel.Location = new System.Drawing.Point(6, 310);
            this.CBTravel.Name = "CBTravel";
            this.CBTravel.Size = new System.Drawing.Size(180, 28);
            this.CBTravel.TabIndex = 8;
            this.CBTravel.Text = "Travel Insurance";
            this.CBTravel.UseVisualStyleBackColor = true;
            // 
            // CBTours
            // 
            this.CBTours.AutoSize = true;
            this.CBTours.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTours.Location = new System.Drawing.Point(6, 276);
            this.CBTours.Name = "CBTours";
            this.CBTours.Size = new System.Drawing.Size(81, 28);
            this.CBTours.TabIndex = 7;
            this.CBTours.Text = "Tours";
            this.CBTours.UseVisualStyleBackColor = true;
            // 
            // CBRail
            // 
            this.CBRail.AutoSize = true;
            this.CBRail.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBRail.Location = new System.Drawing.Point(6, 242);
            this.CBRail.Name = "CBRail";
            this.CBRail.Size = new System.Drawing.Size(105, 28);
            this.CBRail.TabIndex = 6;
            this.CBRail.Text = "Railroad";
            this.CBRail.UseVisualStyleBackColor = true;
            // 
            // CBMotor
            // 
            this.CBMotor.AutoSize = true;
            this.CBMotor.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMotor.Location = new System.Drawing.Point(6, 208);
            this.CBMotor.Name = "CBMotor";
            this.CBMotor.Size = new System.Drawing.Size(146, 28);
            this.CBMotor.TabIndex = 5;
            this.CBMotor.Text = "Motor Coach";
            this.CBMotor.UseVisualStyleBackColor = true;
            // 
            // CBHotel
            // 
            this.CBHotel.AutoSize = true;
            this.CBHotel.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBHotel.Location = new System.Drawing.Point(6, 174);
            this.CBHotel.Name = "CBHotel";
            this.CBHotel.Size = new System.Drawing.Size(79, 28);
            this.CBHotel.TabIndex = 4;
            this.CBHotel.Text = "Hotel";
            this.CBHotel.UseVisualStyleBackColor = true;
            // 
            // CBCruise
            // 
            this.CBCruise.AutoSize = true;
            this.CBCruise.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCruise.Location = new System.Drawing.Point(6, 140);
            this.CBCruise.Name = "CBCruise";
            this.CBCruise.Size = new System.Drawing.Size(87, 28);
            this.CBCruise.TabIndex = 3;
            this.CBCruise.Text = "Cruise";
            this.CBCruise.UseVisualStyleBackColor = true;
            // 
            // CBCar
            // 
            this.CBCar.AutoSize = true;
            this.CBCar.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCar.Location = new System.Drawing.Point(6, 106);
            this.CBCar.Name = "CBCar";
            this.CBCar.Size = new System.Drawing.Size(125, 28);
            this.CBCar.TabIndex = 2;
            this.CBCar.Text = "Car Rental";
            this.CBCar.UseVisualStyleBackColor = true;
            // 
            // CBAttractions
            // 
            this.CBAttractions.AutoSize = true;
            this.CBAttractions.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBAttractions.Location = new System.Drawing.Point(6, 72);
            this.CBAttractions.Name = "CBAttractions";
            this.CBAttractions.Size = new System.Drawing.Size(126, 28);
            this.CBAttractions.TabIndex = 1;
            this.CBAttractions.Text = "Attractions";
            this.CBAttractions.UseVisualStyleBackColor = true;
            // 
            // CBAir
            // 
            this.CBAir.AutoSize = true;
            this.CBAir.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBAir.Location = new System.Drawing.Point(6, 38);
            this.CBAir.Name = "CBAir";
            this.CBAir.Size = new System.Drawing.Size(58, 28);
            this.CBAir.TabIndex = 0;
            this.CBAir.Text = "Air";
            this.CBAir.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(184, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit Program";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(117)))), ((int)(((byte)(167)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 583);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(995, 631);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.LBSuppliers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Suppliers";
            this.Text = "Configure Suppliers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox LBSuppliers;
		private System.Windows.Forms.Button BtnCreate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox CBYacht;
		private System.Windows.Forms.CheckBox CBTravel;
		private System.Windows.Forms.CheckBox CBTours;
		private System.Windows.Forms.CheckBox CBRail;
		private System.Windows.Forms.CheckBox CBMotor;
		private System.Windows.Forms.CheckBox CBHotel;
		private System.Windows.Forms.CheckBox CBCruise;
		private System.Windows.Forms.CheckBox CBCar;
		private System.Windows.Forms.CheckBox CBAttractions;
		private System.Windows.Forms.CheckBox CBAir;
		private System.Windows.Forms.Button BtnDelete;
		private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}