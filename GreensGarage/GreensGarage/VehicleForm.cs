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
    public partial class VehicleForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        public VehicleForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        public void BindControls()
        {
            txtVehicleID.DataBindings.Add("Text", DM.dsGreens, "Vehicle.VehicleID");
            txtPlateNumber.DataBindings.Add("Text", DM.dsGreens, "Vehicle.PlateNumber");
            txtMake.DataBindings.Add("Text", DM.dsGreens, "Vehicle.Make");
            txtModel.DataBindings.Add("Text", DM.dsGreens, "Vehicle.Model");
            txtOwnerID.DataBindings.Add("Text", DM.dsGreens, "Vehicle.OwnerID");
            DM.dtVehicle.Columns.Add("OwnerName", typeof(string), "Parent.FirstName + ' ' + parent.LastName");
            txtOwnerName.DataBindings.Add("Text", DM.dsGreens, "Vehicle.OwnerName");
            lstVehicle.DataSource = DM.dsGreens;
            lstVehicle.DisplayMember = "Vehicle.PlateNumber";
            lstVehicle.ValueMember = "Vehicle.PlateNumber";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsGreens, "VEHICLE"];
        }

        private void LoadOwnerName()
        {
            cboOwnerID.DataSource = DM.dsGreens;
            cboOwnerID.DisplayMember = "Owner.OwnerID";
            cboOwnerID.ValueMember = "Owner.OwnerID";
            cboOwnerName.DataSource = DM.dsGreens;
            cboOwnerName.DisplayMember = "Owner.LastName";
            cboOwnerName.ValueMember = "Owner.LastName";
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            DataRow deleteVehicleRow = DM.dtVehicle.Rows[currencyManager.Position];
            DataRow[] ServiceRow = DM.dtService.Select("VehicleID = " + txtVehicleID.Text);
            if (ServiceRow.Length != 0)
            {
                MessageBox.Show("You may only delete vehicles that do not have services", "Error");
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteVehicleRow.Delete();
                    MessageBox.Show("Vehicle deleted successfully", "Success");
                    DM.UpdateVehicle();
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddVehicle.Hide();
            lstVehicle.Enabled = true;
            lstVehicle.Visible = true;
            btnDeleteVehicle.Enabled = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnUpdateVehicle.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            lstVehicle.Visible = false;
            lstVehicle.Enabled = false;
            lstVehicle.SelectedItem = null;
            btnDeleteVehicle.Enabled = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnUpdateVehicle.Enabled = false;
            btnReturn.Enabled = false;
            txtAddPlateNumber.Text = null;
            txtAddMake.Text = null;
            txtAddModel.Text = null;
            LoadOwnerName();
            pnlAddVehicle.Show();
        }

        private void btnSaveVehicle_Click(object sender, EventArgs e)
        {
            txtVehicleID.Text = null;
            DataRow newVehicleRow = DM.dtVehicle.NewRow();

            if ((txtAddPlateNumber.Text == "") || (txtAddMake.Text == "") || (txtAddModel.Text == ""))
            {
                MessageBox.Show("You must type a valid Plate number, Make and Model", "Error");
                return;
            }
            else
            {
                newVehicleRow["PlateNumber"] = Convert.ToInt32(txtAddPlateNumber.Text);
                newVehicleRow["Make"] = txtAddMake.Text;
                newVehicleRow["Model"] = txtAddModel.Text;
                newVehicleRow["OwnerID"] = cboOwnerID.Text;
                DM.dtVehicle.Rows.Add(newVehicleRow);
                MessageBox.Show("Vehicle added successfully", "Success");
                DM.UpdateVehicle();
                return;
            }
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            pnlUpdateVehicle.Hide();
            lstVehicle.Enabled = true;
            lstVehicle.Visible = true;
            btnDeleteVehicle.Enabled = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddVehicle.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void btnUpdateVehicle_Click(object sender, EventArgs e)
        {
            lstVehicle.Visible = false;
            lstVehicle.Enabled = false;
            btnDeleteVehicle.Enabled = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddVehicle.Enabled = false;
            btnReturn.Enabled = false;
            txtUpdateVehicleID.Text = txtVehicleID.Text;
            txtUpdateOwnerName.Text = txtOwnerName.Text;
            pnlUpdateVehicle.Show();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateVehicleRow = DM.dtVehicle.Rows[currencyManager.Position];

            if ((txtUpdatePlateNumber.Text == "") || (txtUpdateMake.Text == "") || (txtUpdateModel.Text == ""))
            {
                MessageBox.Show("You must type a valid Plate number, Make and Model", "Error");
                return;
            }
            else
            {
                updateVehicleRow["PlateNumber"] = txtUpdatePlateNumber.Text;
                updateVehicleRow["Make"] = txtUpdateMake.Text;
                updateVehicleRow["Model"] = txtUpdateModel.Text;
                updateVehicleRow["OwnerID"] = txtOwnerID.Text;

                currencyManager.EndCurrentEdit();
                DM.UpdateVehicle();
                MessageBox.Show("Vehicle updated successfully", "Success");
                return;
            }
        }
    }
}
