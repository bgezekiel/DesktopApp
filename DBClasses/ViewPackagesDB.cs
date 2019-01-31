using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

/**
 * Project: OOSD Threaded Project 2
 * 
* ViewPackages Form with navigation buttons. This page is for displaying package information for
* easier read and access
* 
* Author: Brandon Ezekiel / Eugenia Chiu
* Date: Jan 2019
* Commenter: Brandon Ezekiel / Eugenia Chiu
*/

namespace DBClasses
{
    public static class ViewPackagesDB
    {
        // method to retrieve package information for the database
        public static Package GetPackage(string packageName)
        {
            Package pack = null; // set object as null
            SqlConnection con = new SqlConnection(ConnectionString.Connection.Value()); // Connection to database
            string selectStatement = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                                     "FROM Packages " + "WHERE PkgName = @PkgName";
            SqlCommand cmd = new SqlCommand(selectStatement, con);
            cmd.Parameters.AddWithValue("@PkgName", packageName);

            try
            {
                con.Open(); // open connection
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow); // read single row of data
                if (reader.Read())
                {
                    pack = new Package();
                    pack.PackageId = Convert.ToInt32(reader["PackageId"]);
                    pack.PkgName = reader["PkgName"].ToString();
                    pack.PkgStartDate = Convert.ToDateTime(reader["PkgStartDate"]);
                    pack.PkgEndDate = Convert.ToDateTime(reader["PkgEndDate"]);
                    pack.PkgDesc = reader["PkgDesc"].ToString();
                    pack.PkgBasePrice = Convert.ToInt32(reader["PkgBasePrice"]);
                    pack.PkgAgencyCommission = Convert.ToInt32(reader["PkgAgencyCommission"]);

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
            return pack; // return row of data as pack object

        }

        // method to create list of package names to be used in the combobox
        public static List<string> GetPackagesName()
        {
            
            List<string> pack = new List<string>(); // new list object - empty

            SqlConnection con = new SqlConnection(ConnectionString.Connection.Value()); // connection to database

            string selectString = "select PackageId, PkgName from Packages " + // sql statement to get information from database
                                  "order by PkgName";
            SqlCommand selectCommand = new SqlCommand(selectString, con); 

            try
            {
                con.Open(); // open connection
                SqlDataReader reader = selectCommand.ExecuteReader(); // start reading data
                while (reader.Read()) // read while there are package names
                {
                    pack.Add(reader["PkgName"].ToString()); // adds package name to list pack
                }
                reader.Close(); // once name is found stop reading
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close(); // close connection to database
            }
            return pack; // returns list of packages name to pack list object
        }

        // updates existing package record and returns bool success flag
        
        public static bool UpdatePackage(Package old_pack, Package pack)
        {
            bool successful = false;
            int count = 0;
            // prepare connection
            SqlConnection con = new SqlConnection(ConnectionString.Connection.Value());

            // prepare the SQL statement
            string updateString = "update Packages set " +
                                   "PkgName = @NewPkgName, " +
                                   "PkgStartDate = @NewPkgStartDate, " +
                                   "PkgEndDate = @NewPkgEndDate, " +
                                   "PkgDesc = @NewPkgDesc, " +
                                   "PkgBasePrice = @NewPkgBasePrice, " +
                                   "PkgAgencyCommission = @NewPkgAgencyCommission " +
                                   "where " + // update succeeds only if record not changed by other users
                                   "PkgName  = @OldPkgName and " +
                                   "PkgStartDate = @OldPkgStartDate and " +
                                   "PkgEndDate = @OldPkgEndDate and " +
                                   "PkgDesc = @OldPkgDesc and " +
                                   "PkgBasePrice = @OldPkgBasePrice and " +
                                   "PkgAgencyCommission = @OldPkgAgencyCommission";
            SqlCommand updateCommand = new SqlCommand(updateString, con);
            updateCommand.Parameters.AddWithValue("@OldPkgName", old_pack.PkgName);
            updateCommand.Parameters.AddWithValue("@OldPkgStartDate", old_pack.PkgStartDate);
            updateCommand.Parameters.AddWithValue("@OldPkgEndDate", old_pack.PkgEndDate);
            updateCommand.Parameters.AddWithValue("@OldPkgDesc", old_pack.PkgDesc);
            updateCommand.Parameters.AddWithValue("@OldPkgBasePrice", old_pack.PkgBasePrice);
            updateCommand.Parameters.AddWithValue("@OldPkgAgencyCommission", old_pack.PkgAgencyCommission);
            updateCommand.Parameters.AddWithValue("@NewPkgName", pack.PkgName);
            updateCommand.Parameters.AddWithValue("@NewPkgStartDate", pack.PkgStartDate);
            updateCommand.Parameters.AddWithValue("@NewPkgEndDate", pack.PkgEndDate);
            updateCommand.Parameters.AddWithValue("@NewPkgDesc", pack.PkgDesc);
            updateCommand.Parameters.AddWithValue("@NewPkgBasePrice", pack.PkgBasePrice);
            updateCommand.Parameters.AddWithValue("@NewPkgAgencyCommission", pack.PkgAgencyCommission);

            try
            {
                // open connection
                con.Open();

                count = updateCommand.ExecuteNonQuery();
                if (count == 1)
                    successful = true;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return successful;

        }

        static public bool DeletePackage(Package package)
        {
            bool successful = false;
            
            SqlConnection con = new SqlConnection(ConnectionString.Connection.Value());





            string deleteString = "delete from packages_products_suppliers " +
                                   "where " +
                                   "PackageId = @PackageId;" +

                                  "delete from Packages " +
                                  "where " +
                                  "PackageId = @PackageId";
                                 
            SqlCommand deleteCommand = new SqlCommand(deleteString, con);
            deleteCommand.Parameters.AddWithValue("@PackageId", package.PackageId);
            

            try
            {
                con.Open();
                successful = Convert.ToBoolean(deleteCommand.ExecuteNonQuery());
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return successful;


        }
    }
}
