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

/**
 * Project: OOSD Threaded Project 2
 * 
* ViewPackages Form with navigation buttons. This page is for displaying package information for
* easier read and access
* 
* Author:  Brandon Ezekiel / Eugenia Chiu
* Date: Jan 2019
* Commenter: Brandon Ezekiel / Eugenia Chiu
*/

namespace ThreadedProject2
{
    public partial class ViewPackages : Form
    {

        public ViewPackages()
        {
            InitializeComponent();
            GetPackages();
        }

        private Package packages; // create object Package

        // get packages from GetPackages method
        private void GetPackages(int packID)
        {
            try
            {
                packages = PackagesDB.GetPackages(packID); // gets package object from defined method
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        // method to display packages in appropriate fields on form
        private void DisplayPackages()
        {
            txtName.Text = packages.PkgName;
            dtStart.Text = packages.PkgStartDate.ToString();
            dtEnd.Text = packages.PkgEndDate.ToString();
            txtPrice.Text = packages.PkgBasePrice.ToString();
            richTextBox1.Text = packages.PkgDesc;
            txtPrice.Text = packages.PkgBasePrice.ToString();

        }

        // sets focus on drop down when page is loaded
        private void ViewPackages_Load(object sender, EventArgs e)
        {
            comboBox1.Focus();
        }

        // closes the window and to return to home window
        private void btnBack_Click(object sender, EventArgs e)
        { 
           
            this.Close();
            
        }

        // closes the entire application
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        // binds package names to the combo box
        private void GetPackages()
        {
            comboBox1.DataSource = ViewPackagesDB.GetPackagesName(); // gets names from defined method on ViewPackagesDM.cs
            
        }

        // changes data displayed when value in combobox changed
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue != null)
            {
                Package pack = new Package(); // default constructor
                pack = ViewPackagesDB.GetPackage(comboBox1.Text);

                txtName.Text = pack.PkgName.ToString();
                dtStart.Value = pack.PkgStartDate;
                dtEnd.Value = pack.PkgEndDate;
                txtPrice.Text = pack.PkgBasePrice.ToString("c");
                richTextBox1.Text = pack.PkgDesc.ToString();
                
            }
        }
    }
}
