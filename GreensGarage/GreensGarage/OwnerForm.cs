using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreensGarage
{
    public partial class OwnerForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public OwnerForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();       // data binding into the form elements
        }
        private void BindControls()
        {
            txtOwnerID.DataBindings.Add("Text", DM.dsGreens, "Owner.OwnerID");
            txtLastName.DataBindings.Add("Text", DM.dsGreens, "Owner.LastName");
            txtFirstName.DataBindings.Add("Text", DM.dsGreens, "Owner.FirstName");
            txtStreetAddress.DataBindings.Add("Text", DM.dsGreens, "Owner.StreetAddress");
            txtSuburb.DataBindings.Add("Text", DM.dsGreens, "Owner.Suburb");
            txtPhoneNumber.DataBindings.Add("Text", DM.dsGreens, "Owner.PhoneNumber");
            lstOwners.DataSource = DM.dsGreens;
            lstOwners.DisplayMember = "Owner.LastName";
            lstOwners.ValueMember = "Owner.LastName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsGreens, "OWNER"];
        }

        private void OwnerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;            //for getting previous member
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;            //for next member
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddOwner.Hide();
            lstOwners.Enabled = true;
            lstOwners.Visible = true;
            btnDeleteOwner.Enabled = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnUpdateOwner.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            lstOwners.Visible = false;
            lstOwners.Enabled = false;
            lstOwners.SelectedItem = null;
            btnDeleteOwner.Enabled = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnUpdateOwner.Enabled = false;
            btnReturn.Enabled = false;
            txtAddLastName.Text = null;
            txtAddFirstName.Text = null;
            txtAddStreetAddress.Text = null;
            txtAddSuburb.Text = null;
            txtAddPhoneNumber.Text = null;
            pnlAddOwner.Show();
        }

        private void btnSaveOwner_Click(object sender, EventArgs e)
        {
            lblOwnerID.Text = null;
            DataRow newOwnerRow = DM.dtOwner.NewRow();
            if ((txtAddLastName.Text == "") || (txtAddFirstName.Text == "") || (txtAddStreetAddress.Text == "") || (txtAddSuburb.Text == "") || (txtAddPhoneNumber.Text == ""))
            {
                MessageBox.Show("You must type a valid Last Name, First Name, Street Address, Suburb and Phone Number", "Error");
                return;
            }
            else
            {
                newOwnerRow["LastName"] = txtAddLastName.Text;
                newOwnerRow["FirstName"] = txtAddFirstName.Text;
                newOwnerRow["StreetAddress"] = txtAddStreetAddress.Text;
                newOwnerRow["Suburb"] = txtAddSuburb.Text;
                newOwnerRow["PhoneNumber"] = txtAddPhoneNumber.Text;
                DM.dtOwner.Rows.Add(newOwnerRow);
                MessageBox.Show("Owner added successfully", "Success");
                return;
            }
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            pnlUpdateOwner.Hide();
            lstOwners.Enabled = true;
            lstOwners.Visible = true;
            btnDeleteOwner.Enabled = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddOwner.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void btnUpdateOwner_Click(object sender, EventArgs e)
        {
            lstOwners.Visible = false;
            lstOwners.Enabled = false;
            btnDeleteOwner.Enabled = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddOwner.Enabled = false;
            btnReturn.Enabled = false;
            pnlUpdateOwner.Show();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateOwnerRow = DM.dtOwner.Rows[currencyManager.Position];

            if ((txtUpdateLastName.Text == "") || (txtUpdateFirstName.Text == "") || (txtUpdateStreetAddress.Text == "") || (txtUpdateSuburb.Text == "") || (txtUpdatePhoneNumber.Text == ""))
            {
                MessageBox.Show("You must type a valid Last Name, First Name, Street Address, Suburb and Phone Number", "Error");
                return;
            }
            else
            {
                updateOwnerRow["LastName"] = txtUpdateLastName.Text;
                updateOwnerRow["FirstName"] = txtUpdateFirstName.Text;
                updateOwnerRow["StreetAddress"] = txtUpdateStreetAddress.Text;
                updateOwnerRow["Suburb"] = txtUpdateSuburb.Text;
                updateOwnerRow["PhoneNumber"] = txtUpdatePhoneNumber.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateOwner();
                MessageBox.Show("Owner updated successfully", "Success");
                return;
            }
        }

        private void btnDeleteOwner_Click(object sender, EventArgs e)
        {
            DataRow deleteOwnerRow = DM.dtOwner.Rows[currencyManager.Position];
            DataRow[] vehicleRow = DM.dtVehicle.Select("OwnerID = " + txtOwnerID.Text);
            if (vehicleRow.Length != 0)
            {
                MessageBox.Show("You may only delete owner who have no vehicles", "Error");
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteOwnerRow.Delete();
                    DM.UpdateOwner();
                    MessageBox.Show("Owner deleted successfully", "Success");
                    return;
                }
            }
        }
    }
}