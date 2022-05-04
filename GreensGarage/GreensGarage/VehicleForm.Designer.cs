namespace GreensGarage
{
    partial class VehicleForm
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
            this.lstVehicle = new System.Windows.Forms.ListBox();
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.lblPlateNumber = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblOwnerID = new System.Windows.Forms.Label();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.txtVehicleID = new System.Windows.Forms.TextBox();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtOwnerID = new System.Windows.Forms.TextBox();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnUpdateVehicle = new System.Windows.Forms.Button();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAddVehicle = new System.Windows.Forms.Panel();
            this.cboOwnerName = new System.Windows.Forms.ComboBox();
            this.cboOwnerID = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveVehicle = new System.Windows.Forms.Button();
            this.txtAddModel = new System.Windows.Forms.TextBox();
            this.txtAddMake = new System.Windows.Forms.TextBox();
            this.txtAddPlateNumber = new System.Windows.Forms.TextBox();
            this.txtAddVehicleID = new System.Windows.Forms.TextBox();
            this.lblAddOwner = new System.Windows.Forms.Label();
            this.lblAddModel = new System.Windows.Forms.Label();
            this.lblAddMake = new System.Windows.Forms.Label();
            this.lblAddPlateNumber = new System.Windows.Forms.Label();
            this.lblAddVehicleID = new System.Windows.Forms.Label();
            this.pnlUpdateVehicle = new System.Windows.Forms.Panel();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtUpdateOwnerName = new System.Windows.Forms.TextBox();
            this.txtUpdateModel = new System.Windows.Forms.TextBox();
            this.txtUpdateMake = new System.Windows.Forms.TextBox();
            this.txtUpdatePlateNumber = new System.Windows.Forms.TextBox();
            this.txtUpdateVehicleID = new System.Windows.Forms.TextBox();
            this.lblUpdateOwnerName = new System.Windows.Forms.Label();
            this.lblUpdateModel = new System.Windows.Forms.Label();
            this.lblUpdateMake = new System.Windows.Forms.Label();
            this.lblUpdatePlateNumber = new System.Windows.Forms.Label();
            this.lblUpdateVehicleID = new System.Windows.Forms.Label();
            this.pnlAddVehicle.SuspendLayout();
            this.pnlUpdateVehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstVehicle
            // 
            this.lstVehicle.FormattingEnabled = true;
            this.lstVehicle.ItemHeight = 25;
            this.lstVehicle.Location = new System.Drawing.Point(42, 44);
            this.lstVehicle.Name = "lstVehicle";
            this.lstVehicle.Size = new System.Drawing.Size(489, 654);
            this.lstVehicle.TabIndex = 0;
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.AutoSize = true;
            this.lblVehicleID.Location = new System.Drawing.Point(621, 74);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(115, 25);
            this.lblVehicleID.TabIndex = 1;
            this.lblVehicleID.Text = "Vehicle ID:";
            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Location = new System.Drawing.Point(588, 187);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(148, 25);
            this.lblPlateNumber.TabIndex = 2;
            this.lblPlateNumber.Text = "Plate Number:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(665, 293);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(71, 25);
            this.lblMake.TabIndex = 3;
            this.lblMake.Text = "Make:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(659, 401);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(77, 25);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Model:";
            // 
            // lblOwnerID
            // 
            this.lblOwnerID.AutoSize = true;
            this.lblOwnerID.Location = new System.Drawing.Point(630, 513);
            this.lblOwnerID.Name = "lblOwnerID";
            this.lblOwnerID.Size = new System.Drawing.Size(106, 25);
            this.lblOwnerID.TabIndex = 5;
            this.lblOwnerID.Text = "Owner ID:";
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Location = new System.Drawing.Point(594, 611);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(142, 25);
            this.lblOwnerName.TabIndex = 6;
            this.lblOwnerName.Text = "Owner Name:";
            // 
            // txtVehicleID
            // 
            this.txtVehicleID.Enabled = false;
            this.txtVehicleID.Location = new System.Drawing.Point(748, 71);
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.Size = new System.Drawing.Size(100, 31);
            this.txtVehicleID.TabIndex = 7;
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Enabled = false;
            this.txtPlateNumber.Location = new System.Drawing.Point(748, 187);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(214, 31);
            this.txtPlateNumber.TabIndex = 8;
            // 
            // txtMake
            // 
            this.txtMake.Enabled = false;
            this.txtMake.Location = new System.Drawing.Point(748, 290);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(385, 31);
            this.txtMake.TabIndex = 9;
            // 
            // txtModel
            // 
            this.txtModel.Enabled = false;
            this.txtModel.Location = new System.Drawing.Point(748, 401);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(385, 31);
            this.txtModel.TabIndex = 10;
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.Enabled = false;
            this.txtOwnerID.Location = new System.Drawing.Point(748, 507);
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.Size = new System.Drawing.Size(100, 31);
            this.txtOwnerID.TabIndex = 11;
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Enabled = false;
            this.txtOwnerName.Location = new System.Drawing.Point(748, 608);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(385, 31);
            this.txtOwnerName.TabIndex = 12;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(79, 776);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(167, 44);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(311, 776);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(153, 44);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(542, 776);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(163, 44);
            this.btnAddVehicle.TabIndex = 15;
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // btnUpdateVehicle
            // 
            this.btnUpdateVehicle.Location = new System.Drawing.Point(776, 776);
            this.btnUpdateVehicle.Name = "btnUpdateVehicle";
            this.btnUpdateVehicle.Size = new System.Drawing.Size(173, 44);
            this.btnUpdateVehicle.TabIndex = 16;
            this.btnUpdateVehicle.Text = "Update Vehicle";
            this.btnUpdateVehicle.UseVisualStyleBackColor = true;
            this.btnUpdateVehicle.Click += new System.EventHandler(this.btnUpdateVehicle_Click);
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.Location = new System.Drawing.Point(1020, 776);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(177, 44);
            this.btnDeleteVehicle.TabIndex = 17;
            this.btnDeleteVehicle.Text = "Delete Vehicle";
            this.btnDeleteVehicle.UseVisualStyleBackColor = true;
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(1020, 890);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(177, 48);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlAddVehicle
            // 
            this.pnlAddVehicle.Controls.Add(this.cboOwnerName);
            this.pnlAddVehicle.Controls.Add(this.cboOwnerID);
            this.pnlAddVehicle.Controls.Add(this.btnCancel);
            this.pnlAddVehicle.Controls.Add(this.btnSaveVehicle);
            this.pnlAddVehicle.Controls.Add(this.txtAddModel);
            this.pnlAddVehicle.Controls.Add(this.txtAddMake);
            this.pnlAddVehicle.Controls.Add(this.txtAddPlateNumber);
            this.pnlAddVehicle.Controls.Add(this.txtAddVehicleID);
            this.pnlAddVehicle.Controls.Add(this.lblAddOwner);
            this.pnlAddVehicle.Controls.Add(this.lblAddModel);
            this.pnlAddVehicle.Controls.Add(this.lblAddMake);
            this.pnlAddVehicle.Controls.Add(this.lblAddPlateNumber);
            this.pnlAddVehicle.Controls.Add(this.lblAddVehicleID);
            this.pnlAddVehicle.Location = new System.Drawing.Point(343, 44);
            this.pnlAddVehicle.Name = "pnlAddVehicle";
            this.pnlAddVehicle.Size = new System.Drawing.Size(854, 649);
            this.pnlAddVehicle.TabIndex = 19;
            this.pnlAddVehicle.Visible = false;
            // 
            // cboOwnerName
            // 
            this.cboOwnerName.FormattingEnabled = true;
            this.cboOwnerName.Location = new System.Drawing.Point(560, 444);
            this.cboOwnerName.Name = "cboOwnerName";
            this.cboOwnerName.Size = new System.Drawing.Size(230, 33);
            this.cboOwnerName.TabIndex = 12;
            // 
            // cboOwnerID
            // 
            this.cboOwnerID.FormattingEnabled = true;
            this.cboOwnerID.Location = new System.Drawing.Point(453, 444);
            this.cboOwnerID.Name = "cboOwnerID";
            this.cboOwnerID.Size = new System.Drawing.Size(100, 33);
            this.cboOwnerID.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(579, 544);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(182, 48);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveVehicle
            // 
            this.btnSaveVehicle.Location = new System.Drawing.Point(212, 547);
            this.btnSaveVehicle.Name = "btnSaveVehicle";
            this.btnSaveVehicle.Size = new System.Drawing.Size(189, 48);
            this.btnSaveVehicle.TabIndex = 9;
            this.btnSaveVehicle.Text = "Save Vehicle";
            this.btnSaveVehicle.UseVisualStyleBackColor = true;
            this.btnSaveVehicle.Click += new System.EventHandler(this.btnSaveVehicle_Click);
            // 
            // txtAddModel
            // 
            this.txtAddModel.Location = new System.Drawing.Point(453, 339);
            this.txtAddModel.Name = "txtAddModel";
            this.txtAddModel.Size = new System.Drawing.Size(337, 31);
            this.txtAddModel.TabIndex = 8;
            // 
            // txtAddMake
            // 
            this.txtAddMake.Location = new System.Drawing.Point(453, 232);
            this.txtAddMake.Name = "txtAddMake";
            this.txtAddMake.Size = new System.Drawing.Size(337, 31);
            this.txtAddMake.TabIndex = 7;
            // 
            // txtAddPlateNumber
            // 
            this.txtAddPlateNumber.Location = new System.Drawing.Point(453, 134);
            this.txtAddPlateNumber.Name = "txtAddPlateNumber";
            this.txtAddPlateNumber.Size = new System.Drawing.Size(184, 31);
            this.txtAddPlateNumber.TabIndex = 6;
            // 
            // txtAddVehicleID
            // 
            this.txtAddVehicleID.Enabled = false;
            this.txtAddVehicleID.Location = new System.Drawing.Point(453, 49);
            this.txtAddVehicleID.Name = "txtAddVehicleID";
            this.txtAddVehicleID.Size = new System.Drawing.Size(100, 31);
            this.txtAddVehicleID.TabIndex = 5;
            // 
            // lblAddOwner
            // 
            this.lblAddOwner.AutoSize = true;
            this.lblAddOwner.Location = new System.Drawing.Point(313, 444);
            this.lblAddOwner.Name = "lblAddOwner";
            this.lblAddOwner.Size = new System.Drawing.Size(80, 25);
            this.lblAddOwner.TabIndex = 4;
            this.lblAddOwner.Text = "Owner:";
            // 
            // lblAddModel
            // 
            this.lblAddModel.AutoSize = true;
            this.lblAddModel.Location = new System.Drawing.Point(316, 339);
            this.lblAddModel.Name = "lblAddModel";
            this.lblAddModel.Size = new System.Drawing.Size(77, 25);
            this.lblAddModel.TabIndex = 3;
            this.lblAddModel.Text = "Model:";
            // 
            // lblAddMake
            // 
            this.lblAddMake.AutoSize = true;
            this.lblAddMake.Location = new System.Drawing.Point(322, 224);
            this.lblAddMake.Name = "lblAddMake";
            this.lblAddMake.Size = new System.Drawing.Size(71, 25);
            this.lblAddMake.TabIndex = 2;
            this.lblAddMake.Text = "Make:";
            // 
            // lblAddPlateNumber
            // 
            this.lblAddPlateNumber.AutoSize = true;
            this.lblAddPlateNumber.Location = new System.Drawing.Point(245, 137);
            this.lblAddPlateNumber.Name = "lblAddPlateNumber";
            this.lblAddPlateNumber.Size = new System.Drawing.Size(148, 25);
            this.lblAddPlateNumber.TabIndex = 1;
            this.lblAddPlateNumber.Text = "Plate Number:";
            // 
            // lblAddVehicleID
            // 
            this.lblAddVehicleID.AutoSize = true;
            this.lblAddVehicleID.Location = new System.Drawing.Point(278, 55);
            this.lblAddVehicleID.Name = "lblAddVehicleID";
            this.lblAddVehicleID.Size = new System.Drawing.Size(115, 25);
            this.lblAddVehicleID.TabIndex = 0;
            this.lblAddVehicleID.Text = "Vehicle ID:";
            // 
            // pnlUpdateVehicle
            // 
            this.pnlUpdateVehicle.Controls.Add(this.btnUpdateCancel);
            this.pnlUpdateVehicle.Controls.Add(this.btnSaveChanges);
            this.pnlUpdateVehicle.Controls.Add(this.txtUpdateOwnerName);
            this.pnlUpdateVehicle.Controls.Add(this.txtUpdateModel);
            this.pnlUpdateVehicle.Controls.Add(this.txtUpdateMake);
            this.pnlUpdateVehicle.Controls.Add(this.txtUpdatePlateNumber);
            this.pnlUpdateVehicle.Controls.Add(this.txtUpdateVehicleID);
            this.pnlUpdateVehicle.Controls.Add(this.lblUpdateOwnerName);
            this.pnlUpdateVehicle.Controls.Add(this.lblUpdateModel);
            this.pnlUpdateVehicle.Controls.Add(this.lblUpdateMake);
            this.pnlUpdateVehicle.Controls.Add(this.lblUpdatePlateNumber);
            this.pnlUpdateVehicle.Controls.Add(this.lblUpdateVehicleID);
            this.pnlUpdateVehicle.Location = new System.Drawing.Point(346, 44);
            this.pnlUpdateVehicle.Name = "pnlUpdateVehicle";
            this.pnlUpdateVehicle.Size = new System.Drawing.Size(832, 605);
            this.pnlUpdateVehicle.TabIndex = 20;
            this.pnlUpdateVehicle.Visible = false;
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(610, 503);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(164, 40);
            this.btnUpdateCancel.TabIndex = 11;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(283, 503);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(162, 40);
            this.btnSaveChanges.TabIndex = 10;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtUpdateOwnerName
            // 
            this.txtUpdateOwnerName.Enabled = false;
            this.txtUpdateOwnerName.Location = new System.Drawing.Point(467, 399);
            this.txtUpdateOwnerName.Name = "txtUpdateOwnerName";
            this.txtUpdateOwnerName.Size = new System.Drawing.Size(323, 31);
            this.txtUpdateOwnerName.TabIndex = 9;
            // 
            // txtUpdateModel
            // 
            this.txtUpdateModel.Location = new System.Drawing.Point(467, 296);
            this.txtUpdateModel.Name = "txtUpdateModel";
            this.txtUpdateModel.Size = new System.Drawing.Size(294, 31);
            this.txtUpdateModel.TabIndex = 8;
            // 
            // txtUpdateMake
            // 
            this.txtUpdateMake.Location = new System.Drawing.Point(467, 205);
            this.txtUpdateMake.Name = "txtUpdateMake";
            this.txtUpdateMake.Size = new System.Drawing.Size(294, 31);
            this.txtUpdateMake.TabIndex = 7;
            // 
            // txtUpdatePlateNumber
            // 
            this.txtUpdatePlateNumber.Location = new System.Drawing.Point(467, 110);
            this.txtUpdatePlateNumber.Name = "txtUpdatePlateNumber";
            this.txtUpdatePlateNumber.Size = new System.Drawing.Size(185, 31);
            this.txtUpdatePlateNumber.TabIndex = 6;
            // 
            // txtUpdateVehicleID
            // 
            this.txtUpdateVehicleID.Enabled = false;
            this.txtUpdateVehicleID.Location = new System.Drawing.Point(467, 22);
            this.txtUpdateVehicleID.Name = "txtUpdateVehicleID";
            this.txtUpdateVehicleID.Size = new System.Drawing.Size(101, 31);
            this.txtUpdateVehicleID.TabIndex = 5;
            // 
            // lblUpdateOwnerName
            // 
            this.lblUpdateOwnerName.AutoSize = true;
            this.lblUpdateOwnerName.Location = new System.Drawing.Point(319, 405);
            this.lblUpdateOwnerName.Name = "lblUpdateOwnerName";
            this.lblUpdateOwnerName.Size = new System.Drawing.Size(142, 25);
            this.lblUpdateOwnerName.TabIndex = 4;
            this.lblUpdateOwnerName.Text = "Owner Name:";
            // 
            // lblUpdateModel
            // 
            this.lblUpdateModel.AutoSize = true;
            this.lblUpdateModel.Location = new System.Drawing.Point(384, 302);
            this.lblUpdateModel.Name = "lblUpdateModel";
            this.lblUpdateModel.Size = new System.Drawing.Size(77, 25);
            this.lblUpdateModel.TabIndex = 3;
            this.lblUpdateModel.Text = "Model:";
            // 
            // lblUpdateMake
            // 
            this.lblUpdateMake.AutoSize = true;
            this.lblUpdateMake.Location = new System.Drawing.Point(390, 205);
            this.lblUpdateMake.Name = "lblUpdateMake";
            this.lblUpdateMake.Size = new System.Drawing.Size(71, 25);
            this.lblUpdateMake.TabIndex = 2;
            this.lblUpdateMake.Text = "Make:";
            // 
            // lblUpdatePlateNumber
            // 
            this.lblUpdatePlateNumber.AutoSize = true;
            this.lblUpdatePlateNumber.Location = new System.Drawing.Point(313, 113);
            this.lblUpdatePlateNumber.Name = "lblUpdatePlateNumber";
            this.lblUpdatePlateNumber.Size = new System.Drawing.Size(148, 25);
            this.lblUpdatePlateNumber.TabIndex = 1;
            this.lblUpdatePlateNumber.Text = "Plate Number:";
            // 
            // lblUpdateVehicleID
            // 
            this.lblUpdateVehicleID.AutoSize = true;
            this.lblUpdateVehicleID.Location = new System.Drawing.Point(346, 28);
            this.lblUpdateVehicleID.Name = "lblUpdateVehicleID";
            this.lblUpdateVehicleID.Size = new System.Drawing.Size(115, 25);
            this.lblUpdateVehicleID.TabIndex = 0;
            this.lblUpdateVehicleID.Text = "Vehicle ID:";
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 988);
            this.Controls.Add(this.pnlUpdateVehicle);
            this.Controls.Add(this.pnlAddVehicle);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteVehicle);
            this.Controls.Add(this.btnUpdateVehicle);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtOwnerName);
            this.Controls.Add(this.txtOwnerID);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtPlateNumber);
            this.Controls.Add(this.txtVehicleID);
            this.Controls.Add(this.lblOwnerName);
            this.Controls.Add(this.lblOwnerID);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblPlateNumber);
            this.Controls.Add(this.lblVehicleID);
            this.Controls.Add(this.lstVehicle);
            this.Name = "VehicleForm";
            this.Text = "Vehicle Maintenance";
            this.pnlAddVehicle.ResumeLayout(false);
            this.pnlAddVehicle.PerformLayout();
            this.pnlUpdateVehicle.ResumeLayout(false);
            this.pnlUpdateVehicle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVehicle;
        private System.Windows.Forms.Label lblVehicleID;
        private System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblOwnerID;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.TextBox txtVehicleID;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtOwnerID;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnUpdateVehicle;
        private System.Windows.Forms.Button btnDeleteVehicle;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlAddVehicle;
        private System.Windows.Forms.Label lblAddOwner;
        private System.Windows.Forms.Label lblAddModel;
        private System.Windows.Forms.Label lblAddMake;
        private System.Windows.Forms.Label lblAddPlateNumber;
        private System.Windows.Forms.Label lblAddVehicleID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveVehicle;
        private System.Windows.Forms.TextBox txtAddModel;
        private System.Windows.Forms.TextBox txtAddMake;
        private System.Windows.Forms.TextBox txtAddPlateNumber;
        private System.Windows.Forms.TextBox txtAddVehicleID;
        private System.Windows.Forms.ComboBox cboOwnerID;
        private System.Windows.Forms.ComboBox cboOwnerName;
        private System.Windows.Forms.Panel pnlUpdateVehicle;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtUpdateOwnerName;
        private System.Windows.Forms.TextBox txtUpdateModel;
        private System.Windows.Forms.TextBox txtUpdateMake;
        private System.Windows.Forms.TextBox txtUpdatePlateNumber;
        private System.Windows.Forms.TextBox txtUpdateVehicleID;
        private System.Windows.Forms.Label lblUpdateOwnerName;
        private System.Windows.Forms.Label lblUpdateModel;
        private System.Windows.Forms.Label lblUpdateMake;
        private System.Windows.Forms.Label lblUpdatePlateNumber;
        private System.Windows.Forms.Label lblUpdateVehicleID;
    }
}