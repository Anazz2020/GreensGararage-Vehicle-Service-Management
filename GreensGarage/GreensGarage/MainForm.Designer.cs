namespace GreensGarage
{
    partial class MainForm
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
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.btnEquipmentAllocation = new System.Windows.Forms.Button();
            this.btnServiceMaintenance = new System.Windows.Forms.Button();
            this.btnVehicleMaintenance = new System.Windows.Forms.Button();
            this.btnEquipmentMaintenance = new System.Windows.Forms.Button();
            this.btnServiceTypeMaintenance = new System.Windows.Forms.Button();
            this.btnOwnerMaintenance = new System.Windows.Forms.Button();
            this.grpReporting = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.grpMaintenance.SuspendLayout();
            this.grpReporting.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.Controls.Add(this.btnEquipmentAllocation);
            this.grpMaintenance.Controls.Add(this.btnServiceMaintenance);
            this.grpMaintenance.Controls.Add(this.btnVehicleMaintenance);
            this.grpMaintenance.Controls.Add(this.btnEquipmentMaintenance);
            this.grpMaintenance.Controls.Add(this.btnServiceTypeMaintenance);
            this.grpMaintenance.Controls.Add(this.btnOwnerMaintenance);
            this.grpMaintenance.Location = new System.Drawing.Point(53, 59);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Size = new System.Drawing.Size(528, 854);
            this.grpMaintenance.TabIndex = 0;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Maintenance";
            // 
            // btnEquipmentAllocation
            // 
            this.btnEquipmentAllocation.Location = new System.Drawing.Point(94, 706);
            this.btnEquipmentAllocation.Name = "btnEquipmentAllocation";
            this.btnEquipmentAllocation.Size = new System.Drawing.Size(326, 67);
            this.btnEquipmentAllocation.TabIndex = 5;
            this.btnEquipmentAllocation.Text = "Equipment Allocation";
            this.btnEquipmentAllocation.UseVisualStyleBackColor = true;
            this.btnEquipmentAllocation.Click += new System.EventHandler(this.btnEquipmentAllocation_Click);
            // 
            // btnServiceMaintenance
            // 
            this.btnServiceMaintenance.Location = new System.Drawing.Point(94, 572);
            this.btnServiceMaintenance.Name = "btnServiceMaintenance";
            this.btnServiceMaintenance.Size = new System.Drawing.Size(326, 70);
            this.btnServiceMaintenance.TabIndex = 4;
            this.btnServiceMaintenance.Text = "Service Maintenance";
            this.btnServiceMaintenance.UseVisualStyleBackColor = true;
            this.btnServiceMaintenance.Click += new System.EventHandler(this.btnServiceMaintenance_Click);
            // 
            // btnVehicleMaintenance
            // 
            this.btnVehicleMaintenance.Location = new System.Drawing.Point(94, 444);
            this.btnVehicleMaintenance.Name = "btnVehicleMaintenance";
            this.btnVehicleMaintenance.Size = new System.Drawing.Size(326, 64);
            this.btnVehicleMaintenance.TabIndex = 3;
            this.btnVehicleMaintenance.Text = "Vehicle Maintenance";
            this.btnVehicleMaintenance.UseVisualStyleBackColor = true;
            this.btnVehicleMaintenance.Click += new System.EventHandler(this.btnVehicleMaintenance_Click);
            // 
            // btnEquipmentMaintenance
            // 
            this.btnEquipmentMaintenance.Location = new System.Drawing.Point(94, 316);
            this.btnEquipmentMaintenance.Name = "btnEquipmentMaintenance";
            this.btnEquipmentMaintenance.Size = new System.Drawing.Size(326, 64);
            this.btnEquipmentMaintenance.TabIndex = 2;
            this.btnEquipmentMaintenance.Text = "Equipment Maintenance";
            this.btnEquipmentMaintenance.UseVisualStyleBackColor = true;
            this.btnEquipmentMaintenance.Click += new System.EventHandler(this.btnEquipmentMaintenance_Click);
            // 
            // btnServiceTypeMaintenance
            // 
            this.btnServiceTypeMaintenance.Location = new System.Drawing.Point(94, 190);
            this.btnServiceTypeMaintenance.Name = "btnServiceTypeMaintenance";
            this.btnServiceTypeMaintenance.Size = new System.Drawing.Size(326, 65);
            this.btnServiceTypeMaintenance.TabIndex = 1;
            this.btnServiceTypeMaintenance.Text = "Service Type Maintenance";
            this.btnServiceTypeMaintenance.UseVisualStyleBackColor = true;
            this.btnServiceTypeMaintenance.Click += new System.EventHandler(this.btnServiceTypeMaintenance_Click);
            // 
            // btnOwnerMaintenance
            // 
            this.btnOwnerMaintenance.Location = new System.Drawing.Point(94, 68);
            this.btnOwnerMaintenance.Name = "btnOwnerMaintenance";
            this.btnOwnerMaintenance.Size = new System.Drawing.Size(326, 61);
            this.btnOwnerMaintenance.TabIndex = 0;
            this.btnOwnerMaintenance.Text = "Owner Maintenance";
            this.btnOwnerMaintenance.UseVisualStyleBackColor = true;
            this.btnOwnerMaintenance.Click += new System.EventHandler(this.btnOwnerMaintenance_Click);
            // 
            // grpReporting
            // 
            this.grpReporting.Controls.Add(this.btnExit);
            this.grpReporting.Controls.Add(this.btnInvoices);
            this.grpReporting.Location = new System.Drawing.Point(632, 59);
            this.grpReporting.Name = "grpReporting";
            this.grpReporting.Size = new System.Drawing.Size(564, 854);
            this.grpReporting.TabIndex = 1;
            this.grpReporting.TabStop = false;
            this.grpReporting.Text = "Reporting";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(105, 706);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(356, 67);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.Location = new System.Drawing.Point(105, 68);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(356, 61);
            this.btnInvoices.TabIndex = 6;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 987);
            this.Controls.Add(this.grpReporting);
            this.Controls.Add(this.grpMaintenance);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpMaintenance.ResumeLayout(false);
            this.grpReporting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.GroupBox grpReporting;
        private System.Windows.Forms.Button btnEquipmentAllocation;
        private System.Windows.Forms.Button btnServiceMaintenance;
        private System.Windows.Forms.Button btnVehicleMaintenance;
        private System.Windows.Forms.Button btnEquipmentMaintenance;
        private System.Windows.Forms.Button btnServiceTypeMaintenance;
        private System.Windows.Forms.Button btnOwnerMaintenance;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInvoices;
    }
}

