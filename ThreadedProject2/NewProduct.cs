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
* GUI page to add new Product
* 
* Author: Eugenia Chiu
* CoAuthor: Hayden Belanger
* Date: Jan 2019
* Commenter: Eugenia Chiu and Hayden Belanger
*/

namespace ThreadedProject2
{
    public partial class NewProduct : Form
    {
        //Disable and grey out the OK button at start.
        //Will not allow users to enter in null values
        public NewProduct()
        {
            InitializeComponent();

			btnOK.Enabled = false;
			btnOK.BackColor = CreateNewPackage.ColorDisabled;
        }

        //Method for OK button to add new product to list and database
        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = txtProdName.Text.ToString(); //get text from textbox
            int i = ProductsDB.AddNewProduct(name.ToUpper()); //change input to uppercase

            KeyValuePair<string, int> val = new KeyValuePair<string, int>(name, i); //create key value pair for databse
            ProductsDB.Products.Add(val); //add new value pair to database

            MessageBox.Show("Created new product.", "Success");//popup confirmation
            this.Close();
        }

		private void ChangeText(object sender, EventArgs e) {
			if(txtProdName.Text.Length == 0) {
				btnOK.Enabled = false;
				btnOK.BackColor = CreateNewPackage.ColorDisabled; //If null in text, disable OK button and change color
			} else {
				btnOK.Enabled = true;
				btnOK.BackColor = CreateNewPackage.ColorEnabled; //enable OK button and change color
			}
		}
	}
}
