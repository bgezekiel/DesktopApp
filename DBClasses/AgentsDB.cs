using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBClasses {
	public class AgentsDB {

		public static BindingList<KeyValuePair<string, int>> Agents = new BindingList<KeyValuePair<string, int>>();
		public static BindingSource AgentsBindingSource = new BindingSource();


		public static void InitializeList() {

			//Establish and open the connection to database using connection string

			Agents.Clear();
			using (SqlConnection con = new SqlConnection(ConnectionString.Connection.Value())) {
				con.Open();

				//Once connection is open, run SQL query command. In this case, select all data from Products Table
				//cmd is passed the query and connection string
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM Agents ORDER BY AgtFirstName ASC;", con)) {
					using (SqlDataReader sdr = cmd.ExecuteReader()) {
						//While the data table still has data, continue reading
						while (sdr.Read()) {

							//Add the data (KeyValue Pairs) to the empty list
							Agents.Add(new KeyValuePair<string, int>(sdr.GetString(1), sdr.GetInt32(0)));
						}


					}
				}
			}

			//Make the filled list the ProductsBindingSource (for later use)
			AgentsBindingSource.DataSource = Agents;
		}
	}
}
