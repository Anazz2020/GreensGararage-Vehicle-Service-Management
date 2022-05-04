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
    public partial class ServiceTypeForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public ServiceTypeForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        public void BindControls()
        {
            txtServiceTypeID.DataBindings.Add("Text", DM.dsGreens, "ServiceType.ServiceTypeID");
            txtDescription.DataBindings.Add("Text", DM.dsGreens, "ServiceType.Description");
            txtHourlyRate.DataBindings.Add("Text", DM.dsGreens, "ServiceType.HourlyRate");
            lstServiceType.DataSource = DM.dsGreens;
            lstServiceType.DisplayMember = "ServiceType.Description";
            lstServiceType.ValueMember = "ServiceType.Description";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsGreens, "SERVICETYPE"];
        }
        private void ServiceTypeForm_Load(object sender, EventArgs e)
        {

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

        private void btnDeleteServiceType_Click(object sender, EventArgs e)
        {
            DataRow deleteServiceTypeRow = DM.dtServiceType.Rows[currencyManager.Position];
            DataRow[] ServiceRow = DM.dtService.Select("ServiceTypeID =" + txtServiceTypeID.Text);
            DataRow[] EquipmentRow = DM.dtServiceTypeEquipment.Select("ServiceTypeID =" + txtServiceTypeID.Text);
            if (ServiceRow.Length == 0 && EquipmentRow.Length == 0)
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteServiceTypeRow.Delete();
                    DM.UpdateServiceType();
                    MessageBox.Show("Service type deleted successfully", "Success");
                    return;
                }
            }
            else
            {
                if (ServiceRow.Length != 0)
                {
                    MessageBox.Show("You may only delete Service Types that are not assigned to services");
                    return;
                }

                if (EquipmentRow.Length != 0)
                {
                    MessageBox.Show("You may only delete Service Types who are not allocated equipment");
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddServiceType.Hide();
            lstServiceType.Enabled = true;
            lstServiceType.Visible = true;
            btnDeleteServiceType.Enabled = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnUpdateServiceType.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void btnAddServiceType_Click(object sender, EventArgs e)
        {
            lstServiceType.Visible = false;
            lstServiceType.Enabled = false;
            lstServiceType.SelectedItem = null;
            btnDeleteServiceType.Enabled = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnUpdateServiceType.Enabled = false;
            btnReturn.Enabled = false;
            txtAddDescription.Text = null;
            txtAddHourlyRate.Text = null;
            pnlAddServiceType.Show();
        }

        private void btnSaveServiceType_Click(object sender, EventArgs e)
        {
            txtServiceTypeID.Text = null;
            DataRow newServiceTypeRow = DM.dtServiceType.NewRow();

            if ((txtAddDescription.Text == "") || (txtAddHourlyRate.Text == ""))
            {
                MessageBox.Show("You must type a valid Service Type Description and Hourly Rate", "Error");
                return;
            }
            else
            {
                try
                {
                    newServiceTypeRow["Description"] = txtAddDescription.Text;
                    newServiceTypeRow["Hourlyrate"] = Convert.ToDouble(txtAddHourlyRate.Text);
                    DM.dtServiceType.Rows.Add(newServiceTypeRow);
                    MessageBox.Show("Service Type added successfully", "Success");
                    DM.UpdateServiceType();
                    return;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter a number for hourly rate", "Error");
                    return;
                }
            }
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            pnlUpdateServiceType.Hide();
            lstServiceType.Enabled = true;
            lstServiceType.Visible = true;
            btnDeleteServiceType.Enabled = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddServiceType.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void btnUpdateServiceType_Click(object sender, EventArgs e)
        {
            lstServiceType.Visible = false;
            lstServiceType.Enabled = false;
            btnDeleteServiceType.Enabled = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddServiceType.Enabled = false;
            btnReturn.Enabled = false;
            pnlUpdateServiceType.Show();
            txtUpdateServiceTypeID.Text = txtServiceTypeID.Text;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateServiceTypeRow = DM.dtServiceType.Rows[currencyManager.Position];

            if ((txtUpdateDescription.Text == "") || (txtUpdateHourlyRate.Text == ""))
            {
                MessageBox.Show("You must type a valid Service Type description and hourly rate", "Error");
                return;
            }
            else
            {
                updateServiceTypeRow["Description"] = txtUpdateDescription.Text;
                updateServiceTypeRow["HourlyRate"] = Convert.ToDouble(txtUpdateHourlyRate.Text);
                currencyManager.EndCurrentEdit();
                DM.UpdateServiceType();
                MessageBox.Show("Service Type updated successfully", "Success");
                return;
            }
        }
    }
}
