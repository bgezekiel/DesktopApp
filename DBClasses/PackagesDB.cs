using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBClasses;

/**
 * Project: OOSD Threaded Project 2
* Object class for building Packages objects and getting a list of such.
* 
* Author: Brandon Ezekiel
* CoAuthor: Hayden Belanger
* Date: Jan 2019
* Commenter: Hayden Belanger and Eugenia Chiu
*/

namespace ThreadedProject2
{

    public class PackagesDB
    {
        //Establish connection string
        public static string connectionString = ConnectionString.Connection.Value();

        //getPackages, pass in packageID to retrieve
        public static Package GetPackages(int packID)
        {

            List<Package> pack = new List<Package>(); //make new empty list of packages
            Package p;
            SqlConnection con = new SqlConnection(ConnectionString.Connection.Value());
            string query = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc FROM Packages WHERE PackageId = @PackageId";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@PackageId", packID); //protect against sql injection
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow); //read data from whole row
                if (reader.Read()) //if there is still data
                {
                    p = new Package();
                    p.PackageId = (int)reader["PackageId"];
                    p.PkgName = reader["PkgName"].ToString();
                    p.PkgStartDate = (DateTime)reader["PkgStartDate"];
                    p.PkgEndDate = (DateTime)reader["PkgEndDate"];
                    p.PkgDesc = reader["PkgDesc"].ToString();
                    p.PkgBasePrice = (decimal)reader["PkgBasePrice"];

                    pack.Add(p);

                }
                return pack.Single();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

        }

        //AddPackage method for new packages inserted by user
		public static void AddPackage(string PackageName, DateTime StartDate, DateTime EndDate, string Desc, decimal BasePrice, decimal AgentComm, int[] suppliers) {

			using(SqlConnection con = new SqlConnection(ConnectionString.Connection.Value())) {
				con.Open();
				

				using(SqlCommand cmd = new SqlCommand("INSERT INTO Packages(PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission) VALUES (@name, @start, @end, @desc, @base, @comm);", con)) {
					cmd.Parameters.AddWithValue("@name", PackageName);
					cmd.Parameters.AddWithValue("@start", StartDate);
					cmd.Parameters.AddWithValue("@end", EndDate);
					cmd.Parameters.AddWithValue("@desc", Desc);
					cmd.Parameters.AddWithValue("@base", BasePrice);
					cmd.Parameters.AddWithValue("@comm", AgentComm);

					cmd.ExecuteNonQuery();

				}

                //select the max value of the id from the table
				int id = (int)new SqlCommand("SELECT MAX(PackageId) FROM Packages;", con).ExecuteScalar();

				List<int> ProductSupplierId = new List<int>();
				using (SqlCommand cmd = new SqlCommand("SELECT SupplierId, ProductSupplierId FROM Products_Suppliers;", con)) {

					SqlDataReader rd = cmd.ExecuteReader();
					while (rd.Read()) {
						foreach(int i in suppliers) {
							if(i == rd.GetInt32(0)) {
								ProductSupplierId.Add(rd.GetInt32(1));
							}
						}
					}

					rd.Close();
				}


				foreach(int i in ProductSupplierId) {
					using(SqlCommand cmd = new SqlCommand("INSERT INTO Packages_Products_Suppliers(PackageId, ProductSupplierId) VALUES (@packid, @psid);", con)) {
						cmd.Parameters.AddWithValue("@packid", id);
						cmd.Parameters.AddWithValue("@psid", i);

						cmd.ExecuteNonQuery();
						
					}
				}

			}

		}
    }
}