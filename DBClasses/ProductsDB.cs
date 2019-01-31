using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Project: OOSD Threaded Project 2
 * 
* ProductsDB class binds the data retrieved from the database to a KeyValue pair List
* and allows for display by binding data to list.
* 
* Author: Hayden Belanger + Eugenia Chiu
* Date: Jan 2019
* Commenter: Eugenia Chiu and Hayden Belanger
*/

namespace DBClasses {

    //public class Products DB
	public class ProductsDB {

        /// <summary>
		/// This is the actual list of all products. Add, change, or remove items from this to have it update
		/// in all connected Data end points.
		/// </summary>
		public static BindingList<KeyValuePair<string, int>> Products = new BindingList<KeyValuePair<string, int>>();
		/// <summary>
		/// This is the Binding Source. To add or remove data from the list, reference Products BindingList instead.
		/// Reference this as the DataSource in GUI elements like ComboBox to auto-construct the dropdown and modify
		/// it on the fly.
		/// </summary>
		public static BindingSource ProductsBindingSource = new BindingSource();

        /// <summary>
		/// Repeatable use static method that will either populate or reset the Products list.
		/// </summary>
		public static void InitializeList() {

			//Establish and open the connection to database using connection string

			Products.Clear();
			using (SqlConnection con = new SqlConnection(ConnectionString.Connection.Value())) {
				con.Open();

                //Once connection is open, run SQL query command. In this case, select all data from Products Table
                //cmd is passed the query and connection string
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM Products;", con)) {
					using (SqlDataReader sdr = cmd.ExecuteReader()) { 
                        //While the data table still has data, continue reading
						while (sdr.Read()) {

                            //Add the data (KeyValue Pairs) to the empty list
							Products.Add(new KeyValuePair<string, int>(sdr.GetString(1), sdr.GetInt32(0)));
						}


					}
				}
			}

            //Make the filled list the ProductsBindingSource (for later use)
			ProductsBindingSource.DataSource = Products;
		}

        //Method for adding new product 
        public static int AddNewProduct(string productName)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.Connection.Value()))
            {
                con.Open();

                int id = (int)new SqlCommand("SELECT CAST(IDENT_CURRENT('Products')+1 AS INT);", con).ExecuteScalar();

                using (SqlCommand cmd = new SqlCommand("INSERT INTO Products (ProdName) VALUES (@name);", con))
                {
                    cmd.Parameters.AddWithValue("@name", productName);
 
                    cmd.ExecuteNonQuery();
                }
                return id;
            }

        }
    }
}
