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
* GUI page to add new Supplier
* 
* Author: Eugenia Chiu + Hayden Belanger
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

        //method for OK button and to add to database
        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = txtSupName.Text.ToString(); //take input
            int i = SuppliersDB.AddNewSupplier(name.ToUpper()); //make input all uppercase

            KeyValuePair<string, int> val = new KeyValuePair<string, int>(name.ToUpper(), i); //create key value pairs
            SuppliersDB.Suppliers.Add(val); //add value to database

            MessageBox.Show("Created new supplier.", "Success"); //popup for success message
            this.Close();
        }

		private void ChangeText(object sender, EventArgs e) {
			if (txtSupName.Text.Length == 0) { //disable OK button if value in textbox is null
				btnOK.Enabled = false;
				btnOK.BackColor = CreateNewPackage.ColorDisabled;
			} else {
				btnOK.Enabled = true;
				btnOK.BackColor = CreateNewPackage.ColorEnabled; //enable OK button and change color if textbox has value
			}
		}
	}
}
