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
* Author: Hayden Belanger
* CoAuthor: Eugenia Chiu + Brandon Ezekiel
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

        public static string DeleteProduct(int id)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.Connection.Value()))
            {
                try
                {
                    con.Open();
                    DialogResult dr = MessageBox.Show("WARNING:\n" +
                        "Are you sure you want to delete this product from the products list? ." +
                        "\nContinue?", "Confirm Delete", MessageBoxButtons.YesNo);

                    if (dr == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE ProductId = @pid;", con);
                        cmd.Parameters.AddWithValue("@pid", id);
                        cmd.ExecuteNonQuery();

                        return "SUCCESS";
                    }
                    else
                    {
                        return null;
                    }
                }catch(SqlException e)
                {
                    return e.Message;
                }
                

            }
        }

        // method to display products in list boxes (used on manage page)
        public static List<Products> GetProdNotInList(int supID)
        {
            List<Products> prodd = new List<Products>();
            SqlConnection con = new SqlConnection(ConnectionString.Connection.Value());
            string sql = "SELECT p.ProductId, p.ProdName " +
                         "FROM Products p " +
                         "WHERE p.ProductId NOT IN " +
                         "(SELECT p.ProductId from Products " +
                         "INNER JOIN Products_Suppliers ps " +
                         "ON p.ProductId = ps.ProductId " +
                         "INNER JOIN Suppliers s " +
                         "ON s.SupplierId = ps.SupplierId " +
                         "WHERE s.SupplierId = @SupplierId)";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@SupplierId", supID);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Products proddd = new Products();
                    proddd.ProductId = Convert.ToInt32(reader["ProductId"]);
                    proddd.ProdName = Convert.ToString(reader["ProdName"]);
                    prodd.Add(proddd);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return prodd;
        }

        // method to create list of package names to be used in the combobox
        public static List<Products> GetProducts(int supID)
        {
            List<Products> list = new List<Products>();
            Products prod = null;

            SqlConnection con = new SqlConnection(ConnectionString.Connection.Value()); // connection to database

            string selectString = "select ps.ProductId, ProdName from Products p " +
                                    "join Products_Suppliers ps on p.ProductId = ps.ProductId " +
                                    "where ps.SupplierId = @SupplierId " + // sql statement to get information from database
                                    "order by ProdName";
            SqlCommand selectCommand = new SqlCommand(selectString, con);
            selectCommand.Parameters.AddWithValue("@SupplierId", supID);
            try
            {
                con.Open(); // open connection
                SqlDataReader reader = selectCommand.ExecuteReader(); // start reading data
                while (reader.Read())
                {
                    prod = new Products();
                    prod.ProdName = reader["ProdName"].ToString();
                    prod.ProductId = Convert.ToInt32(reader["ProductId"]);
                    list.Add(prod);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close(); // close connection to database
            }
            return list; // returns row of data as prod
        }
    }
}
