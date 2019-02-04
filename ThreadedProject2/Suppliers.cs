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


/**
 * Project: OOSD Threaded Project 2
 * 
 * Suppliers class. Used for the Create/Edit/Delete suppliers page. 
* 
* Author: Hayden Belanger + Eugenia Chiu
* Date: Jan 2019
* Commenter: Eugenia Chiu and Hayden Belanger
*/

namespace ThreadedProject2
{
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();

            //LBSuppliers is the list box in the application design page.
            //Set ValueMember of the list box as "Value".
            //Set the DisplayMember (what is shown in the listbox) as the "Key".
            //Bind the list box datasoure to SuppliersDB.SuppliersBindingSource. This is to allow for data in dropdown menu or listbox
            LBSuppliers.ValueMember = "Value";
            LBSuppliers.DisplayMember = "Key";
            LBSuppliers.DataSource = SuppliersDB.SuppliersBindingSource;

            LBProducts.ValueMember = "Value";
            LBProducts.DisplayMember = "Key";
            LBProducts.DataSource = ProductsDB.ProductsBindingSource;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCreateSupplier_Click(object sender, EventArgs e)
        {
            new NewSupplier().ShowDialog(this);
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            new NewProduct().ShowDialog(this);
        }

        private void btnSupDelete_Click(object sender, EventArgs e)
        {
            bool res = SuppliersDB.DeleteSupplier((int)LBSuppliers.SelectedValue);

            KeyValuePair<string, int> v = (KeyValuePair<string, int>)LBSuppliers.SelectedItem;
            SuppliersDB.Suppliers.Remove(v);
        }

        private void btnProdDelete_Click(object sender, EventArgs e)
        {
            string res = ProductsDB.DeleteProduct((int)LBProducts.SelectedValue);

            if(res != null)
            {
                if(res == "SUCCESS")
                {

                    KeyValuePair<string, int> vv = new KeyValuePair<string, int>("", -99);
                    foreach(KeyValuePair<string, int> v in ProductsDB.Products)
                    {
                        if(v.Value == (int) LBProducts.SelectedValue)
                        {
                            vv = v;
                        }
                    }

                    if(vv.Value != -99)
                    {
                        ProductsDB.Products.Remove(vv);
                    }
                    MessageBox.Show("Delete successful.", "Success");
                }
                else
                {
                    MessageBox.Show("Did not delete: " + res, "Error");
                }
                
            }
        }
    }
}
