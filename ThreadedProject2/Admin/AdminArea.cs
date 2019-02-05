using DBClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadedProject2.Admin {
	public partial class AdminArea : Form {

		private readonly string Authuser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
		public AdminArea() {
			InitializeComponent();
			LblDesc3.Text = "Authorized User: " + Authuser;

			CBAgents.ValueMember = "Value";
			CBAgents.DisplayMember = "Key";
			CBAgents.DataSource = AgentsDB.Agents;
		}

		private void CreateAccount(object sender, EventArgs e) {



			string hash = Utilities.SHA512Hash(FieldPassword.Text, out string salt);

			using(SqlConnection con = new SqlConnection(ConnectionString.Connection.Value())) {
				con.Open();

				int res;
				using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM AgentLoginInformation WHERE AgentId = @id;", con)) {

					cmd.Parameters.AddWithValue("@id", CBAgents.SelectedValue);

					res = (int) cmd.ExecuteScalar();
				}

				if(res == 0) {
					using (SqlCommand cmd = new SqlCommand("INSERT INTO AgentLoginInformation (AgentId, AgentPassword, ForcePswdChange, Salt) VALUES (" +
					"@id, @pswd, @change, @salt);", con)) {
						cmd.Parameters.AddWithValue("@id", CBAgents.SelectedValue);
						cmd.Parameters.AddWithValue("@pswd", hash);
						cmd.Parameters.AddWithValue("@change", ChForce.Checked);
						cmd.Parameters.AddWithValue("@salt", salt);

						AddChangelogEntry(con, Authuser, "Set password for Agent " + CBAgents.SelectedValue + ".");
						cmd.ExecuteNonQuery();

						MessageBox.Show("Created password for Agent " + CBAgents.SelectedValue + " successfully.", "Success");
					}
				} else {

					UpdatePassword(con, (int) CBAgents.SelectedValue, hash, ChForce.Checked, salt);
					AddChangelogEntry(con, Authuser, "Modified password for Agent " + CBAgents.SelectedValue + ".");
					MessageBox.Show("Updated password for Agent " + CBAgents.SelectedValue + " successfully.", "Success");

				}
				
			}

			
		}

		private void ChangePswd(object sender, EventArgs e) {
			if(FieldPassword.Text.Length == 0) {
				BtnCreatePassword.Enabled = false;
			} else {
				BtnCreatePassword.Enabled = true;
			}
		}

		public static void UpdatePassword(SqlConnection con, int value, string hash, bool force, string salt) {
			using (SqlCommand cmd = new SqlCommand("UPDATE AgentLoginInformation SET AgentPassword = @pswd, ForcePswdChange = @change, Salt = @salt WHERE" +
						" AgentId = @id", con)) {
				cmd.Parameters.AddWithValue("@id", value);
				cmd.Parameters.AddWithValue("@pswd", hash);
				cmd.Parameters.AddWithValue("@change", force);
				cmd.Parameters.AddWithValue("@salt", salt);

				
				cmd.ExecuteNonQuery();

				
			}
		}

		public static void AddChangelogEntry(SqlConnection con, string user, string desc) {

			using(SqlCommand cmd = new SqlCommand("INSERT INTO AgentLoginChangelog (AuthorizedUser, Time, EditDesc) VALUES (@user, CURRENT_TIMESTAMP, @desc);", con)) {
				cmd.Parameters.AddWithValue("@user", user);
				cmd.Parameters.AddWithValue("@desc", desc);

				cmd.ExecuteNonQuery();
			}
		}
	}
}
