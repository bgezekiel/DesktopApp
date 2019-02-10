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

namespace ThreadedProject2 {
	public partial class EditPackagesProducts : Form {

		private BindingList<KeyValuePair<string, int>> FilteredList = new BindingList<KeyValuePair<string, int>>();
		private BindingSource FilteredSource = new BindingSource();

		private BindingList<KeyValuePair<string, int>> SelectedList = new BindingList<KeyValuePair<string, int>>();
		private BindingSource SelectedSource = new BindingSource();

		private static readonly KeyValuePair<string, int> DummyVal = new KeyValuePair<string, int>("ERR", -999);

		private readonly int packageid;
		public EditPackagesProducts(int packageid) {
			InitializeComponent();

			this.packageid = packageid;
			FilteredSource.DataSource = FilteredList;
			SelectedSource.DataSource = SelectedList;

			using(SqlConnection con = new SqlConnection(ConnectionString.Connection.Value())) {
				con.Open();
				using(SqlCommand cmd = new SqlCommand("SELECT PPS.ProductSupplierId,P.ProdName,S.SupName FROM Packages_Products_Suppliers PPS JOIN Products_Suppliers PS ON PPS.ProductSupplierId = PS.ProductSupplierId JOIN Suppliers S ON PS.SupplierId = S.SupplierId JOIN Products P ON PS.ProductId = P.ProductId WHERE PPS.PackageId = @pid;", con)) {
					cmd.Parameters.AddWithValue("@pid", packageid);

					SqlDataReader sdr = cmd.ExecuteReader();

					while (sdr.Read()) {
						SelectedList.Add(new KeyValuePair<string, int>(sdr.GetString(1) + " - " + sdr.GetString(2), sdr.GetInt32(0)));
					}
				}
			}

			LBAll.DisplayMember = "Key";
			LBIn.DisplayMember = "Key";
			LBAll.ValueMember = "Value";
			LBIn.ValueMember = "Value";
			LBAll.DataSource = FilteredList;
			LBIn.DataSource = SelectedList;

			if(SelectedList.Count == 0) {
				BtnRemove.Enabled = true;
				BtnRemove.BackColor = CreateNewPackage.ColorEnabled;
			}else if(SelectedList.Count == 5) {
				BtnAdd.Enabled = false;
				BtnAdd.BackColor = CreateNewPackage.ColorDisabled;
			}
			CBProducts.DisplayMember = "Key";
			CBProducts.ValueMember = "Value";
			CBProducts.DataSource = ProductsDB.ProductsBindingSource;
		}

		private void btnUpdate_Click(object sender, EventArgs e) {

			this.Close();
		}

		private void BtnAdd_Click(object sender, EventArgs e) {
			if (BtnAdd.Enabled == true) {
				if (LBAll.SelectedValue != null) {
					KeyValuePair<string, int> val = DummyVal;
					foreach (KeyValuePair<string, int> v in FilteredList) {
						if (v.Value == (int)LBAll.SelectedValue) {
							val = v;
							break;
						}
					}

					if (val.Value != -999) {
						FilteredList.Remove(val);

						using (SqlConnection con = new SqlConnection(ConnectionString.Connection.Value())) {
							con.Open();
							using(SqlCommand cmd = new SqlCommand("INSERT INTO Packages_Products_Suppliers(ProductSupplierId, PackageId) VALUES (@psid, @pid);", con)) {
								cmd.Parameters.AddWithValue("@psid", val.Value);
								cmd.Parameters.AddWithValue("@pid", packageid);

								cmd.ExecuteNonQuery();
							}
						}
						KeyValuePair<string, int> xa = (KeyValuePair<string, int>)CBProducts.SelectedItem;
						KeyValuePair<string, int> nval = new KeyValuePair<string, int>(xa.Key + " - " + val.Key, val.Value);
						SelectedList.Add(nval);
					}
				}

				if (BtnRemove.Enabled == false) {
					BtnRemove.Enabled = true;
					BtnRemove.BackColor = CreateNewPackage.ColorEnabled;
				}

				if (SelectedList.Count == 5) {
					BtnAdd.Enabled = false;
					BtnAdd.BackColor = CreateNewPackage.ColorDisabled;
				}
			}
		}

		private void BtnRemove_Click(object sender, EventArgs e) {

			if (BtnRemove.Enabled == true) {
				if (LBIn.SelectedValue != null) {
					KeyValuePair<string, int> val = DummyVal;
					foreach (KeyValuePair<string, int> v in SelectedList) {
						if (v.Value == (int)LBIn.SelectedValue) {
							val = v;
							break;
						}
					}

					if (val.Value != -999) {
						SelectedList.Remove(val);
						using (SqlConnection con = new SqlConnection(ConnectionString.Connection.Value())) {
							con.Open();
							using (SqlCommand cmd = new SqlCommand("DELETE FROM Packages_Products_Suppliers WHERE ProductSupplierId = @psid;", con)) {
								cmd.Parameters.AddWithValue("@psid", val.Value);

								cmd.ExecuteNonQuery();
							}
						}


						string cat = val.Key.Split('-')[0].Trim();
						string v = val.Key.Split('-')[1].Trim();
						KeyValuePair<string, int> xa = (KeyValuePair<string, int>)CBProducts.SelectedItem;
						if (cat == xa.Key) {
							KeyValuePair<string, int> nval = new KeyValuePair<string, int>(v, val.Value);
							FilteredList.Add(nval);
						}



					}
				}

				if (BtnAdd.Enabled == false) {
					BtnAdd.Enabled = true;
					BtnAdd.BackColor = CreateNewPackage.ColorEnabled;
				}
				if (SelectedList.Count == 0) {
					BtnRemove.Enabled = false;
					BtnRemove.BackColor = CreateNewPackage.ColorDisabled;
				}


			}

		}

		private void VCChange(object sender, EventArgs e) {

			if(CBProducts.SelectedValue != null) {
				using(SqlConnection con = new SqlConnection(ConnectionString.Connection.Value())) {
					FilteredList.Clear();
					con.Open();

					//sql Command
					string sqlCommand = "SELECT *,PS.ProductSupplierId FROM Products PD FULL OUTER JOIN Products_Suppliers PS ON " +
										"PS.ProductId = PD.ProductId FULL OUTER JOIN Suppliers SP ON " +
										"SP.SupplierId = PS.SupplierId WHERE PS.ProductId = @prod;";

					//using the connection and the string command,
					using (SqlCommand cmd = new SqlCommand(sqlCommand, con)) {

						//Ask Hayden about this part
						cmd.Parameters.AddWithValue("@prod", CBProducts.SelectedValue);

						//using the data reader, read the data while there is still data in table
						using (SqlDataReader sdr = cmd.ExecuteReader()) {
							while (sdr.Read()) {

								FilteredList.Add(new KeyValuePair<string, int>(sdr.GetString(6), sdr.GetInt32(2)));

							}
						}
					}
				}



				foreach (KeyValuePair<string, int> kva in SelectedList) {

					bool found = false;
					KeyValuePair<string, int> kvX = DummyVal;
					foreach (KeyValuePair<string, int> kvb in FilteredList) {
						if (kva.Value == kvb.Value) {
							found = true;
							kvX = kvb;
							break;
						}
					}

					if (found) {
						FilteredList.Remove(kvX);
					}
				}
			}
		}
	}
}
