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
    public partial class MainForm : Form
    {
        private DataModule DM;          // Reference to the form that holds the data components
        private OwnerForm frmOwner;     // Reference to the Owner form
        private ServiceTypeForm frmServiceType;        // Reference to the Service Type form
        private EquipmentForm frmEquipment;            // Reference to the Equipment form
        private VehicleForm frmVehicle;                // Referene to the Vehicle form
        private ServiceForm frmService;                // Reference to the Service form
        private EquipmentAllocationForm frmEquipmentAllocation;     // Reference to the Equipment Application form
        private InvoiceForm frmInvoice;             // Refererence to the Invoice form

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule();      // Create the data module and load the dataset
        }

        private void btnOwnerMaintenance_Click(object sender, EventArgs e)
        {
            if (frmOwner == null)
            {
                frmOwner = new OwnerForm(DM, this);
            }
            frmOwner.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            if (frmInvoice == null)
            {
                frmInvoice = new InvoiceForm(DM, this);
            }
            frmInvoice.ShowDialog();
        }

        private void btnServiceTypeMaintenance_Click(object sender, EventArgs e)
        {
            if (frmServiceType == null)
            {
                frmServiceType = new ServiceTypeForm(DM, this);
            }
            frmServiceType.ShowDialog();
        }

        private void btnEquipmentMaintenance_Click(object sender, EventArgs e)
        {
            if (frmEquipment == null)
            {
                frmEquipment = new EquipmentForm(DM, this);
            }
            frmEquipment.ShowDialog();
        }

        private void btnVehicleMaintenance_Click(object sender, EventArgs e)
        {
            if (frmVehicle == null)
            {
                frmVehicle = new VehicleForm(DM, this);
            }
            frmVehicle.ShowDialog();
        }

        private void btnServiceMaintenance_Click(object sender, EventArgs e)
        {
            if (frmService == null)
            {
                frmService = new ServiceForm(DM, this);
            }
            frmService.ShowDialog();
        }

        private void btnEquipmentAllocation_Click(object sender, EventArgs e)
        {
            if (frmEquipmentAllocation == null)
            {
                frmEquipmentAllocation = new EquipmentAllocationForm(DM, this);
            }
            frmEquipmentAllocation.ShowDialog();
        }
    }
}
