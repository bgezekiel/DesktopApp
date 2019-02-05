namespace ThreadedProject2.Admin {
	partial class ForcePasswordSet {
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
			this.button1 = new System.Windows.Forms.Button();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.FieldPass = new System.Windows.Forms.TextBox();
			this.FieldConf = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(279, 263);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(102, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Change";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Change);
			// 
			// BtnCancel
			// 
			this.BtnCancel.Location = new System.Drawing.Point(13, 262);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(75, 23);
			this.BtnCancel.TabIndex = 1;
			this.BtnCancel.Text = "Cancel";
			this.BtnCancel.UseVisualStyleBackColor = true;
			this.BtnCancel.Click += new System.EventHandler(this.Cancel);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(278, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "The administrator has requested you reset your password.";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(238, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Please enter and confirm a new password below.";
			// 
			// FieldPass
			// 
			this.FieldPass.Location = new System.Drawing.Point(13, 118);
			this.FieldPass.Name = "FieldPass";
			this.FieldPass.Size = new System.Drawing.Size(368, 20);
			this.FieldPass.TabIndex = 4;
			this.FieldPass.UseSystemPasswordChar = true;
			// 
			// FieldConf
			// 
			this.FieldConf.Location = new System.Drawing.Point(13, 194);
			this.FieldConf.Name = "FieldConf";
			this.FieldConf.Size = new System.Drawing.Size(368, 20);
			this.FieldConf.TabIndex = 5;
			this.FieldConf.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 175);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Confirm Password";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 99);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "New Password";
			// 
			// ForcePasswordSet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(393, 298);
			this.ControlBox = false;
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.FieldConf);
			this.Controls.Add(this.FieldPass);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "ForcePasswordSet";
			this.Text = "Create New Password";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox FieldPass;
		private System.Windows.Forms.TextBox FieldConf;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}