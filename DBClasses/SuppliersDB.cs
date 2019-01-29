using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadedProject2;

/**
 * Project: OOSD Threaded Project 2
 * 
* SuppliersDB class binds the data retrieved from the database to a KeyValue pair List
* and allows for display by binding data to list.
* 
* Author: Hayden Belanger
* Date: Jan 2019
* Commenter: Eugenia Chiu and Hayden Belanger
*/

namespace DBClasses {
	public class SuppliersDB {

		/// <summary>
		/// This is the actual list of all suppliers. Add, change, or remove items from this to have it update
		/// in all connected Data end points.
		/// </summary>
		public static BindingList<KeyValuePair<string, int>> Suppliers = new BindingList<KeyValuePair<string, int>>();
		/// <summary>
		/// This is the Binding Source. To add or remove data from the list, reference Suppliers BindingList instead.
		/// Reference this as the DataSource in GUI elements like ComboBox to auto-construct the dropdown and modify
		/// it on the fly.
		/// </summary>
		public static BindingSource SuppliersBindingSource = new BindingSource();

		/// <summary>
		/// Repeatable use static method that will either populate or reset the Suppliers list.
		/// </summary>
		public static void InitializeList() {

            //Establish and open the connection to database using connection string
            using (SqlConnection con = new SqlConnection(ConnectionString.Connection.Value())) {
				con.Open();

                //Once connection is open, run SQL query command. In this case, select all data from Products Table
                //cmd is passed the query and connection string
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Suppliers;", con)) {
					using (SqlDataReader sdr = cmd.ExecuteReader()) {

                        //While the data table still has data, continue reading
                        while (sdr.Read()) {

                            //Add the data (KeyValue Pairs) to the empty list
                            Suppliers.Add(new KeyValuePair<string, int>(sdr.GetString(1), sdr.GetInt32(0)));
						}
					}
				}
			}

            //Make the filled list the SuppliersBindingSource (for later use)
            SuppliersBindingSource.DataSource = Suppliers;
		}
	}
}
