using DBClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Project: OOSD Threaded Project 2
* Connection GUI Class used to build an end user's connection string for them,
* taking out most of the guesswork. Imported and modified from Hayden's C# Lab 3.
* Author: Hayden Belanger
* Date: Jan 2019
* Commenter: Hayden Belanger
*/
namespace ThreadedProject2 {
	public partial class ConnectionSetup : Form {


		//Path for saved ConnectionString. %AppData%/NCC/bin/NorthCustomerConfigurator.dat
		public static string DataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TravelExperts\\bin\\TravelExperts.dat");
		private string Instvalue = "";
		private string Usrvalue = "";
		private Action<Form> CallbackForm;
		public ConnectionSetup(Action<Form> callbackForm) {
			InitializeComponent();
			CallbackForm = callbackForm;

		}

		//Switches a field on and off depending on if they want to specify an instance name.
		private void UseInstName(object sender, EventArgs e) {
			if(ChUseInstanceName.Checked == true) {
				FieldServerInstance.Text = Instvalue;
				FieldServerInstance.Enabled = true;
			} else {
				Instvalue = FieldServerInstance.Text;
				FieldServerInstance.Text = "";
				FieldServerInstance.Enabled = false;
			}
		}

		//Switches some fields on and off depending on if it is on Windows Auth or SQL Server Auth
		private void ChangeAuth(object sender, EventArgs e) {
			if(RdBtnSQLAuth.Checked == true) {
				FieldSqlUsername.Text = Usrvalue;
				FieldSqlUsername.Enabled = true;
				FieldSqlPassword.Enabled = true;
			} else {
				Usrvalue = FieldSqlUsername.Text;
				FieldSqlUsername.Text = "";
				FieldSqlPassword.Text = "";
				FieldSqlUsername.Enabled = false;
				FieldSqlPassword.Enabled = false;
			}
		}

		private void Connect(object sender, EventArgs ev) {
			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

			if(FieldServerAddress.Text == "" || (ChUseInstanceName.Checked == true && FieldServerInstance.Text == "")) {
				MessageBox.Show("One or more fields was missing data.", "Error");
				return;
			}

			//First part of string is Server - this is LOCALHOST\SQLEXPRESS typically but it can be anything.
			if (ChUseInstanceName.Checked == true) {
				builder["Server"] = FieldServerAddress.Text + "\\" + FieldServerInstance.Text;
			} else {
				builder["Server"] = FieldServerAddress.Text;
			}

			builder["Database"] = "TravelExperts";

			//If SQL Server Auth is enabled, it means they are connecting using a username and password stored inside of the server.
			//Otherwise, they do not specify a password in their connection string when using Windows Auth, as their account authenticates them.

			if (RdBtnSQLAuth.Checked == true) {
				if(FieldSqlUsername.Text == "" || FieldSqlPassword.Text == "") {
					MessageBox.Show("One or more fields was missing data.", "Error");
					return;
				}

				builder["User Id"] = FieldSqlUsername.Text;
				builder["Password"] = FieldSqlPassword.Text;

				


			} else {
				builder["Integrated Security"] = "SSPI";
			}

			//Tests the connection simply by trying to open and close a connection.
			using(SqlConnection con = new SqlConnection(builder.ConnectionString)) {
				try {
					con.Open();
				}catch(SqlException e) {
					MessageBox.Show("Error while connecting to SQL:\n" + e.Message, "Connection Error");
					return;
				}
			}

			Console.WriteLine(builder.ConnectionString);
			ConnectionString.Connection = new ConnectionString(builder.ConnectionString);
			

			//If checked, serializes the connection string to a file.
			Utilities.SerializeObject(ConnectionString.Connection, DataPath);

			//Hides this window, opens main window, and adds event to other window to close this window when that window is also closed.

			CallbackForm(this);
			
		}
	}
}
