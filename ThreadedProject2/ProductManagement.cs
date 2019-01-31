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

            //Display Key and Values in appropriate places on GUI
            comboBoxSupplier.ValueMember = "Value";
            comboBoxSupplier.DisplayMember = "Key";
            lstProducts.ValueMember = "Value";
            lstProducts.DisplayMember = "Key";
            listProducts.ValueMember = "Value";
            listProducts.DisplayMember = "Key";

            //Bind the datasource for the combo box to the list generated in SuppliersDB
            comboBoxSupplier.DataSource = SuppliersDB.SuppliersBindingSource;

            //Filter the information based on the selectValChanged
            FilterSource.DataSource = FilteredList;
            listProducts.DataSource = FilterSource;

            SelectedSource.DataSource = SelectedList;
            lstProducts.DataSource = SelectedSource;
        }

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
                                        "SP.SupplierId = PS.SupplierId WHERE PS.ProductId = @supp;";

                    //using the connection and the string command,
                    using (SqlCommand cmd = new SqlCommand(sqlCommand, con))
                    {

                        //Ask Hayden about this part
                        cmd.Parameters.AddWithValue("@supp", comboBoxSupplier.SelectedValue);

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
    }
}
