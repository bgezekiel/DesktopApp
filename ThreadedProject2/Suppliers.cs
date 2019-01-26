using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBClasses;
using Microsoft.VisualBasic;

namespace ThreadedProject2 {
	public partial class Suppliers : Form {
		public Suppliers() {
			InitializeComponent();


			LBSuppliers.ValueMember = "Value";
			LBSuppliers.DisplayMember = "Key";
			LBSuppliers.DataSource = SuppliersDB.SuppliersBindingSource;
		}

		private void CreateNewSupplier(object sender, EventArgs e) {
			string name = Interaction.InputBox("Type in the name of the new supplier and hit OK.", "Create New Supplier", "");


			int i = SuppliersDB.AddNewSupplier(name.ToUpper());

			KeyValuePair<string, int> val = new KeyValuePair<string, int>(name.ToUpper(), i);
			SuppliersDB.Suppliers.Add(val);
			LBSuppliers.SelectedValue = i;
			

			MessageBox.Show("Created new supplier.", "Success");
		}




        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

		private void PickNewValue(object sender, EventArgs e) {
			if(LBSuppliers.SelectedValue != null) {

				bool[] vals = SuppliersDB.GetSelectedValue((int)LBSuppliers.SelectedValue);
				CBAir.Checked = vals[1];
				CBAttractions.Checked = vals[2];
				CBCar.Checked = vals[3];
				CBCruise.Checked = vals[4];
				CBHotel.Checked = vals[5];
				CBMotor.Checked = vals[6];
				CBRail.Checked = vals[7];
				CBTours.Checked = vals[8];
				CBTravel.Checked = vals[9];
				CBYacht.Checked = vals[10];
			}
		}

		private void Clicked(object sender, EventArgs e) {
			int i;
			if (CBAir == sender) {
				i = 1;
			} else if (CBAttractions == sender) {
				i = 2;
			} else if (CBCar == sender) {
				i = 3;
			} else if (CBCruise == sender) {
				i = 4;
			} else if (CBHotel == sender) {
				i = 5;
			} else if (CBMotor == sender) {
				i = 6;
			} else if (CBRail == sender) {
				i = 7;
			} else if (CBTours == sender) {
				i = 8;
			} else if (CBTravel == sender) {
				i = 9;
			} else {
				i = 10;
			}
			CheckBox val = (CheckBox)sender;
			SuppliersDB.EditValue(i, (int) LBSuppliers.SelectedValue, val.Checked);
		}

		private void DeleteSupplier(object sender, EventArgs e) {
			bool res = SuppliersDB.DeleteSupplier((int) LBSuppliers.SelectedValue);

			KeyValuePair<string, int> v = (KeyValuePair<string, int>) LBSuppliers.SelectedItem;
			SuppliersDB.Suppliers.Remove(v);
		}
	}
}
