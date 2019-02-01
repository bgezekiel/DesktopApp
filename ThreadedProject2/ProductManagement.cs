using DBClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/**
 * Project: OOSD Threaded Project 2
* Manage Products/Suppliers GUI code to manage suppliers and products
* Author: Brandon Ezekiel
* Date: Jan 2019
* Commenter: Brandon Ezekiel
*/

namespace ThreadedProject2
{
    public partial class ProductManagement : Form
    {
        // NEW
        List<Products> list = new List<Products>();
        List<Products> notInList = new List<Products>();

        //Create new empty BindingList and BindingSource
        BindingList<KeyValuePair<string, int>> FilteredList = new BindingList<KeyValuePair<string, int>>();
        BindingSource FilterSource = new BindingSource();

        BindingList<KeyValuePair<string, int>> SelectedList = new BindingList<KeyValuePair<string, int>>();
        BindingSource SelectedSource = new BindingSource();

        private static readonly KeyValuePair<string, int> DummyVal = new KeyValuePair<string, int>("ERR", -999);

        private static readonly Color ColorEnabled = Color.FromArgb(82, 117, 167);
        private static readonly Color ColorDisabled = Color.Gray;

        public ProductManagement()
        {
            InitializeComponent();
            loadList();


            //Display Key and Values in appropriate places on GUI
            comboBoxSupplier.ValueMember = "Value";
            comboBoxSupplier.DisplayMember = "Key";


            //Bind the datasource for the combo box to the list generated in SuppliersDB
            comboBoxSupplier.DataSource = SuppliersDB.SuppliersBindingSource;

            //Filter the information based on the selectValChanged
            FilterSource.DataSource = FilteredList;


            SelectedSource.DataSource = SelectedList;

        }

        private ProductsSuppliers prodsupp; // create object Package
        private int selectedProductId;
        private int selectedSupplierID;


        private void SelectValChanged(object sender, EventArgs e)
        {

            //If the comboBox is not null
            if (comboBoxSupplier.SelectedValue != null)
            {

                //Establish connection to database and clear the filtered list
                using (SqlConnection con = new SqlConnection(ConnectionString.Connection.Value()))
                {
                    FilteredList.Clear();
                    con.Open();

                    //sql Command
                    string sqlCommand = "SELECT * FROM Products PD FULL OUTER JOIN Products_Suppliers PS ON " +
                                        "PS.ProductId = PD.ProductId FULL OUTER JOIN Suppliers SP ON " +
                                        "SP.SupplierId = PS.SupplierId WHERE PS.ProductId = @prod;";

                    //using the connection and the string command,
                    using (SqlCommand cmd = new SqlCommand(sqlCommand, con))
                    {

                        //Ask Hayden about this part
                        cmd.Parameters.AddWithValue("@prod", comboBoxSupplier.SelectedValue);

                        //using the data reader, read the data while there is still data in table
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            while (sdr.Read())
                            {

                                FilteredList.Add(new KeyValuePair<string, int>(sdr.GetString(6), sdr.GetInt32(4)));

                            }
                        }
                    }
                }

                foreach (KeyValuePair<string, int> kva in SelectedList)
                {

                    bool found = false;
                    KeyValuePair<string, int> kvX = DummyVal;
                    foreach (KeyValuePair<string, int> kvb in FilteredList)
                    {
                        if (kva.Value == kvb.Value)
                        {
                            found = true;
                            kvX = kvb;
                            break;
                        }
                    }

                    if (found)
                    {
                        FilteredList.Remove(kvX);
                    }
                }


            }

        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void comboBoxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Grab supplier id from the combo box 
            loadList();

        }

        private void btnCreatePackage_Click(object sender, EventArgs e)
        {

            ProductsSuppliersDB.AddProdSup(selectedProductId, selectedSupplierID);
            loadList();


        }

        private void listProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listProducts.DataSource != null)
            {
                selectedProductId = listProducts.SelectedIndex;
            }

        }

        private void loadList()
        {
            if (comboBoxSupplier.SelectedValue != null)
            {

                int supID = Convert.ToInt32(comboBoxSupplier.SelectedValue);
                selectedSupplierID = supID;
                try
                {
                    // run the slq query method (included in ProductSupplier table)
                    list = ProductsDB.GetProducts(supID);

                    // run the toher sql query method (the not in)
                    notInList = ProductsDB.GetProdNotInList(supID);

                    // Display info
                    lstProducts.DataSource = list;
                    lstProducts.DisplayMember = "ProdName";
                    lstProducts.ValueMember = "ProductId";

                    listProducts.DataSource = notInList;
                    listProducts.DisplayMember = "ProdName";
                    listProducts.ValueMember = "ProductId";
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete product from supplier?", "Delete", MessageBoxButtons.YesNo);

            bool deleted = false;
            ProductsSuppliers obj = new ProductsSuppliers();
            obj.ProductId = Convert.ToInt32(lstProducts.SelectedValue);
            obj.SupplierId = Convert.ToInt32(comboBoxSupplier.SelectedValue);

            deleted = ProductsSuppliersDB.DeleteProductSupplier(obj);

            if (deleted)
            {
                MessageBox.Show("Delete Successful");
                loadList();
                comboBoxSupplier.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Delete Failed.");
            }
        }

    }
}


