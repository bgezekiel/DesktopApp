using DBClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadedProject2.Admin {
	public partial class LoginPage : Form {
		public LoginPage() {
			InitializeComponent();

			CBAgents.ValueMember = "Value";
			CBAgents.DisplayMember = "Key";
			CBAgents.DataSource = AgentsDB.Agents;

		}

		private void AdminLogin(object sender, EventArgs e) {
			new AdminArea().ShowDialog(this);
		}

		private void BtnLogIn(object sender, EventArgs e) {


			string hash = null;
			string salt = null;
			bool reset = false;

			using (SqlConnection con = new SqlConnection(ConnectionString.Connection.Value())) {

				con.Open();

				using(SqlCommand cmd = new SqlCommand("SELECT * FROM AgentLoginInformation WHERE AgentId = @id;", con)) {
					cmd.Parameters.AddWithValue("@id", CBAgents.SelectedValue);

					SqlDataReader sdr = cmd.ExecuteReader();
					while (sdr.Read()) {
						hash = sdr.GetString(1);
						reset = sdr.GetBoolean(2);
						salt = sdr.GetString(3);
					}

					sdr.Close();

				}


				if ((hash == null && salt == null) || Utilities.SHA512Check(FieldPassword.Text, hash, salt)) {

					if (reset == true) {

						ForcePasswordSet fps = new ForcePasswordSet();
						DialogResult dr = fps.ShowDialog(this);

						if(dr != DialogResult.OK) {
							return;
						}



						

						string nh = Utilities.SHA512Hash(fps.ChangedPassword, out string ns);
						AdminArea.UpdatePassword(con, (int) CBAgents.SelectedValue, nh, false, ns);
					}

					this.Hide();
					Form f2 = new MainMenu(CBAgents.Text.ToUpper(), (int) CBAgents.SelectedValue);
					f2.FormClosed += (s, args) => this.Close();
					f2.Show();
				} else {
					MessageBox.Show("Login failed: Incorrect password.", "Error");
				}
			}

			
		}
	}
}
