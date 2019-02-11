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
* CoAuthor: Eugenia Chiu
* Date: Jan 2019
* Commenter: Eugenia Chiu and Hayden Belanger
*/

namespace DBClasses
{
    public class SuppliersDB
    {

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
        public static void InitializeList()
        {

            //Establish and open the connection to database using connection string
            using (SqlConnection con = new SqlConnection(ConnectionString.Connection.Value()))
            {
                con.Open();

                //Once connection is open, run SQL query command. In this case, select all data from Products Table
                //cmd is passed the query and connection string
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Suppliers;", con))
                {
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {

                        //While the data table still has data, continue reading
                        while (sdr.Read())
                        {

                            //Add the data (KeyValue Pairs) to the empty list
                            Suppliers.Add(new KeyValuePair<string, int>(sdr.GetString(1), sdr.GetInt32(0)));
                        }
                    }
                }
            }

            //Make the filled list the SuppliersBindingSource (for later use)
            SuppliersBindingSource.DataSource = Suppliers;
        }


        //add new suppliers method
        public static int AddNewSupplier(string supplierName)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.Connection.Value()))
            {
                con.Open();

                int id = (int)new SqlCommand("SELECT MAX(SupplierId)+1 FROM Suppliers;", con).ExecuteScalar();
                id++;

                //add new supplier with new supplier name and id from list+1
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Suppliers (SupplierId, SupName) VALUES (@sid, @name);", con))
                {
                    cmd.Parameters.AddWithValue("@sid", id);
                    cmd.Parameters.AddWithValue("@name", supplierName);
                    cmd.ExecuteNonQuery();
                }
                return id;
            }

        }

        //Select supplier
        public static bool[] GetSelectedValue(int supplierID)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.Connection.Value()))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Products_Suppliers WHERE SupplierId = @sid;", con))
                {
                    cmd.Parameters.AddWithValue("@sid", supplierID);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    bool[] vals = new bool[11];
                    while (sdr.Read())
                    {
                        vals[sdr.GetInt32(1)] = true;

                    }

                    return vals;


                }
            }
        }

        //edit supplier and supplier products
        public static void EditValue(int productID, int supplierID, bool create)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.Connection.Value()))
            {
                con.Open();

                if (create == true)
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Products_Suppliers(ProductId, SupplierId) VALUES (@pid, @sid);", con))
                    {
                        cmd.Parameters.AddWithValue("@pid", productID);
                        cmd.Parameters.AddWithValue("@sid", supplierID);
                        cmd.ExecuteNonQuery();

                    }
                }
                else
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Products_Suppliers WHERE ProductId = @pid AND SupplierId = @sid;", con))
                    {
                        cmd.Parameters.AddWithValue("@pid", productID);
                        cmd.Parameters.AddWithValue("@sid", supplierID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        //delete supplier method. This method calls on the SupDelStatements.cs file
        public static bool DeleteSupplier(int id)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString.Connection.Value()))
            {

                con.Open();
                DialogResult dr = MessageBox.Show("WARNING:\n" +
                    "Deleting a supplier will delete associated booking details and supplier contacts." +
     " It will also remove this supplier from ALL packages it is associated with.\nContinue?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {

                    //This queries are found in DBClasses.SupDelStatements as they are VERY long queries.
                    //Clear - Packages_Products_Suppliers
                    SqlCommand cmdPPS = new SqlCommand(SupDelStatements.PSS_Query, con);
                    cmdPPS.Parameters.AddWithValue("@sid", id);
                    cmdPPS.ExecuteNonQuery();

                    //Clear - BookingDetails
                    SqlCommand cmdBD = new SqlCommand(SupDelStatements.BD_Query, con);
                    cmdBD.Parameters.AddWithValue("@sid", id);
                    cmdBD.ExecuteNonQuery();

                    //Clear - Products_Suppliers
                    SqlCommand cmdPS = new SqlCommand(SupDelStatements.PS_Query, con);
                    cmdPS.Parameters.AddWithValue("@sid", id);
                    cmdPS.ExecuteNonQuery();

                    //Clear - SupplierContacts
                    SqlCommand cmdSC = new SqlCommand(SupDelStatements.SC_Query, con);
                    cmdSC.Parameters.AddWithValue("@sid", id);
                    cmdSC.ExecuteNonQuery();

                    //Clear - Suppliers
                    SqlCommand cmdS = new SqlCommand(SupDelStatements.S_Query, con);
                    cmdS.Parameters.AddWithValue("@sid", id);
                    cmdS.ExecuteNonQuery();

                    MessageBox.Show("Deleted supplier.", "Success");
                    return true;

                }
                else
                {
                    return false;
                }
            }
        }
    }
}
