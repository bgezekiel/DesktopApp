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

/**
 * Project: OOSD Threaded Project 2
 * 
 * Add new Supplier page
* 
* Author:Eugenia Chiu
* Date: Jan 2019
* Commenter: Eugenia Chiu
*/

namespace ThreadedProject2
{
    public partial class NewSupplier : Form
    {
        public NewSupplier()
        {
            InitializeComponent();

			btnOK.Enabled = false;
			btnOK.BackColor = CreateNewPackage.ColorDisabled;
		}

        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = txtSupName.Text.ToString();
            int i = SuppliersDB.AddNewSupplier(name.ToUpper());

            KeyValuePair<string, int> val = new KeyValuePair<string, int>(name.ToUpper(), i);
            SuppliersDB.Suppliers.Add(val);

            MessageBox.Show("Created new supplier.", "Success");
            this.Close();
        }

		private void ChangeText(object sender, EventArgs e) {
			if (txtSupName.Text.Length == 0) {
				btnOK.Enabled = false;
				btnOK.BackColor = CreateNewPackage.ColorDisabled;
			} else {
				btnOK.Enabled = true;
				btnOK.BackColor = CreateNewPackage.ColorEnabled;
			}
		}
	}
}
