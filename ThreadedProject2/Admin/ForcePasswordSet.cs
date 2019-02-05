using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadedProject2.Admin {
	public partial class ForcePasswordSet : Form {

		public string ChangedPassword { get; set; }
	
		public ForcePasswordSet() {
			InitializeComponent();
		}

		private void Cancel(object sender, EventArgs e) {

			DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void Change(object sender, EventArgs e) {

			
			if(FieldConf.Text != FieldPass.Text) {
				MessageBox.Show("These passwords did not match.", "Error");
				return;
			}

			ChangedPassword = FieldConf.Text;

			DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
