using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBClasses;
using ThreadedProject2.Admin;

namespace ThreadedProject2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			System.IO.Directory.CreateDirectory(Path.GetDirectoryName(ConnectionSetup.DataPath));
			try {

				//If the program can find a serialized ConnectionString, tries to use it. If it either
				//fails to find a serialized connection string or can't connect to the database using it, will direct to
				//the setup window. Otherwise, is directed to the main window.
				ConnectionString precs = Utilities.DeserializeObject<ConnectionString>(ConnectionSetup.DataPath);
				using (SqlConnection con = new SqlConnection(precs.Value())) {
					try {
						con.Open();
						ConnectionString.Connection = precs;

					} catch (SqlException e) {
						MessageBox.Show("Error while connecting to SQL:\n" + e.Message, "Connection Error");
						Application.Run(new ConnectionSetup(LaunchProgram));
						return;
					}
				}


			} catch (FileNotFoundException) {

				Application.Run(new ConnectionSetup(LaunchProgram));
				return;
			} catch (Exception) {
				Application.Run(new ConnectionSetup(LaunchProgram));
				return;
			}

			InitializeForms();
			Application.Run(new LoginPage());


		}

		public static void LaunchProgram(Form f) {

			InitializeForms();
			f.Hide();
			Form f2 = new LoginPage();
			f2.FormClosed += (s, args) => f.Close();
			f2.Show();

		}

		public static void InitializeForms() {

			SuppliersDB.InitializeList();
			ProductsDB.InitializeList();
			AgentsDB.InitializeList();
		}
	}
}
