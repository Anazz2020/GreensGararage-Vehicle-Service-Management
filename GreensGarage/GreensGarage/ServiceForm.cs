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
    public partial class ServiceForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmService;
        private CurrencyManager currencyManager;
        public ServiceForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmService = (CurrencyManager)this.BindingContext[DM.dsGreens, "Service"];
            BindControls();
        }
        public void BindControls()
        {
            DM.dtVehicle.Columns.Add("OwnerName", typeof(string), "Parent(OWNER_VEHICLE).FirstName + ' ' + Parent(OWNER_VEHICLE).LastName");
            DM.dtService.Columns.Add("Ownername", typeof(string), "Parent(SERVICE_VEHICLE).OwnerName");
            txtOwnerName.DataBindings.Add("Text", DM.dsGreens, "Service.Ownername");
            DM.dtService.Columns.Add("PlateNumber", typeof(string), "Parent(SERVICE_VEHICLE).PlateNumber");
            txtPlateNumber.DataBindings.Add("Text", DM.dsGreens, "Service.PlateNumber");
            DM.dtService.Columns.Add("Description", typeof(string), "Parent(SERVICE_SERVICETYPE).Description");
            DM.dtService.Columns.Add("HourlyRate", typeof(string), "Parent(SERVICE_SERVICETYPE).HourlyRate");
            txtServiceType.DataBindings.Add("Text", DM.dsGreens, "Service.Description");
            txtHourlyRate.DataBindings.Add("Text", DM.dsGreens, "Service.HourlyRate");
            dgvServices.DataSource = DM.dsGreens;
            dgvServices.DataMember = "Service";

        }

        private void LoadVehicle()
        {
            cboVehicleID.DataSource = DM.dsGreens;
            cboVehicleID.DisplayMember = "Vehicle.VehicleID";
            cboVehicleID.ValueMember = "Vehicle.VehicleID";
            cboPlateNumber.DataSource = DM.dsGreens;
            cboPlateNumber.DisplayMember = "Vehicle.PlateNumber";
            cboPlateNumber.ValueMember = "Vehicle.PlateNumber";
        }

        private void LoadServiceType()
        {
            cboServiceTypeID.DataSource = DM.dsGreens;
            cboServiceTypeID.DisplayMember = "ServiceType.ServiceTypeID";
            cboServiceTypeID.ValueMember = "ServiceType.ServiceTypeID";
            cboServiceTypeDescription.DataSource = DM.dsGreens;
            cboServiceTypeDescription.DisplayMember = "ServiceType.Description";
            cboServiceTypeDescription.ValueMember = "ServiceType.Description";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (cmService.Position > 0)
            {
                --cmService.Position;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cmService.Position < cmService.Count - 1)
            {
                ++cmService.Position;
            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            DataRow deleteServiceRow = DM.dtService.Rows[cmService.Position];

            if (deleteServiceRow["Status"].ToString() == "Pending")
            {
                MessageBox.Show("You may only delete paid services", "Error");
                return;
            }
            else if (deleteServiceRow["Status"].ToString() == "Paid")
            {
                if (MessageBox.Show("Are you you want to delete this service?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK )
                {
                    deleteServiceRow.Delete();
                    DM.UpdateService();
                    MessageBox.Show("Service deleted successfully", "Success");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Service status is not paid or pending", "Error");
                return;
            }
        }

        private void btnMarkServicePaid_Click(object sender, EventArgs e)
        {
            DataRow markServiceRow = DM.dtService.Rows[cmService.Position];

            if (markServiceRow["Status"].ToString() == "Pending")
            {
                markServiceRow["Status"] = "Paid";
                DM.UpdateService();
                MessageBox.Show("Service marked as paid", "Success");
                return;
            }
            else if (markServiceRow["Status"].ToString() == "Paid")
            {
                MessageBox.Show("The service is already paid", "Error");
                return;
            }
            else
            {
                MessageBox.Show("The service is not paid or pending", "Error");
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddService.Hide();
            dgvServices.Enabled = true;
            dgvServices.Visible = true;
            btnDeleteService.Enabled = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnUpdateService.Enabled = true;
            btnReturn.Enabled = true;
            btnMarkServicePaid.Enabled = true;
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            dgvServices.Enabled = false;
            dgvServices.Visible = false;
            btnDeleteService.Enabled = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnUpdateService.Enabled = false;
            btnReturn.Enabled = false;
            btnMarkServicePaid.Enabled = false;
            txtHours.Text = null;
            LoadVehicle();
            LoadServiceType();
            pnlAddService.Show();
        }

        private void btnSaveAddService_Click(object sender, EventArgs e)
        {
            DataRow newServiceRow = DM.dtService.NewRow();

            if ((txtHours.Text == "") || (cboVehicleID.Text == "") || (cboServiceTypeID.Text == "") || (dtpServiceDate.Text == ""))
            {
                MessageBox.Show("You must type valid hours and choose vehicle, service type and date", "Error");
                return;
            }
            else
            {
                newServiceRow["VehicleID"] = cboVehicleID.Text;
                newServiceRow["ServiceTypeID"] = cboServiceTypeID.Text;
                newServiceRow["Hours"] = txtHours.Text;
                newServiceRow["ServiceDate"] = dtpServiceDate.Text;
                newServiceRow["Status"] = "Pending";
                DM.dtService.Rows.Add(newServiceRow);
                MessageBox.Show("Service added successfully", "Success");
                DM.UpdateService();
                return;
            }
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            pnlUpdateService.Hide();
            dgvServices.Enabled = true;
            dgvServices.Visible = true;
            btnDeleteService.Enabled = true;
            btnPrevious.Enabled = true;
            btnAddService.Enabled = true;
            btnMarkServicePaid.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            DataRow serviceRow = DM.dtService.Rows[cmService.Position];
            if (serviceRow["Status"].ToString() == "Pending")
            {
                dgvServices.Enabled = false;
                dgvServices.Visible = false;
                btnDeleteService.Enabled = false;
                btnPrevious.Enabled = false;
                btnNext.Enabled = false;
                btnAddService.Enabled = false;
                btnMarkServicePaid.Enabled = false;
                btnReturn.Enabled = false;
                txtUpdateVehicleID.Text = serviceRow["VehicleID"].ToString();
                txtUpdatePlateNumber.Text = serviceRow["PlateNumber"].ToString();
                txtUpdateServiceTypeID.Text = serviceRow["ServiceTypeID"].ToString();
                txtUpdateDescription.Text = serviceRow["Description"].ToString();
                pnlUpdateService.Show();
            }
            else
            {
                MessageBox.Show("You cannot update a paid service", "Error");
                return;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateServiceRow = DM.dtService.Rows[cmService.Position];

            if ((txtUpdateHours.Text == "") || (dtpUpdateServiceDate.Text == ""))
            {
                MessageBox.Show("You must type in service hours and choose date to update", "Error");
                return;
            }
            else
            {
                updateServiceRow["Hours"] = txtUpdateHours.Text;
                updateServiceRow["ServiceDate"] = dtpUpdateServiceDate.Text;

                cmService.EndCurrentEdit();
                DM.UpdateService();
                MessageBox.Show("Service updated successfully", "Success");
                return;
            }
        }
    }
}
