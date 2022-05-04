namespace GreensGarage
{
    partial class ServiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.lblPlateNumber = new System.Windows.Forms.Label();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.txtServiceType = new System.Windows.Forms.TextBox();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnMarkServicePaid = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAddService = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveAddService = new System.Windows.Forms.Button();
            this.dtpServiceDate = new System.Windows.Forms.DateTimePicker();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.lblServiceDate = new System.Windows.Forms.Label();
            this.lblAddHours = new System.Windows.Forms.Label();
            this.lblAddServiceType = new System.Windows.Forms.Label();
            this.lblAddServiceVehicle = new System.Windows.Forms.Label();
            this.cboServiceTypeDescription = new System.Windows.Forms.ComboBox();
            this.cboServiceTypeID = new System.Windows.Forms.ComboBox();
            this.cboPlateNumber = new System.Windows.Forms.ComboBox();
            this.cboVehicleID = new System.Windows.Forms.ComboBox();
            this.pnlUpdateService = new System.Windows.Forms.Panel();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.dtpUpdateServiceDate = new System.Windows.Forms.DateTimePicker();
            this.txtUpdateHours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUpdateHours = new System.Windows.Forms.Label();
            this.lblUpdateServiceType = new System.Windows.Forms.Label();
            this.lblUpdateVehicle = new System.Windows.Forms.Label();
            this.txtUpdateVehicleID = new System.Windows.Forms.TextBox();
            this.txtUpdateServiceTypeID = new System.Windows.Forms.TextBox();
            this.txtUpdatePlateNumber = new System.Windows.Forms.TextBox();
            this.txtUpdateDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.pnlAddService.SuspendLayout();
            this.pnlUpdateService.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Location = new System.Drawing.Point(12, 12);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowTemplate.Height = 33;
            this.dgvServices.Size = new System.Drawing.Size(965, 671);
            this.dgvServices.TabIndex = 0;
            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Location = new System.Drawing.Point(997, 69);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(148, 25);
            this.lblPlateNumber.TabIndex = 1;
            this.lblPlateNumber.Text = "Plate Number:";
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Location = new System.Drawing.Point(1003, 166);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(142, 25);
            this.lblOwnerName.TabIndex = 2;
            this.lblOwnerName.Text = "Owner Name:";
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Location = new System.Drawing.Point(1001, 264);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(144, 25);
            this.lblServiceType.TabIndex = 3;
            this.lblServiceType.Text = "Service Type:";
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(1014, 368);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(131, 25);
            this.lblHourlyRate.TabIndex = 4;
            this.lblHourlyRate.Text = "Hourly Rate:";
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Enabled = false;
            this.txtPlateNumber.Location = new System.Drawing.Point(1151, 63);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(152, 31);
            this.txtPlateNumber.TabIndex = 5;
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Enabled = false;
            this.txtOwnerName.Location = new System.Drawing.Point(1151, 166);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(325, 31);
            this.txtOwnerName.TabIndex = 6;
            // 
            // txtServiceType
            // 
            this.txtServiceType.Enabled = false;
            this.txtServiceType.Location = new System.Drawing.Point(1151, 264);
            this.txtServiceType.Name = "txtServiceType";
            this.txtServiceType.Size = new System.Drawing.Size(325, 31);
            this.txtServiceType.TabIndex = 7;
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Enabled = false;
            this.txtHourlyRate.Location = new System.Drawing.Point(1151, 368);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(88, 31);
            this.txtHourlyRate.TabIndex = 8;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(45, 756);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(175, 44);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(336, 756);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(189, 44);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(641, 756);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(190, 44);
            this.btnAddService.TabIndex = 11;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.Location = new System.Drawing.Point(951, 756);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(208, 44);
            this.btnUpdateService.TabIndex = 12;
            this.btnUpdateService.Text = "Update Service";
            this.btnUpdateService.UseVisualStyleBackColor = true;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateService_Click);
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Location = new System.Drawing.Point(1271, 756);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(196, 44);
            this.btnDeleteService.TabIndex = 13;
            this.btnDeleteService.Text = "Delete Service";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // btnMarkServicePaid
            // 
            this.btnMarkServicePaid.Location = new System.Drawing.Point(626, 867);
            this.btnMarkServicePaid.Name = "btnMarkServicePaid";
            this.btnMarkServicePaid.Size = new System.Drawing.Size(519, 42);
            this.btnMarkServicePaid.TabIndex = 14;
            this.btnMarkServicePaid.Text = "Mark Service as Paid";
            this.btnMarkServicePaid.UseVisualStyleBackColor = true;
            this.btnMarkServicePaid.Click += new System.EventHandler(this.btnMarkServicePaid_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(1271, 867);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(196, 42);
            this.btnReturn.TabIndex = 15;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlAddService
            // 
            this.pnlAddService.Controls.Add(this.btnCancel);
            this.pnlAddService.Controls.Add(this.btnSaveAddService);
            this.pnlAddService.Controls.Add(this.dtpServiceDate);
            this.pnlAddService.Controls.Add(this.txtHours);
            this.pnlAddService.Controls.Add(this.lblServiceDate);
            this.pnlAddService.Controls.Add(this.lblAddHours);
            this.pnlAddService.Controls.Add(this.lblAddServiceType);
            this.pnlAddService.Controls.Add(this.lblAddServiceVehicle);
            this.pnlAddService.Controls.Add(this.cboServiceTypeDescription);
            this.pnlAddService.Controls.Add(this.cboServiceTypeID);
            this.pnlAddService.Controls.Add(this.cboPlateNumber);
            this.pnlAddService.Controls.Add(this.cboVehicleID);
            this.pnlAddService.Location = new System.Drawing.Point(782, 63);
            this.pnlAddService.Name = "pnlAddService";
            this.pnlAddService.Size = new System.Drawing.Size(700, 574);
            this.pnlAddService.TabIndex = 16;
            this.pnlAddService.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(455, 471);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(174, 46);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveAddService
            // 
            this.btnSaveAddService.Location = new System.Drawing.Point(129, 471);
            this.btnSaveAddService.Name = "btnSaveAddService";
            this.btnSaveAddService.Size = new System.Drawing.Size(179, 46);
            this.btnSaveAddService.TabIndex = 10;
            this.btnSaveAddService.Text = "Add Service";
            this.btnSaveAddService.UseVisualStyleBackColor = true;
            this.btnSaveAddService.Click += new System.EventHandler(this.btnSaveAddService_Click);
            // 
            // dtpServiceDate
            // 
            this.dtpServiceDate.Location = new System.Drawing.Point(257, 333);
            this.dtpServiceDate.Name = "dtpServiceDate";
            this.dtpServiceDate.Size = new System.Drawing.Size(200, 31);
            this.dtpServiceDate.TabIndex = 9;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(257, 243);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(51, 31);
            this.txtHours.TabIndex = 8;
            // 
            // lblServiceDate
            // 
            this.lblServiceDate.AutoSize = true;
            this.lblServiceDate.Location = new System.Drawing.Point(110, 331);
            this.lblServiceDate.Name = "lblServiceDate";
            this.lblServiceDate.Size = new System.Drawing.Size(141, 25);
            this.lblServiceDate.TabIndex = 7;
            this.lblServiceDate.Text = "Service Date:";
            // 
            // lblAddHours
            // 
            this.lblAddHours.AutoSize = true;
            this.lblAddHours.Location = new System.Drawing.Point(176, 249);
            this.lblAddHours.Name = "lblAddHours";
            this.lblAddHours.Size = new System.Drawing.Size(75, 25);
            this.lblAddHours.TabIndex = 6;
            this.lblAddHours.Text = "Hours:";
            // 
            // lblAddServiceType
            // 
            this.lblAddServiceType.AutoSize = true;
            this.lblAddServiceType.Location = new System.Drawing.Point(107, 173);
            this.lblAddServiceType.Name = "lblAddServiceType";
            this.lblAddServiceType.Size = new System.Drawing.Size(144, 25);
            this.lblAddServiceType.TabIndex = 5;
            this.lblAddServiceType.Text = "Service Type:";
            // 
            // lblAddServiceVehicle
            // 
            this.lblAddServiceVehicle.AutoSize = true;
            this.lblAddServiceVehicle.Location = new System.Drawing.Point(162, 99);
            this.lblAddServiceVehicle.Name = "lblAddServiceVehicle";
            this.lblAddServiceVehicle.Size = new System.Drawing.Size(89, 25);
            this.lblAddServiceVehicle.TabIndex = 4;
            this.lblAddServiceVehicle.Text = "Vehicle:";
            // 
            // cboServiceTypeDescription
            // 
            this.cboServiceTypeDescription.FormattingEnabled = true;
            this.cboServiceTypeDescription.Location = new System.Drawing.Point(352, 170);
            this.cboServiceTypeDescription.Name = "cboServiceTypeDescription";
            this.cboServiceTypeDescription.Size = new System.Drawing.Size(163, 33);
            this.cboServiceTypeDescription.TabIndex = 3;
            // 
            // cboServiceTypeID
            // 
            this.cboServiceTypeID.FormattingEnabled = true;
            this.cboServiceTypeID.Location = new System.Drawing.Point(257, 170);
            this.cboServiceTypeID.Name = "cboServiceTypeID";
            this.cboServiceTypeID.Size = new System.Drawing.Size(73, 33);
            this.cboServiceTypeID.TabIndex = 2;
            // 
            // cboPlateNumber
            // 
            this.cboPlateNumber.FormattingEnabled = true;
            this.cboPlateNumber.Location = new System.Drawing.Point(352, 95);
            this.cboPlateNumber.Name = "cboPlateNumber";
            this.cboPlateNumber.Size = new System.Drawing.Size(163, 33);
            this.cboPlateNumber.TabIndex = 1;
            // 
            // cboVehicleID
            // 
            this.cboVehicleID.FormattingEnabled = true;
            this.cboVehicleID.Location = new System.Drawing.Point(257, 96);
            this.cboVehicleID.Name = "cboVehicleID";
            this.cboVehicleID.Size = new System.Drawing.Size(73, 33);
            this.cboVehicleID.TabIndex = 0;
            // 
            // pnlUpdateService
            // 
            this.pnlUpdateService.Controls.Add(this.txtUpdateDescription);
            this.pnlUpdateService.Controls.Add(this.txtUpdatePlateNumber);
            this.pnlUpdateService.Controls.Add(this.txtUpdateServiceTypeID);
            this.pnlUpdateService.Controls.Add(this.txtUpdateVehicleID);
            this.pnlUpdateService.Controls.Add(this.btnUpdateCancel);
            this.pnlUpdateService.Controls.Add(this.btnSaveChanges);
            this.pnlUpdateService.Controls.Add(this.dtpUpdateServiceDate);
            this.pnlUpdateService.Controls.Add(this.txtUpdateHours);
            this.pnlUpdateService.Controls.Add(this.label1);
            this.pnlUpdateService.Controls.Add(this.lblUpdateHours);
            this.pnlUpdateService.Controls.Add(this.lblUpdateServiceType);
            this.pnlUpdateService.Controls.Add(this.lblUpdateVehicle);
            this.pnlUpdateService.Location = new System.Drawing.Point(693, 50);
            this.pnlUpdateService.Name = "pnlUpdateService";
            this.pnlUpdateService.Size = new System.Drawing.Size(783, 566);
            this.pnlUpdateService.TabIndex = 17;
            this.pnlUpdateService.Visible = false;
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(478, 448);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(174, 46);
            this.btnUpdateCancel.TabIndex = 23;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(152, 448);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(179, 46);
            this.btnSaveChanges.TabIndex = 22;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // dtpUpdateServiceDate
            // 
            this.dtpUpdateServiceDate.Location = new System.Drawing.Point(280, 310);
            this.dtpUpdateServiceDate.Name = "dtpUpdateServiceDate";
            this.dtpUpdateServiceDate.Size = new System.Drawing.Size(200, 31);
            this.dtpUpdateServiceDate.TabIndex = 21;
            // 
            // txtUpdateHours
            // 
            this.txtUpdateHours.Location = new System.Drawing.Point(280, 220);
            this.txtUpdateHours.Name = "txtUpdateHours";
            this.txtUpdateHours.Size = new System.Drawing.Size(60, 31);
            this.txtUpdateHours.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Service Date:";
            // 
            // lblUpdateHours
            // 
            this.lblUpdateHours.AutoSize = true;
            this.lblUpdateHours.Location = new System.Drawing.Point(199, 226);
            this.lblUpdateHours.Name = "lblUpdateHours";
            this.lblUpdateHours.Size = new System.Drawing.Size(75, 25);
            this.lblUpdateHours.TabIndex = 18;
            this.lblUpdateHours.Text = "Hours:";
            // 
            // lblUpdateServiceType
            // 
            this.lblUpdateServiceType.AutoSize = true;
            this.lblUpdateServiceType.Location = new System.Drawing.Point(130, 150);
            this.lblUpdateServiceType.Name = "lblUpdateServiceType";
            this.lblUpdateServiceType.Size = new System.Drawing.Size(144, 25);
            this.lblUpdateServiceType.TabIndex = 17;
            this.lblUpdateServiceType.Text = "Service Type:";
            // 
            // lblUpdateVehicle
            // 
            this.lblUpdateVehicle.AutoSize = true;
            this.lblUpdateVehicle.Location = new System.Drawing.Point(185, 76);
            this.lblUpdateVehicle.Name = "lblUpdateVehicle";
            this.lblUpdateVehicle.Size = new System.Drawing.Size(89, 25);
            this.lblUpdateVehicle.TabIndex = 16;
            this.lblUpdateVehicle.Text = "Vehicle:";
            // 
            // txtUpdateVehicleID
            // 
            this.txtUpdateVehicleID.Enabled = false;
            this.txtUpdateVehicleID.Location = new System.Drawing.Point(280, 73);
            this.txtUpdateVehicleID.Name = "txtUpdateVehicleID";
            this.txtUpdateVehicleID.Size = new System.Drawing.Size(73, 31);
            this.txtUpdateVehicleID.TabIndex = 24;
            // 
            // txtUpdateServiceTypeID
            // 
            this.txtUpdateServiceTypeID.Enabled = false;
            this.txtUpdateServiceTypeID.Location = new System.Drawing.Point(280, 147);
            this.txtUpdateServiceTypeID.Name = "txtUpdateServiceTypeID";
            this.txtUpdateServiceTypeID.Size = new System.Drawing.Size(73, 31);
            this.txtUpdateServiceTypeID.TabIndex = 25;
            // 
            // txtUpdatePlateNumber
            // 
            this.txtUpdatePlateNumber.Enabled = false;
            this.txtUpdatePlateNumber.Location = new System.Drawing.Point(379, 73);
            this.txtUpdatePlateNumber.Name = "txtUpdatePlateNumber";
            this.txtUpdatePlateNumber.Size = new System.Drawing.Size(189, 31);
            this.txtUpdatePlateNumber.TabIndex = 26;
            // 
            // txtUpdateDescription
            // 
            this.txtUpdateDescription.Enabled = false;
            this.txtUpdateDescription.Location = new System.Drawing.Point(379, 144);
            this.txtUpdateDescription.Name = "txtUpdateDescription";
            this.txtUpdateDescription.Size = new System.Drawing.Size(189, 31);
            this.txtUpdateDescription.TabIndex = 27;
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 949);
            this.Controls.Add(this.pnlUpdateService);
            this.Controls.Add(this.pnlAddService);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnMarkServicePaid);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.btnUpdateService);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.txtServiceType);
            this.Controls.Add(this.txtOwnerName);
            this.Controls.Add(this.txtPlateNumber);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.lblOwnerName);
            this.Controls.Add(this.lblPlateNumber);
            this.Controls.Add(this.dgvServices);
            this.Name = "ServiceForm";
            this.Text = "Service Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.pnlAddService.ResumeLayout(false);
            this.pnlAddService.PerformLayout();
            this.pnlUpdateService.ResumeLayout(false);
            this.pnlUpdateService.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.TextBox txtServiceType;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnMarkServicePaid;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlAddService;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveAddService;
        private System.Windows.Forms.DateTimePicker dtpServiceDate;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label lblServiceDate;
        private System.Windows.Forms.Label lblAddHours;
        private System.Windows.Forms.Label lblAddServiceType;
        private System.Windows.Forms.Label lblAddServiceVehicle;
        private System.Windows.Forms.ComboBox cboServiceTypeDescription;
        private System.Windows.Forms.ComboBox cboServiceTypeID;
        private System.Windows.Forms.ComboBox cboPlateNumber;
        private System.Windows.Forms.ComboBox cboVehicleID;
        private System.Windows.Forms.Panel pnlUpdateService;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.DateTimePicker dtpUpdateServiceDate;
        private System.Windows.Forms.TextBox txtUpdateHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUpdateHours;
        private System.Windows.Forms.Label lblUpdateServiceType;
        private System.Windows.Forms.Label lblUpdateVehicle;
        private System.Windows.Forms.TextBox txtUpdateDescription;
        private System.Windows.Forms.TextBox txtUpdatePlateNumber;
        private System.Windows.Forms.TextBox txtUpdateServiceTypeID;
        private System.Windows.Forms.TextBox txtUpdateVehicleID;
    }
}