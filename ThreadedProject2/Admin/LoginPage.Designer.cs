namespace ThreadedProject2.Admin {
	partial class LoginPage {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
			this.FieldPassword = new System.Windows.Forms.TextBox();
			this.LblUsername = new System.Windows.Forms.Label();
			this.LblPassword = new System.Windows.Forms.Label();
			this.LblHeader = new System.Windows.Forms.Label();
			this.LblDesc1 = new System.Windows.Forms.Label();
			this.LblDesc2 = new System.Windows.Forms.Label();
			this.LblDesc3 = new System.Windows.Forms.Label();
			this.BtnAdmin = new System.Windows.Forms.Button();
			this.BtnLogin = new System.Windows.Forms.Button();
			this.CBAgents = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// FieldPassword
			// 
			this.FieldPassword.Location = new System.Drawing.Point(12, 236);
			this.FieldPassword.Name = "FieldPassword";
			this.FieldPassword.Size = new System.Drawing.Size(378, 20);
			this.FieldPassword.TabIndex = 1;
			this.FieldPassword.UseSystemPasswordChar = true;
			// 
			// LblUsername
			// 
			this.LblUsername.AutoSize = true;
			this.LblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblUsername.Location = new System.Drawing.Point(13, 120);
			this.LblUsername.Name = "LblUsername";
			this.LblUsername.Size = new System.Drawing.Size(40, 13);
			this.LblUsername.TabIndex = 2;
			this.LblUsername.Text = "Agent";
			// 
			// LblPassword
			// 
			this.LblPassword.AutoSize = true;
			this.LblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblPassword.Location = new System.Drawing.Point(13, 217);
			this.LblPassword.Name = "LblPassword";
			this.LblPassword.Size = new System.Drawing.Size(98, 13);
			this.LblPassword.TabIndex = 3;
			this.LblPassword.Text = "Agent Password";
			// 
			// LblHeader
			// 
			this.LblHeader.AutoSize = true;
			this.LblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblHeader.Location = new System.Drawing.Point(12, 13);
			this.LblHeader.Name = "LblHeader";
			this.LblHeader.Size = new System.Drawing.Size(204, 33);
			this.LblHeader.TabIndex = 4;
			this.LblHeader.Text = "Travel Experts";
			// 
			// LblDesc1
			// 
			this.LblDesc1.AutoSize = true;
			this.LblDesc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblDesc1.Location = new System.Drawing.Point(12, 50);
			this.LblDesc1.Name = "LblDesc1";
			this.LblDesc1.Size = new System.Drawing.Size(202, 13);
			this.LblDesc1.TabIndex = 5;
			this.LblDesc1.Text = "You are entering a restricted area!";
			// 
			// LblDesc2
			// 
			this.LblDesc2.AutoSize = true;
			this.LblDesc2.Location = new System.Drawing.Point(12, 67);
			this.LblDesc2.Name = "LblDesc2";
			this.LblDesc2.Size = new System.Drawing.Size(262, 13);
			this.LblDesc2.TabIndex = 6;
			this.LblDesc2.Text = "You must enter a username and password to proceed.";
			// 
			// LblDesc3
			// 
			this.LblDesc3.AutoSize = true;
			this.LblDesc3.Location = new System.Drawing.Point(12, 84);
			this.LblDesc3.Name = "LblDesc3";
			this.LblDesc3.Size = new System.Drawing.Size(265, 13);
			this.LblDesc3.TabIndex = 7;
			this.LblDesc3.Text = "Contact your administrator if you do not know your info.";
			// 
			// BtnAdmin
			// 
			this.BtnAdmin.Location = new System.Drawing.Point(12, 465);
			this.BtnAdmin.Name = "BtnAdmin";
			this.BtnAdmin.Size = new System.Drawing.Size(378, 23);
			this.BtnAdmin.TabIndex = 8;
			this.BtnAdmin.Text = "Set Agent Password";
			this.BtnAdmin.UseVisualStyleBackColor = true;
			this.BtnAdmin.Click += new System.EventHandler(this.AdminLogin);
			// 
			// BtnLogin
			// 
			this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnLogin.Location = new System.Drawing.Point(12, 400);
			this.BtnLogin.Name = "BtnLogin";
			this.BtnLogin.Size = new System.Drawing.Size(378, 59);
			this.BtnLogin.TabIndex = 9;
			this.BtnLogin.Text = "Log In";
			this.BtnLogin.UseVisualStyleBackColor = true;
			this.BtnLogin.Click += new System.EventHandler(this.BtnLogIn);
			// 
			// CBAgents
			// 
			this.CBAgents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CBAgents.FormattingEnabled = true;
			this.CBAgents.Location = new System.Drawing.Point(12, 136);
			this.CBAgents.Name = "CBAgents";
			this.CBAgents.Size = new System.Drawing.Size(378, 21);
			this.CBAgents.TabIndex = 11;
			// 
			// LoginPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 500);
			this.Controls.Add(this.CBAgents);
			this.Controls.Add(this.BtnLogin);
			this.Controls.Add(this.BtnAdmin);
			this.Controls.Add(this.LblDesc3);
			this.Controls.Add(this.LblDesc2);
			this.Controls.Add(this.LblDesc1);
			this.Controls.Add(this.LblHeader);
			this.Controls.Add(this.LblPassword);
			this.Controls.Add(this.LblUsername);
			this.Controls.Add(this.FieldPassword);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "LoginPage";
			this.Text = "LoginPage";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox FieldPassword;
		private System.Windows.Forms.Label LblUsername;
		private System.Windows.Forms.Label LblPassword;
		private System.Windows.Forms.Label LblHeader;
		private System.Windows.Forms.Label LblDesc1;
		private System.Windows.Forms.Label LblDesc2;
		private System.Windows.Forms.Label LblDesc3;
		private System.Windows.Forms.Button BtnAdmin;
		private System.Windows.Forms.Button BtnLogin;
		private System.Windows.Forms.ComboBox CBAgents;
	}
}