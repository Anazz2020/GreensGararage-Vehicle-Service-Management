namespace GreensGarage
{
    partial class ServiceTypeForm
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
            this.lstServiceType = new System.Windows.Forms.ListBox();
            this.lblServiceTypeID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.txtServiceTypeID = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddServiceType = new System.Windows.Forms.Button();
            this.btnUpdateServiceType = new System.Windows.Forms.Button();
            this.btnDeleteServiceType = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAddServiceType = new System.Windows.Forms.Panel();
            this.lblAddDescription = new System.Windows.Forms.Label();
            this.lblAddHourlyRate = new System.Windows.Forms.Label();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.txtAddHourlyRate = new System.Windows.Forms.TextBox();
            this.btnSaveServiceType = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlUpdateServiceType = new System.Windows.Forms.Panel();
            this.lblUpdateServiceTypeID = new System.Windows.Forms.Label();
            this.lblUpdateDescription = new System.Windows.Forms.Label();
            this.lblUpdateHourlyRate = new System.Windows.Forms.Label();
            this.txtUpdateServiceTypeID = new System.Windows.Forms.TextBox();
            this.txtUpdateDescription = new System.Windows.Forms.TextBox();
            this.txtUpdateHourlyRate = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.pnlAddServiceType.SuspendLayout();
            this.pnlUpdateServiceType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstServiceType
            // 
            this.lstServiceType.FormattingEnabled = true;
            this.lstServiceType.ItemHeight = 25;
            this.lstServiceType.Location = new System.Drawing.Point(68, 75);
            this.lstServiceType.Name = "lstServiceType";
            this.lstServiceType.Size = new System.Drawing.Size(591, 604);
            this.lstServiceType.TabIndex = 0;
            // 
            // lblServiceTypeID
            // 
            this.lblServiceTypeID.AutoSize = true;
            this.lblServiceTypeID.Location = new System.Drawing.Point(729, 81);
            this.lblServiceTypeID.Name = "lblServiceTypeID";
            this.lblServiceTypeID.Size = new System.Drawing.Size(170, 25);
            this.lblServiceTypeID.TabIndex = 1;
            this.lblServiceTypeID.Text = "Service Type ID:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(773, 177);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(126, 25);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(768, 278);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(131, 25);
            this.lblHourlyRate.TabIndex = 3;
            this.lblHourlyRate.Text = "Hourly Rate:";
            // 
            // txtServiceTypeID
            // 
            this.txtServiceTypeID.Enabled = false;
            this.txtServiceTypeID.Location = new System.Drawing.Point(905, 75);
            this.txtServiceTypeID.Name = "txtServiceTypeID";
            this.txtServiceTypeID.Size = new System.Drawing.Size(100, 31);
            this.txtServiceTypeID.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(905, 177);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(404, 31);
            this.txtDescription.TabIndex = 5;
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Enabled = false;
            this.txtHourlyRate.Location = new System.Drawing.Point(905, 272);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(185, 31);
            this.txtHourlyRate.TabIndex = 6;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(68, 744);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(170, 49);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(287, 744);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(189, 49);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddServiceType
            // 
            this.btnAddServiceType.Location = new System.Drawing.Point(528, 744);
            this.btnAddServiceType.Name = "btnAddServiceType";
            this.btnAddServiceType.Size = new System.Drawing.Size(209, 49);
            this.btnAddServiceType.TabIndex = 9;
            this.btnAddServiceType.Text = "Add Service Type";
            this.btnAddServiceType.UseVisualStyleBackColor = true;
            this.btnAddServiceType.Click += new System.EventHandler(this.btnAddServiceType_Click);
            // 
            // btnUpdateServiceType
            // 
            this.btnUpdateServiceType.Location = new System.Drawing.Point(797, 744);
            this.btnUpdateServiceType.Name = "btnUpdateServiceType";
            this.btnUpdateServiceType.Size = new System.Drawing.Size(223, 49);
            this.btnUpdateServiceType.TabIndex = 10;
            this.btnUpdateServiceType.Text = "Update Service Type";
            this.btnUpdateServiceType.UseVisualStyleBackColor = true;
            this.btnUpdateServiceType.Click += new System.EventHandler(this.btnUpdateServiceType_Click);
            // 
            // btnDeleteServiceType
            // 
            this.btnDeleteServiceType.Location = new System.Drawing.Point(1087, 744);
            this.btnDeleteServiceType.Name = "btnDeleteServiceType";
            this.btnDeleteServiceType.Size = new System.Drawing.Size(234, 49);
            this.btnDeleteServiceType.TabIndex = 11;
            this.btnDeleteServiceType.Text = "Delete Service Type";
            this.btnDeleteServiceType.UseVisualStyleBackColor = true;
            this.btnDeleteServiceType.Click += new System.EventHandler(this.btnDeleteServiceType_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(1087, 851);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(234, 43);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlAddServiceType
            // 
            this.pnlAddServiceType.Controls.Add(this.btnCancel);
            this.pnlAddServiceType.Controls.Add(this.btnSaveServiceType);
            this.pnlAddServiceType.Controls.Add(this.txtAddHourlyRate);
            this.pnlAddServiceType.Controls.Add(this.txtAddDescription);
            this.pnlAddServiceType.Controls.Add(this.lblAddHourlyRate);
            this.pnlAddServiceType.Controls.Add(this.lblAddDescription);
            this.pnlAddServiceType.Location = new System.Drawing.Point(427, 75);
            this.pnlAddServiceType.Name = "pnlAddServiceType";
            this.pnlAddServiceType.Size = new System.Drawing.Size(882, 537);
            this.pnlAddServiceType.TabIndex = 13;
            this.pnlAddServiceType.Visible = false;
            // 
            // lblAddDescription
            // 
            this.lblAddDescription.AutoSize = true;
            this.lblAddDescription.Location = new System.Drawing.Point(83, 131);
            this.lblAddDescription.Name = "lblAddDescription";
            this.lblAddDescription.Size = new System.Drawing.Size(126, 25);
            this.lblAddDescription.TabIndex = 0;
            this.lblAddDescription.Text = "Description:";
            // 
            // lblAddHourlyRate
            // 
            this.lblAddHourlyRate.AutoSize = true;
            this.lblAddHourlyRate.Location = new System.Drawing.Point(83, 224);
            this.lblAddHourlyRate.Name = "lblAddHourlyRate";
            this.lblAddHourlyRate.Size = new System.Drawing.Size(131, 25);
            this.lblAddHourlyRate.TabIndex = 1;
            this.lblAddHourlyRate.Text = "Hourly Rate:";
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(236, 131);
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(548, 31);
            this.txtAddDescription.TabIndex = 2;
            // 
            // txtAddHourlyRate
            // 
            this.txtAddHourlyRate.Location = new System.Drawing.Point(236, 221);
            this.txtAddHourlyRate.Name = "txtAddHourlyRate";
            this.txtAddHourlyRate.Size = new System.Drawing.Size(141, 31);
            this.txtAddHourlyRate.TabIndex = 3;
            // 
            // btnSaveServiceType
            // 
            this.btnSaveServiceType.Location = new System.Drawing.Point(71, 380);
            this.btnSaveServiceType.Name = "btnSaveServiceType";
            this.btnSaveServiceType.Size = new System.Drawing.Size(220, 43);
            this.btnSaveServiceType.TabIndex = 4;
            this.btnSaveServiceType.Text = "Save Service Type";
            this.btnSaveServiceType.UseVisualStyleBackColor = true;
            this.btnSaveServiceType.Click += new System.EventHandler(this.btnSaveServiceType_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(575, 380);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(209, 43);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlUpdateServiceType
            // 
            this.pnlUpdateServiceType.Controls.Add(this.btnUpdateCancel);
            this.pnlUpdateServiceType.Controls.Add(this.btnSaveChanges);
            this.pnlUpdateServiceType.Controls.Add(this.txtUpdateHourlyRate);
            this.pnlUpdateServiceType.Controls.Add(this.txtUpdateDescription);
            this.pnlUpdateServiceType.Controls.Add(this.txtUpdateServiceTypeID);
            this.pnlUpdateServiceType.Controls.Add(this.lblUpdateHourlyRate);
            this.pnlUpdateServiceType.Controls.Add(this.lblUpdateDescription);
            this.pnlUpdateServiceType.Controls.Add(this.lblUpdateServiceTypeID);
            this.pnlUpdateServiceType.Location = new System.Drawing.Point(365, 75);
            this.pnlUpdateServiceType.Name = "pnlUpdateServiceType";
            this.pnlUpdateServiceType.Size = new System.Drawing.Size(932, 537);
            this.pnlUpdateServiceType.TabIndex = 14;
            this.pnlUpdateServiceType.Visible = false;
            // 
            // lblUpdateServiceTypeID
            // 
            this.lblUpdateServiceTypeID.AutoSize = true;
            this.lblUpdateServiceTypeID.Location = new System.Drawing.Point(125, 68);
            this.lblUpdateServiceTypeID.Name = "lblUpdateServiceTypeID";
            this.lblUpdateServiceTypeID.Size = new System.Drawing.Size(170, 25);
            this.lblUpdateServiceTypeID.TabIndex = 0;
            this.lblUpdateServiceTypeID.Text = "Service Type ID:";
            // 
            // lblUpdateDescription
            // 
            this.lblUpdateDescription.AutoSize = true;
            this.lblUpdateDescription.Location = new System.Drawing.Point(169, 150);
            this.lblUpdateDescription.Name = "lblUpdateDescription";
            this.lblUpdateDescription.Size = new System.Drawing.Size(126, 25);
            this.lblUpdateDescription.TabIndex = 1;
            this.lblUpdateDescription.Text = "Description:";
            // 
            // lblUpdateHourlyRate
            // 
            this.lblUpdateHourlyRate.AutoSize = true;
            this.lblUpdateHourlyRate.Location = new System.Drawing.Point(164, 245);
            this.lblUpdateHourlyRate.Name = "lblUpdateHourlyRate";
            this.lblUpdateHourlyRate.Size = new System.Drawing.Size(131, 25);
            this.lblUpdateHourlyRate.TabIndex = 2;
            this.lblUpdateHourlyRate.Text = "Hourly Rate:";
            // 
            // txtUpdateServiceTypeID
            // 
            this.txtUpdateServiceTypeID.Enabled = false;
            this.txtUpdateServiceTypeID.Location = new System.Drawing.Point(308, 63);
            this.txtUpdateServiceTypeID.Name = "txtUpdateServiceTypeID";
            this.txtUpdateServiceTypeID.Size = new System.Drawing.Size(87, 31);
            this.txtUpdateServiceTypeID.TabIndex = 3;
            // 
            // txtUpdateDescription
            // 
            this.txtUpdateDescription.Location = new System.Drawing.Point(308, 144);
            this.txtUpdateDescription.Name = "txtUpdateDescription";
            this.txtUpdateDescription.Size = new System.Drawing.Size(525, 31);
            this.txtUpdateDescription.TabIndex = 4;
            // 
            // txtUpdateHourlyRate
            // 
            this.txtUpdateHourlyRate.Location = new System.Drawing.Point(308, 239);
            this.txtUpdateHourlyRate.Name = "txtUpdateHourlyRate";
            this.txtUpdateHourlyRate.Size = new System.Drawing.Size(165, 31);
            this.txtUpdateHourlyRate.TabIndex = 5;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(130, 408);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(206, 47);
            this.btnSaveChanges.TabIndex = 6;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(625, 408);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(208, 51);
            this.btnUpdateCancel.TabIndex = 7;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // ServiceTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 953);
            this.Controls.Add(this.pnlUpdateServiceType);
            this.Controls.Add(this.pnlAddServiceType);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteServiceType);
            this.Controls.Add(this.btnUpdateServiceType);
            this.Controls.Add(this.btnAddServiceType);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtServiceTypeID);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblServiceTypeID);
            this.Controls.Add(this.lstServiceType);
            this.Name = "ServiceTypeForm";
            this.Text = "Service Type Maintenance";
            this.Load += new System.EventHandler(this.ServiceTypeForm_Load);
            this.pnlAddServiceType.ResumeLayout(false);
            this.pnlAddServiceType.PerformLayout();
            this.pnlUpdateServiceType.ResumeLayout(false);
            this.pnlUpdateServiceType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstServiceType;
        private System.Windows.Forms.Label lblServiceTypeID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.TextBox txtServiceTypeID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddServiceType;
        private System.Windows.Forms.Button btnUpdateServiceType;
        private System.Windows.Forms.Button btnDeleteServiceType;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlAddServiceType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveServiceType;
        private System.Windows.Forms.TextBox txtAddHourlyRate;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.Label lblAddHourlyRate;
        private System.Windows.Forms.Label lblAddDescription;
        private System.Windows.Forms.Panel pnlUpdateServiceType;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtUpdateHourlyRate;
        private System.Windows.Forms.TextBox txtUpdateDescription;
        private System.Windows.Forms.TextBox txtUpdateServiceTypeID;
        private System.Windows.Forms.Label lblUpdateHourlyRate;
        private System.Windows.Forms.Label lblUpdateDescription;
        private System.Windows.Forms.Label lblUpdateServiceTypeID;
    }
}