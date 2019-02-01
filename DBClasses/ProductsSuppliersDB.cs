using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBClasses
{
    public class ProductsSuppliersDB
    {
        //Establish connection string
        public static string connectionString = ConnectionString.Connection.Value();

        //public static int AddProdSup(ProductsSuppliers prosup)
        public static int AddProdSup(int prodID, int supID)
        {
            // create local bool variable
            int value = 0;

            // establish connection
            SqlConnection con = new SqlConnection(ConnectionString.Connection.Value());

            // SQL add string to insert new data into the Products_Suppliers table
            string addString = "INSERT INTO Products_Suppliers(ProductId, SupplierID) VALUES(@ProductId, @SupplierId)";

            SqlCommand addCommand = new SqlCommand(addString, con);

            addCommand.Parameters.AddWithValue("@ProductId", prodID); // add  prod Id
            addCommand.Parameters.AddWithValue("@SupplierId", supID); // add sup id

            try
            {
                con.Open(); // open connection to database
                value = addCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return value; // return result to local variable
        }

        static public bool DeleteProductSupplier(ProductsSuppliers prodsup)
        {
            bool successful = false;

            SqlConnection con = new SqlConnection(ConnectionString.Connection.Value());





            string deleteString = "delete from products_suppliers " +
                                   "where " +
                                   "ProductId = @ProductId " +
                                   "and SupplierId = @SupplierId "; 

            SqlCommand deleteCommand = new SqlCommand(deleteString, con);
            deleteCommand.Parameters.AddWithValue("@ProductId", prodsup.ProductId);
            deleteCommand.Parameters.AddWithValue("@SupplierId", prodsup.SupplierId);


            try
            {
                con.Open();
                successful = Convert.ToBoolean(deleteCommand.ExecuteNonQuery());

            }
            catch (Exception)
            {
                MessageBox.Show("Delete Error");
            }
            finally
            {
                con.Close();
            }
            return successful;


        }
    }
}
    
    