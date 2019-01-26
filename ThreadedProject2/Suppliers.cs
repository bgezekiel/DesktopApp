using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBClasses;
using Microsoft.VisualBasic;

namespace ThreadedProject2 {
	public partial class Suppliers : Form {
		public Suppliers() {
			InitializeComponent();


			LBSuppliers.ValueMember = "Value";
			LBSuppliers.DisplayMember = "Key";
			LBSuppliers.DataSource = SuppliersDB.SuppliersBindingSource;
		}

		private void CreateNewSupplier(object sender, EventArgs e) {
			string name = Interaction.InputBox("Type in the name of the new supplier and hit OK.", "Create New Supplier", "");

		}

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
