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

namespace ThreadedProject2
{
    public partial class NewProduct : Form
    {
        public NewProduct()
        {
            InitializeComponent();

			btnOK.Enabled = false;
			btnOK.BackColor = CreateNewPackage.ColorDisabled;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = txtProdName.Text.ToString();
            int i = ProductsDB.AddNewProduct(name.ToUpper());

            KeyValuePair<string, int> val = new KeyValuePair<string, int>(name, i);
            ProductsDB.Products.Add(val);

            MessageBox.Show("Created new product.", "Success");
            this.Close();
        }

		private void ChangeText(object sender, EventArgs e) {
			if(txtProdName.Text.Length == 0) {
				btnOK.Enabled = false;
				btnOK.BackColor = CreateNewPackage.ColorDisabled;
			} else {
				btnOK.Enabled = true;
				btnOK.BackColor = CreateNewPackage.ColorEnabled;
			}
		}
	}
}
