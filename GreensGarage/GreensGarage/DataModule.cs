using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GreensGarage
{
    public partial class DataModule : Form
    {
        public DataTable dtOwner;
        public DataTable dtServiceType;
        public DataTable dtEquipment;
        public DataTable dtVehicle;
        public DataTable dtService;
        public DataTable dtServiceTypeEquipment;
        public DataView ownerView;
        public DataView serviceTypeView;
        public DataView equipmentView;
        public DataView vehicleView;
        public DataView serviceView;
        public DataView serviceTypeEquipmentView;

        public DataModule()
        {
            InitializeComponent();
            dsGreens.EnforceConstraints = false;
            daOwner.Fill(dsGreens);
            daServiceType.Fill(dsGreens);
            daEquipment.Fill(dsGreens);
            daVehicle.Fill(dsGreens);
            daService.Fill(dsGreens);
            daServiceTypeEquipment.Fill(dsGreens);
            dtOwner = dsGreens.Tables["Owner"];
            dtServiceType = dsGreens.Tables["ServiceType"];
            dtEquipment = dsGreens.Tables["Equipment"];
            dtVehicle = dsGreens.Tables["Vehicle"];
            dtService = dsGreens.Tables["Service"];
            dtServiceTypeEquipment = dsGreens.Tables["ServiceTypeEquipment"];
            ownerView = new DataView(dtOwner);
            ownerView.Sort = "OwnerID";
            serviceTypeView = new DataView(dtServiceType);
            serviceTypeView.Sort = "ServiceTypeID";
            vehicleView = new DataView(dtVehicle);
            vehicleView.Sort = "VehicleID";
            serviceView = new DataView(dtService);
            serviceView.Sort = "ServiceTypeID";
            equipmentView = new DataView(dtEquipment);
            equipmentView.Sort = "EquipmentID";
            serviceTypeEquipmentView = new DataView(dtServiceTypeEquipment);
            serviceTypeEquipmentView.Sort = "EquipmentID";
            dsGreens.EnforceConstraints = true;
        }

        public void UpdateOwner()
        {
            daOwner.Update(dtOwner);
        }

        public void UpdateServiceType()
        {
            daServiceType.Update(dtServiceType);
        }

        private void DataModule_Load(object sender, EventArgs e)
        {

        }

        private void daOwner_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnGreens);

            if (e.StatementType == StatementType.Insert)
            {
                // Retreive the identity value and store it in the OwnerID column.
               
                newID = (int)idCMD.ExecuteScalar();
                e.Row["OwnerID"] = newID;
            }
        }

        private void daServiceType_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            //include a variable and a command to retrieve
            // the identity value from the access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnGreens);

            if (e.StatementType == StatementType.Insert)
            {
                //retrieve the identity value and store it in the service type column.

                newID = (int)idCMD.ExecuteScalar();
                e.Row["ServiceTypeID"] = newID;
            }
        }

        public void UpdateEquipment()
        {
            daEquipment.Update(dtEquipment);
        }

        private void daEquipment_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            //include a variable and a command to retrieve the identity value from the access database.

            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnGreens);

            if (e.StatementType == StatementType.Insert)
            {
                //retrieve the identity value and store it in the service type column.

                newID = (int)idCMD.ExecuteScalar();
                e.Row["EquipmentID"] = newID;
            }
        }

        public void UpdateVehicle()
        {
            daVehicle.Update(dtVehicle);
        }

        private void daVehicle_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            //include a variable and a command to retrieve the identity value from the access database.

            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnGreens);

            if (e.StatementType == StatementType.Insert)
            {
                //retrieve the identity value and store it in the service type column.

                newID = (int)idCMD.ExecuteScalar();
                e.Row["VehicleID"] = newID;
            }
        }

        public void UpdateService()
        {
            daService.Update(dtService);
        }

        /*private void daService_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            //include a variable and a command to retrieve the identity value from the access database.

            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnGreens);

            if (e.StatementType == StatementType.Insert)
            {
                //retrieve the identity value and store it in the service type column.

                newID = (int)idCMD.ExecuteScalar();
                e.Row["VehicleID"] = newID;
            }
        }   */

        public void UpdateServiceTypeEquipment()
        {
            daServiceTypeEquipment.Update(dtServiceTypeEquipment);
        }
    }
}
