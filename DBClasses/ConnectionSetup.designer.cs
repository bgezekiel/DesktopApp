namespace ThreadedProject2 {
	partial class ConnectionSetup {
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
			this.RdBtnWinAuth = new System.Windows.Forms.RadioButton();
			this.RdBtnSQLAuth = new System.Windows.Forms.RadioButton();
			this.BtnConnect = new System.Windows.Forms.Button();
			this.ChUseInstanceName = new System.Windows.Forms.CheckBox();
			this.FieldServerAddress = new System.Windows.Forms.TextBox();
			this.LblAddress = new System.Windows.Forms.Label();
			this.FieldServerInstance = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.FieldSqlUsername = new System.Windows.Forms.TextBox();
			this.LblSqlUsername = new System.Windows.Forms.Label();
			this.LblSqlPassword = new System.Windows.Forms.Label();
			this.FieldSqlPassword = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.LblTitle = new System.Windows.Forms.Label();
			this.LblInfo = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// RdBtnWinAuth
			// 
			this.RdBtnWinAuth.AutoSize = true;
			this.RdBtnWinAuth.Checked = true;
			this.RdBtnWinAuth.ForeColor = System.Drawing.Color.White;
			this.RdBtnWinAuth.Location = new System.Drawing.Point(3, 3);
			this.RdBtnWinAuth.Name = "RdBtnWinAuth";
			this.RdBtnWinAuth.Size = new System.Drawing.Size(162, 17);
			this.RdBtnWinAuth.TabIndex = 0;
			this.RdBtnWinAuth.TabStop = true;
			this.RdBtnWinAuth.Text = "Use Windows Authentication";
			this.RdBtnWinAuth.UseVisualStyleBackColor = true;
			// 
			// RdBtnSQLAuth
			// 
			this.RdBtnSQLAuth.AutoSize = true;
			this.RdBtnSQLAuth.ForeColor = System.Drawing.Color.White;
			this.RdBtnSQLAuth.Location = new System.Drawing.Point(3, 26);
			this.RdBtnSQLAuth.Name = "RdBtnSQLAuth";
			this.RdBtnSQLAuth.Size = new System.Drawing.Size(173, 17);
			this.RdBtnSQLAuth.TabIndex = 1;
			this.RdBtnSQLAuth.Text = "Use SQL Server Authentication";
			this.RdBtnSQLAuth.UseVisualStyleBackColor = true;
			this.RdBtnSQLAuth.CheckedChanged += new System.EventHandler(this.ChangeAuth);
			// 
			// BtnConnect
			// 
			this.BtnConnect.BackColor = System.Drawing.SystemColors.HotTrack;
			this.BtnConnect.Location = new System.Drawing.Point(12, 493);
			this.BtnConnect.Name = "BtnConnect";
			this.BtnConnect.Size = new System.Drawing.Size(319, 54);
			this.BtnConnect.TabIndex = 3;
			this.BtnConnect.Text = "Connect to Server";
			this.BtnConnect.UseVisualStyleBackColor = false;
			this.BtnConnect.Click += new System.EventHandler(this.Connect);
			// 
			// ChUseInstanceName
			// 
			this.ChUseInstanceName.AutoSize = true;
			this.ChUseInstanceName.ForeColor = System.Drawing.Color.White;
			this.ChUseInstanceName.Location = new System.Drawing.Point(11, 220);
			this.ChUseInstanceName.Name = "ChUseInstanceName";
			this.ChUseInstanceName.Size = new System.Drawing.Size(136, 17);
			this.ChUseInstanceName.TabIndex = 4;
			this.ChUseInstanceName.Text = "Specify Instance Name";
			this.ChUseInstanceName.UseVisualStyleBackColor = true;
			this.ChUseInstanceName.CheckedChanged += new System.EventHandler(this.UseInstName);
			// 
			// FieldServerAddress
			// 
			this.FieldServerAddress.Location = new System.Drawing.Point(11, 182);
			this.FieldServerAddress.Name = "FieldServerAddress";
			this.FieldServerAddress.Size = new System.Drawing.Size(319, 20);
			this.FieldServerAddress.TabIndex = 5;
			// 
			// LblAddress
			// 
			this.LblAddress.AutoSize = true;
			this.LblAddress.ForeColor = System.Drawing.Color.White;
			this.LblAddress.Location = new System.Drawing.Point(8, 166);
			this.LblAddress.Name = "LblAddress";
			this.LblAddress.Size = new System.Drawing.Size(79, 13);
			this.LblAddress.TabIndex = 6;
			this.LblAddress.Text = "Server Address";
			// 
			// FieldServerInstance
			// 
			this.FieldServerInstance.Enabled = false;
			this.FieldServerInstance.Location = new System.Drawing.Point(11, 256);
			this.FieldServerInstance.Name = "FieldServerInstance";
			this.FieldServerInstance.Size = new System.Drawing.Size(319, 20);
			this.FieldServerInstance.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(8, 240);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Instance Name";
			// 
			// FieldSqlUsername
			// 
			this.FieldSqlUsername.Enabled = false;
			this.FieldSqlUsername.Location = new System.Drawing.Point(12, 326);
			this.FieldSqlUsername.Name = "FieldSqlUsername";
			this.FieldSqlUsername.Size = new System.Drawing.Size(319, 20);
			this.FieldSqlUsername.TabIndex = 9;
			// 
			// LblSqlUsername
			// 
			this.LblSqlUsername.AutoSize = true;
			this.LblSqlUsername.ForeColor = System.Drawing.Color.White;
			this.LblSqlUsername.Location = new System.Drawing.Point(9, 310);
			this.LblSqlUsername.Name = "LblSqlUsername";
			this.LblSqlUsername.Size = new System.Drawing.Size(43, 13);
			this.LblSqlUsername.TabIndex = 10;
			this.LblSqlUsername.Text = "User ID";
			// 
			// LblSqlPassword
			// 
			this.LblSqlPassword.AutoSize = true;
			this.LblSqlPassword.ForeColor = System.Drawing.Color.White;
			this.LblSqlPassword.Location = new System.Drawing.Point(9, 370);
			this.LblSqlPassword.Name = "LblSqlPassword";
			this.LblSqlPassword.Size = new System.Drawing.Size(78, 13);
			this.LblSqlPassword.TabIndex = 11;
			this.LblSqlPassword.Text = "User Password";
			// 
			// FieldSqlPassword
			// 
			this.FieldSqlPassword.Enabled = false;
			this.FieldSqlPassword.Location = new System.Drawing.Point(12, 387);
			this.FieldSqlPassword.Name = "FieldSqlPassword";
			this.FieldSqlPassword.Size = new System.Drawing.Size(319, 20);
			this.FieldSqlPassword.TabIndex = 12;
			this.FieldSqlPassword.UseSystemPasswordChar = true;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.RdBtnWinAuth);
			this.panel3.Controls.Add(this.RdBtnSQLAuth);
			this.panel3.Location = new System.Drawing.Point(11, 101);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(246, 62);
			this.panel3.TabIndex = 2;
			// 
			// LblTitle
			// 
			this.LblTitle.AutoSize = true;
			this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTitle.ForeColor = System.Drawing.Color.White;
			this.LblTitle.Location = new System.Drawing.Point(7, 9);
			this.LblTitle.Name = "LblTitle";
			this.LblTitle.Size = new System.Drawing.Size(265, 24);
			this.LblTitle.TabIndex = 14;
			this.LblTitle.Text = "Travel Experts First Run Setup";
			// 
			// LblInfo
			// 
			this.LblInfo.AutoSize = true;
			this.LblInfo.ForeColor = System.Drawing.Color.White;
			this.LblInfo.Location = new System.Drawing.Point(8, 33);
			this.LblInfo.Name = "LblInfo";
			this.LblInfo.Size = new System.Drawing.Size(229, 52);
			this.LblInfo.TabIndex = 15;
			this.LblInfo.Text = "Thank you for choosing Travel Experts!\r\nYou are seeing this because this is the f" +
    "irst run.\r\nPlease configure your database below.\r\nPress Connect when you are rea" +
    "dy to proceed.";
			// 
			// ConnectionSetup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(343, 559);
			this.Controls.Add(this.LblInfo);
			this.Controls.Add(this.LblTitle);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.FieldSqlPassword);
			this.Controls.Add(this.LblSqlPassword);
			this.Controls.Add(this.LblSqlUsername);
			this.Controls.Add(this.FieldSqlUsername);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.FieldServerInstance);
			this.Controls.Add(this.LblAddress);
			this.Controls.Add(this.FieldServerAddress);
			this.Controls.Add(this.ChUseInstanceName);
			this.Controls.Add(this.BtnConnect);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "ConnectionSetup";
			this.Text = "Configure Connection";
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton RdBtnWinAuth;
		private System.Windows.Forms.RadioButton RdBtnSQLAuth;
		private System.Windows.Forms.Button BtnConnect;
		private System.Windows.Forms.CheckBox ChUseInstanceName;
		private System.Windows.Forms.TextBox FieldServerAddress;
		private System.Windows.Forms.Label LblAddress;
		private System.Windows.Forms.TextBox FieldServerInstance;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox FieldSqlUsername;
		private System.Windows.Forms.Label LblSqlUsername;
		private System.Windows.Forms.Label LblSqlPassword;
		private System.Windows.Forms.TextBox FieldSqlPassword;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label LblTitle;
		private System.Windows.Forms.Label LblInfo;
	}
}

