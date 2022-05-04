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
    public partial class EquipmentForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public EquipmentForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        public void BindControls()
        {
            txtEquipmentID.DataBindings.Add("Text", DM.dsGreens, "Equipment.EquipmentID");
            txtDescription.DataBindings.Add("Text", DM.dsGreens, "Equipment.Description");
            lstEquipments.DataSource = DM.dsGreens;
            lstEquipments.DisplayMember = "Equipment.Description";
            lstEquipments.ValueMember = "Equipment.Description";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsGreens, "EQUIPMENT"];
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

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            DataRow deleteEquipmentRow = DM.dtEquipment.Rows[currencyManager.Position];
            DataRow[] ServiceTypeRow = DM.dtServiceTypeEquipment.Select("EquipmentID =" + txtEquipmentID.Text);
            if (ServiceTypeRow.Length != 0)
            {
                MessageBox.Show("You may only delete equipment that is not allocated to a service type", "Error");
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteEquipmentRow.Delete();
                    DM.UpdateEquipment();
                    MessageBox.Show("Item of equipment deleted successfully", "Success");
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddEquipment.Hide();
            lstEquipments.Enabled = true;
            lstEquipments.Visible = true;
            btnDeleteEquipment.Enabled = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnUpdateEquipment.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            lstEquipments.Visible = false;
            lstEquipments.Enabled = false;
            lstEquipments.SelectedItem = null;
            btnDeleteEquipment.Enabled = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnUpdateEquipment.Enabled = false;
            btnReturn.Enabled = false;
            txtAddDescription.Text = null;
            pnlAddEquipment.Show();
        }

        private void btnSaveEquipment_Click(object sender, EventArgs e)
        {
            txtEquipmentID.Text = null;
            DataRow newEquipmentRow = DM.dtEquipment.NewRow();

            if (txtAddDescription.Text == "")
            {
                MessageBox.Show("You must type a valid equipment item", "Error");
                return;
            }
            else
            {
                try
                {
                    newEquipmentRow["Description"] = txtAddDescription.Text;
                    DM.dtEquipment.Rows.Add(newEquipmentRow);
                    MessageBox.Show("Item of equipment added successfully", "Success");
                    DM.UpdateEquipment();
                    return;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter a valid description", "Error");
                    return;
                }
            }
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            pnlUpdateEquipment.Hide();
            lstEquipments.Enabled = true;
            lstEquipments.Visible = true;
            btnDeleteEquipment.Enabled = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddEquipment.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void btnUpdateEquipment_Click(object sender, EventArgs e)
        {
            lstEquipments.Visible = false;
            lstEquipments.Enabled = false;
            btnDeleteEquipment.Enabled = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddEquipment.Enabled = false;
            btnReturn.Enabled = false;
            pnlUpdateEquipment.Show();
            txtUpdateEquipmentID.Text = txtEquipmentID.Text;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateEquipmentRow = DM.dtEquipment.Rows[currencyManager.Position];

            if (txtUpdateDescription.Text == "")
            {
                MessageBox.Show("You must type a valid Equipment item to update", "Error");
                return;
            }
            else
            {
                updateEquipmentRow["Description"] = txtUpdateDescription.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateEquipment();
                MessageBox.Show("Item of equipment updated successfully", "Success");
                return;
            }
        }
    }
}
