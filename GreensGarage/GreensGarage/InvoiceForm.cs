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
    public partial class InvoiceForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private int amountOfServicesPrinted, pagesAmountExpected;
        private DataRow[] servicesForPrint;

        public InvoiceForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void printInvoices_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int lineSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 10, FontStyle.Regular);
            Font totalSubTotal = new Font("Arial", 10, FontStyle.Bold);
            Font headingFont = new Font("Arial", 10, FontStyle.Bold);

            DataRow drService = servicesForPrint[amountOfServicesPrinted];

            CurrencyManager cmOwner;
            CurrencyManager cmVehicle;
            CurrencyManager cmServiceType;
            CurrencyManager cmEquipment;

            cmOwner = (CurrencyManager)this.BindingContext[DM.dsGreens, "OWNER"];
            cmVehicle = (CurrencyManager)this.BindingContext[DM.dsGreens, "VEHICLE"];
            cmServiceType = (CurrencyManager)this.BindingContext[DM.dsGreens, "SERVICETYPE"];
            cmEquipment = (CurrencyManager)this.BindingContext[DM.dsGreens, "EQUIPMENT"];

            Brush brush = new SolidBrush(Color.Black);

            // margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;

            //heading
            string serviceStatus = drService["Status"].ToString();
            if (serviceStatus.Equals("Pending") == true)
            {
                // get the vehicle record matching vehicle ID from the service record
                int aVehicleID = Convert.ToInt32(drService["VehicleID"].ToString());
                cmVehicle.Position = DM.vehicleView.Find(aVehicleID);
                DataRow drVehicle = DM.dtVehicle.Rows[cmVehicle.Position];

                // get the owner record matching the owner ID from the vehicle record
                int aOwnerID = Convert.ToInt32(drVehicle["OwnerID"].ToString());
                cmOwner.Position = DM.ownerView.Find(aOwnerID);
                DataRow drOwner = DM.dtOwner.Rows[cmOwner.Position];

                // get the service type record matching servicetype ID from the service record
                int aServiceTypeID = Convert.ToInt32(drService["ServiceTypeID"].ToString());
                cmServiceType.Position = DM.serviceTypeView.Find(aServiceTypeID);
                DataRow drServiceType = DM.dtServiceType.Rows[cmServiceType.Position];

                string serviceDate = drService["ServiceDate"].ToString();
                DateTime serviceDate2 = Convert.ToDateTime(serviceDate);
                string serviceDate3 = serviceDate2.ToString("dd/MM/yyyy");
                double hourlyRate = Convert.ToDouble(drServiceType["HourlyRate"]);

                g.DrawString("Owner ID: " + drOwner["OwnerID"].ToString(), headingFont, brush, leftMargin + headingLeftMargin, topMargin);
                lineSoFarHeading++;
                g.DrawString(drOwner["LastName"] + ", " + drOwner["FirstName"], headingFont, brush, leftMargin + headingLeftMargin, topMargin + (lineSoFarHeading * textFont.Height));
                lineSoFarHeading++;
                g.DrawString(drOwner["StreetAddress"].ToString(), headingFont, brush, leftMargin + headingLeftMargin, topMargin + (lineSoFarHeading * textFont.Height));
                lineSoFarHeading++;
                g.DrawString(drOwner["Suburb"].ToString(), headingFont, brush, leftMargin + headingLeftMargin, topMargin + (lineSoFarHeading * textFont.Height));
                lineSoFarHeading++;
                lineSoFarHeading++;
                lineSoFarHeading++;
                g.DrawString("Vehicle ID: " + drVehicle["VehicleID"].ToString(), headingFont, brush, leftMargin + headingLeftMargin, topMargin + (lineSoFarHeading * textFont.Height));
                g.DrawString("\t\t\tPlate Number: " + drVehicle["PlateNumber"].ToString(), headingFont, brush, leftMargin + headingLeftMargin, topMargin + (lineSoFarHeading * textFont.Height));
                lineSoFarHeading++;
                g.DrawString("Make: " + drVehicle["Make"].ToString(), headingFont, brush, leftMargin + headingLeftMargin, topMargin + (lineSoFarHeading * textFont.Height));
                g.DrawString("\t\t\tModel: " + drVehicle["Model"].ToString(), headingFont, brush, leftMargin + headingLeftMargin, topMargin + (lineSoFarHeading * textFont.Height));
                lineSoFarHeading++;
                lineSoFarHeading++;
                lineSoFarHeading++;
                g.DrawString("Service Type: " + drServiceType["Description"].ToString(), headingFont, brush, leftMargin + headingLeftMargin, topMargin + (lineSoFarHeading * textFont.Height));
                lineSoFarHeading++;
                g.DrawString("Hourly Rate: NZ$ " + string.Format("{0:#.00}", hourlyRate), headingFont, brush, leftMargin + headingLeftMargin, topMargin + (lineSoFarHeading * textFont.Height));
                lineSoFarHeading++;
                lineSoFarHeading++; 
                g.DrawString("Service Hours: " + drService["Hours"].ToString(), headingFont, brush, leftMargin + headingLeftMargin, topMargin + (lineSoFarHeading * textFont.Height));
                g.DrawString("\t\t\tService Date: " + serviceDate3, headingFont, brush, leftMargin + headingLeftMargin, topMargin + (lineSoFarHeading * textFont.Height));
                lineSoFarHeading++;
                lineSoFarHeading++;
                lineSoFarHeading++;

                double grossDue = Convert.ToDouble(drServiceType["HourlyRate"]) * Convert.ToInt32(drService["Hours"]);

                DataRow[] drEquipments = drServiceType.GetChildRows(DM.dtServiceType.ChildRelations["SERVICETYPE_SERVICETYPEEQUIPMENT"]);

                if (drEquipments.Length > 0)
                {
                    g.DrawString("Equipments Used: ", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (lineSoFarHeading * textFont.Height));
                    foreach (DataRow drServiceTypeEquipment in drEquipments)
                    {
                        string equipmentText = "";
                        int aEquipmentID = Convert.ToInt32(drServiceTypeEquipment["EquipmentID"].ToString());
                        cmEquipment.Position = DM.equipmentView.Find(aEquipmentID);
                        DataRow drEquipment = DM.dtEquipment.Rows[cmEquipment.Position];

                        equipmentText = drEquipment["Description"].ToString();
                        g.DrawString("\t\t\t" + equipmentText, headingFont, brush, leftMargin + headingLeftMargin, topMargin + (lineSoFarHeading * textFont.Height));
                        lineSoFarHeading++;
                    }
                    lineSoFarHeading++;
                    
                }
                lineSoFarHeading++;
                g.DrawString("Gross Due: NZ$ " + string.Format("{0:#.00}", grossDue), headingFont, brush, leftMargin + headingLeftMargin, topMargin + (lineSoFarHeading * textFont.Height));
                lineSoFarHeading++;
                lineSoFarHeading++;
                lineSoFarHeading++;
                amountOfServicesPrinted++;

                if (!(amountOfServicesPrinted == pagesAmountExpected))
                {
                    e.HasMorePages = true;
                }
            }
        }

      

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            amountOfServicesPrinted = 0;
            string strFilter = "Status = 'Pending'";
            string strSort = "ServiceTypeID";

            servicesForPrint = DM.dsGreens.Tables["SERVICE"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = servicesForPrint.Length;
            prvInvoices.Show();
        }
    }
}
