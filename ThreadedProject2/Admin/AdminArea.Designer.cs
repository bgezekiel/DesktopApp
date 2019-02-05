namespace ThreadedProject2.Admin {
	partial class AdminArea {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminArea));
			this.BtnCreatePassword = new System.Windows.Forms.Button();
			this.LblTitle = new System.Windows.Forms.Label();
			this.FieldPassword = new System.Windows.Forms.TextBox();
			this.LblPassword = new System.Windows.Forms.Label();
			this.LblDesc1 = new System.Windows.Forms.Label();
			this.ChForce = new System.Windows.Forms.CheckBox();
			this.LblDesc2 = new System.Windows.Forms.Label();
			this.LblDesc3 = new System.Windows.Forms.Label();
			this.CBAgents = new System.Windows.Forms.ComboBox();
			this.LblBoundAgent = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// BtnCreatePassword
			// 
			this.BtnCreatePassword.Enabled = false;
			this.BtnCreatePassword.Location = new System.Drawing.Point(12, 399);
			this.BtnCreatePassword.Name = "BtnCreatePassword";
			this.BtnCreatePassword.Size = new System.Drawing.Size(328, 23);
			this.BtnCreatePassword.TabIndex = 0;
			this.BtnCreatePassword.Text = "Set Password";
			this.BtnCreatePassword.UseVisualStyleBackColor = true;
			this.BtnCreatePassword.Click += new System.EventHandler(this.CreateAccount);
			// 
			// LblTitle
			// 
			this.LblTitle.AutoSize = true;
			this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTitle.Location = new System.Drawing.Point(13, 13);
			this.LblTitle.Name = "LblTitle";
			this.LblTitle.Size = new System.Drawing.Size(295, 33);
			this.LblTitle.TabIndex = 1;
			this.LblTitle.Text = "Set Agent Password";
			// 
			// FieldPassword
			// 
			this.FieldPassword.Location = new System.Drawing.Point(12, 293);
			this.FieldPassword.Name = "FieldPassword";
			this.FieldPassword.Size = new System.Drawing.Size(328, 20);
			this.FieldPassword.TabIndex = 2;
			this.FieldPassword.UseSystemPasswordChar = true;
			this.FieldPassword.TextChanged += new System.EventHandler(this.ChangePswd);
			// 
			// LblPassword
			// 
			this.LblPassword.AutoSize = true;
			this.LblPassword.Location = new System.Drawing.Point(9, 277);
			this.LblPassword.Name = "LblPassword";
			this.LblPassword.Size = new System.Drawing.Size(53, 13);
			this.LblPassword.TabIndex = 3;
			this.LblPassword.Text = "Password";
			// 
			// LblDesc1
			// 
			this.LblDesc1.AutoSize = true;
			this.LblDesc1.Location = new System.Drawing.Point(12, 67);
			this.LblDesc1.Name = "LblDesc1";
			this.LblDesc1.Size = new System.Drawing.Size(190, 13);
			this.LblDesc1.TabIndex = 5;
			this.LblDesc1.Text = "Use this tool to set an agent password.";
			// 
			// ChForce
			// 
			this.ChForce.AutoSize = true;
			this.ChForce.Location = new System.Drawing.Point(12, 376);
			this.ChForce.Name = "ChForce";
			this.ChForce.Size = new System.Drawing.Size(208, 17);
			this.ChForce.TabIndex = 8;
			this.ChForce.Text = "Force Password Change on First Login";
			this.ChForce.UseVisualStyleBackColor = true;
			// 
			// LblDesc2
			// 
			this.LblDesc2.AutoSize = true;
			this.LblDesc2.ForeColor = System.Drawing.Color.Red;
			this.LblDesc2.Location = new System.Drawing.Point(12, 84);
			this.LblDesc2.Name = "LblDesc2";
			this.LblDesc2.Size = new System.Drawing.Size(136, 13);
			this.LblDesc2.TabIndex = 9;
			this.LblDesc2.Text = "Actions here will be logged!";
			// 
			// LblDesc3
			// 
			this.LblDesc3.AutoSize = true;
			this.LblDesc3.ForeColor = System.Drawing.Color.Blue;
			this.LblDesc3.Location = new System.Drawing.Point(12, 101);
			this.LblDesc3.Name = "LblDesc3";
			this.LblDesc3.Size = new System.Drawing.Size(32, 13);
			this.LblDesc3.TabIndex = 10;
			this.LblDesc3.Text = "User:";
			// 
			// CBAgents
			// 
			this.CBAgents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CBAgents.FormattingEnabled = true;
			this.CBAgents.Location = new System.Drawing.Point(12, 162);
			this.CBAgents.Name = "CBAgents";
			this.CBAgents.Size = new System.Drawing.Size(328, 21);
			this.CBAgents.TabIndex = 11;
			// 
			// LblBoundAgent
			// 
			this.LblBoundAgent.AutoSize = true;
			this.LblBoundAgent.Location = new System.Drawing.Point(12, 143);
			this.LblBoundAgent.Name = "LblBoundAgent";
			this.LblBoundAgent.Size = new System.Drawing.Size(69, 13);
			this.LblBoundAgent.TabIndex = 12;
			this.LblBoundAgent.Text = "Bound Agent";
			// 
			// AdminArea
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(352, 443);
			this.Controls.Add(this.LblBoundAgent);
			this.Controls.Add(this.CBAgents);
			this.Controls.Add(this.LblDesc3);
			this.Controls.Add(this.LblDesc2);
			this.Controls.Add(this.ChForce);
			this.Controls.Add(this.LblDesc1);
			this.Controls.Add(this.LblPassword);
			this.Controls.Add(this.FieldPassword);
			this.Controls.Add(this.LblTitle);
			this.Controls.Add(this.BtnCreatePassword);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "AdminArea";
			this.Text = "Set Agent Password";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnCreatePassword;
		private System.Windows.Forms.Label LblTitle;
		private System.Windows.Forms.TextBox FieldPassword;
		private System.Windows.Forms.Label LblPassword;
		private System.Windows.Forms.Label LblDesc1;
		private System.Windows.Forms.CheckBox ChForce;
		private System.Windows.Forms.Label LblDesc2;
		private System.Windows.Forms.Label LblDesc3;
		private System.Windows.Forms.ComboBox CBAgents;
		private System.Windows.Forms.Label LblBoundAgent;
	}
}