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
    public partial class EquipmentAllocationForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmServiceType;
        private CurrencyManager cmServiceTypeEquipment;
        private CurrencyManager cmEquipment;
        private CurrencyManager cmCTE;
        private DataTable dt = new DataTable();
        private CurrencyManager cmDt;
        public EquipmentAllocationForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmServiceType = (CurrencyManager)this.BindingContext[DM.dsGreens, "ServiceType"];
            cmServiceTypeEquipment = (CurrencyManager)this.BindingContext[DM.dsGreens, "ServiceTypeEquipment"];
            cmEquipment = (CurrencyManager)this.BindingContext[DM.dsGreens, "Equipment"];
            cmDt = (CurrencyManager)this.BindingContext[dt];
            cmCTE = (CurrencyManager)this.BindingContext[DM.dsGreens, "ServiceType.ServiceType_ServiceTypeEquipment"];
            BindControls();
        }
        public void BindControls()
        {
            dgvServiceType.DataSource = DM.dsGreens;
            dgvServiceType.DataMember = "ServiceType";

            dgvServiceTypeEquipment.DataSource = DM.dsGreens;
            dgvServiceTypeEquipment.DataMember = "ServiceType.ServiceType_ServiceTypeEquipment";

            dgvEquipment.DataSource = DM.dsGreens;
            dgvEquipment.DataMember = "Equipment";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAllocateEquipment_Click(object sender, EventArgs e)
        {

            DataRow serviceTypeRow = DM.dtServiceType.Rows[cmServiceType.Position];
            DataRow equipmentRow = DM.dtEquipment.Rows[cmEquipment.Position];
            DataRow[] serviceTypeEquipment = DM.dtServiceTypeEquipment.Select("ServiceTypeID = " + serviceTypeRow["ServiceTypeID"].ToString() + "and EquipmentID = " + equipmentRow["EquipmentID"].ToString());
            
            if (serviceTypeEquipment.Length == 0)
            {
                DataRow newServiceTypeEquipment = DM.dtServiceTypeEquipment.NewRow();

                newServiceTypeEquipment["ServiceTypeID"] = dgvServiceType["ServiceTypeID", cmServiceType.Position].Value;
                newServiceTypeEquipment["EquipmentID"] = dgvEquipment["EquipmentID", cmEquipment.Position].Value;

                DM.dsGreens.Tables["ServiceTypeEquipment"].Rows.Add(newServiceTypeEquipment);
                DM.UpdateServiceTypeEquipment();   //update database
                MessageBox.Show("Item of equipment allocated successfully", "Success");
                return;
            }
            else
            {
                MessageBox.Show("This item of equipment has already been allocated to this service type", "Error");
                return;
            }
            
        }

        private void btnRemoveEquipment_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to remove the equipment from the service type?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string serviceTypeID = DM.dtServiceType.Rows[cmServiceType.Position]["ServiceTypeID"].ToString();
                string equipmentID = dgvServiceTypeEquipment.Rows[cmCTE.Position].Cells[1].Value.ToString();
                int row = 0;

                for (int i = 0; i < DM.dtServiceTypeEquipment.Rows.Count; i++)
                {
                    string sID = DM.dtServiceTypeEquipment.Rows[i]["ServiceTypeID"].ToString();
                    string eID = DM.dtServiceTypeEquipment.Rows[i]["EquipmentID"].ToString();

                    if (serviceTypeID == sID && equipmentID == eID)
                    {
                        row = i;
                    }
                }

                DataRow dr = DM.dsGreens.Tables["ServiceTypeEquipment"].Rows[row];
                dr.Delete();
                DM.UpdateServiceTypeEquipment();   // update database
                return;
            }
            else
            {
                return;
            }
        }
    }
}
