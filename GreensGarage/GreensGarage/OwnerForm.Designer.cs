namespace GreensGarage
{
    partial class OwnerForm
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
            this.lstOwners = new System.Windows.Forms.ListBox();
            this.lblOwnerID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtOwnerID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddOwner = new System.Windows.Forms.Button();
            this.btnUpdateOwner = new System.Windows.Forms.Button();
            this.btnDeleteOwner = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblAddLastName = new System.Windows.Forms.Label();
            this.lblAddFirstName = new System.Windows.Forms.Label();
            this.lblAddStreetAddress = new System.Windows.Forms.Label();
            this.lblAddSuburb = new System.Windows.Forms.Label();
            this.lblAddPhoneNumber = new System.Windows.Forms.Label();
            this.txtAddLastName = new System.Windows.Forms.TextBox();
            this.txtAddFirstName = new System.Windows.Forms.TextBox();
            this.txtAddStreetAddress = new System.Windows.Forms.TextBox();
            this.txtAddSuburb = new System.Windows.Forms.TextBox();
            this.txtAddPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnSaveOwner = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlAddOwner = new System.Windows.Forms.Panel();
            this.pnlUpdateOwner = new System.Windows.Forms.Panel();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtUpdatePhoneNumber = new System.Windows.Forms.TextBox();
            this.txtUpdateSuburb = new System.Windows.Forms.TextBox();
            this.txtUpdateStreetAddress = new System.Windows.Forms.TextBox();
            this.txtUpdateFirstName = new System.Windows.Forms.TextBox();
            this.txtUpdateLastName = new System.Windows.Forms.TextBox();
            this.lblUpdatePhoneNumber = new System.Windows.Forms.Label();
            this.lblUpdateSuburb = new System.Windows.Forms.Label();
            this.lblUpdateStreetAddress = new System.Windows.Forms.Label();
            this.lblUpdateFirstName = new System.Windows.Forms.Label();
            this.lblUpdateLastName = new System.Windows.Forms.Label();
            this.pnlAddOwner.SuspendLayout();
            this.pnlUpdateOwner.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstOwners
            // 
            this.lstOwners.FormattingEnabled = true;
            this.lstOwners.ItemHeight = 25;
            this.lstOwners.Location = new System.Drawing.Point(27, 30);
            this.lstOwners.Name = "lstOwners";
            this.lstOwners.Size = new System.Drawing.Size(449, 629);
            this.lstOwners.TabIndex = 0;
            // 
            // lblOwnerID
            // 
            this.lblOwnerID.AutoSize = true;
            this.lblOwnerID.Location = new System.Drawing.Point(587, 54);
            this.lblOwnerID.Name = "lblOwnerID";
            this.lblOwnerID.Size = new System.Drawing.Size(106, 25);
            this.lblOwnerID.TabIndex = 1;
            this.lblOwnerID.Text = "Owner ID:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(572, 125);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(121, 25);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(571, 212);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(122, 25);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(533, 288);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(160, 25);
            this.lblStreetAddress.TabIndex = 4;
            this.lblStreetAddress.Text = "Street Address:";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(606, 371);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(87, 25);
            this.lblSuburb.TabIndex = 5;
            this.lblSuburb.Text = "Suburb:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(532, 463);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(161, 25);
            this.lblPhoneNumber.TabIndex = 6;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.Enabled = false;
            this.txtOwnerID.Location = new System.Drawing.Point(710, 54);
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.Size = new System.Drawing.Size(100, 31);
            this.txtOwnerID.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(710, 125);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(279, 31);
            this.txtLastName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(710, 206);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(279, 31);
            this.txtFirstName.TabIndex = 9;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Enabled = false;
            this.txtStreetAddress.Location = new System.Drawing.Point(710, 288);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(424, 31);
            this.txtStreetAddress.TabIndex = 10;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Enabled = false;
            this.txtSuburb.Location = new System.Drawing.Point(710, 371);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(167, 31);
            this.txtSuburb.TabIndex = 11;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Enabled = false;
            this.txtPhoneNumber.Location = new System.Drawing.Point(710, 463);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(205, 31);
            this.txtPhoneNumber.TabIndex = 12;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(27, 693);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(146, 48);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(232, 695);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(142, 46);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddOwner
            // 
            this.btnAddOwner.Location = new System.Drawing.Point(444, 693);
            this.btnAddOwner.Name = "btnAddOwner";
            this.btnAddOwner.Size = new System.Drawing.Size(185, 48);
            this.btnAddOwner.TabIndex = 15;
            this.btnAddOwner.Text = "Add Owner";
            this.btnAddOwner.UseVisualStyleBackColor = true;
            this.btnAddOwner.Click += new System.EventHandler(this.btnAddOwner_Click);
            // 
            // btnUpdateOwner
            // 
            this.btnUpdateOwner.Location = new System.Drawing.Point(710, 693);
            this.btnUpdateOwner.Name = "btnUpdateOwner";
            this.btnUpdateOwner.Size = new System.Drawing.Size(167, 50);
            this.btnUpdateOwner.TabIndex = 16;
            this.btnUpdateOwner.Text = "Update Owner";
            this.btnUpdateOwner.UseVisualStyleBackColor = true;
            this.btnUpdateOwner.Click += new System.EventHandler(this.btnUpdateOwner_Click);
            // 
            // btnDeleteOwner
            // 
            this.btnDeleteOwner.Location = new System.Drawing.Point(967, 693);
            this.btnDeleteOwner.Name = "btnDeleteOwner";
            this.btnDeleteOwner.Size = new System.Drawing.Size(167, 50);
            this.btnDeleteOwner.TabIndex = 17;
            this.btnDeleteOwner.Text = "Delete Owner";
            this.btnDeleteOwner.UseVisualStyleBackColor = true;
            this.btnDeleteOwner.Click += new System.EventHandler(this.btnDeleteOwner_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(967, 791);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(167, 49);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblAddLastName
            // 
            this.lblAddLastName.AutoSize = true;
            this.lblAddLastName.Location = new System.Drawing.Point(63, 60);
            this.lblAddLastName.Name = "lblAddLastName";
            this.lblAddLastName.Size = new System.Drawing.Size(121, 25);
            this.lblAddLastName.TabIndex = 0;
            this.lblAddLastName.Text = "Last Name:";
            // 
            // lblAddFirstName
            // 
            this.lblAddFirstName.AutoSize = true;
            this.lblAddFirstName.Location = new System.Drawing.Point(63, 134);
            this.lblAddFirstName.Name = "lblAddFirstName";
            this.lblAddFirstName.Size = new System.Drawing.Size(122, 25);
            this.lblAddFirstName.TabIndex = 1;
            this.lblAddFirstName.Text = "First Name:";
            // 
            // lblAddStreetAddress
            // 
            this.lblAddStreetAddress.AutoSize = true;
            this.lblAddStreetAddress.Location = new System.Drawing.Point(25, 207);
            this.lblAddStreetAddress.Name = "lblAddStreetAddress";
            this.lblAddStreetAddress.Size = new System.Drawing.Size(160, 25);
            this.lblAddStreetAddress.TabIndex = 2;
            this.lblAddStreetAddress.Text = "Street Address:";
            // 
            // lblAddSuburb
            // 
            this.lblAddSuburb.AutoSize = true;
            this.lblAddSuburb.Location = new System.Drawing.Point(97, 283);
            this.lblAddSuburb.Name = "lblAddSuburb";
            this.lblAddSuburb.Size = new System.Drawing.Size(87, 25);
            this.lblAddSuburb.TabIndex = 3;
            this.lblAddSuburb.Text = "Suburb:";
            // 
            // lblAddPhoneNumber
            // 
            this.lblAddPhoneNumber.AutoSize = true;
            this.lblAddPhoneNumber.Location = new System.Drawing.Point(23, 366);
            this.lblAddPhoneNumber.Name = "lblAddPhoneNumber";
            this.lblAddPhoneNumber.Size = new System.Drawing.Size(161, 25);
            this.lblAddPhoneNumber.TabIndex = 4;
            this.lblAddPhoneNumber.Text = "Phone Number:";
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.Location = new System.Drawing.Point(201, 61);
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.Size = new System.Drawing.Size(304, 31);
            this.txtAddLastName.TabIndex = 5;
            // 
            // txtAddFirstName
            // 
            this.txtAddFirstName.Location = new System.Drawing.Point(201, 128);
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.Size = new System.Drawing.Size(304, 31);
            this.txtAddFirstName.TabIndex = 6;
            // 
            // txtAddStreetAddress
            // 
            this.txtAddStreetAddress.Location = new System.Drawing.Point(201, 204);
            this.txtAddStreetAddress.Name = "txtAddStreetAddress";
            this.txtAddStreetAddress.Size = new System.Drawing.Size(399, 31);
            this.txtAddStreetAddress.TabIndex = 7;
            // 
            // txtAddSuburb
            // 
            this.txtAddSuburb.Location = new System.Drawing.Point(201, 277);
            this.txtAddSuburb.Name = "txtAddSuburb";
            this.txtAddSuburb.Size = new System.Drawing.Size(174, 31);
            this.txtAddSuburb.TabIndex = 8;
            // 
            // txtAddPhoneNumber
            // 
            this.txtAddPhoneNumber.Location = new System.Drawing.Point(201, 363);
            this.txtAddPhoneNumber.Name = "txtAddPhoneNumber";
            this.txtAddPhoneNumber.Size = new System.Drawing.Size(226, 31);
            this.txtAddPhoneNumber.TabIndex = 9;
            // 
            // btnSaveOwner
            // 
            this.btnSaveOwner.Location = new System.Drawing.Point(52, 500);
            this.btnSaveOwner.Name = "btnSaveOwner";
            this.btnSaveOwner.Size = new System.Drawing.Size(177, 47);
            this.btnSaveOwner.TabIndex = 10;
            this.btnSaveOwner.Text = "Save Owner";
            this.btnSaveOwner.UseVisualStyleBackColor = true;
            this.btnSaveOwner.Click += new System.EventHandler(this.btnSaveOwner_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(425, 500);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 47);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlAddOwner
            // 
            this.pnlAddOwner.Controls.Add(this.btnCancel);
            this.pnlAddOwner.Controls.Add(this.btnSaveOwner);
            this.pnlAddOwner.Controls.Add(this.txtAddPhoneNumber);
            this.pnlAddOwner.Controls.Add(this.txtAddSuburb);
            this.pnlAddOwner.Controls.Add(this.txtAddStreetAddress);
            this.pnlAddOwner.Controls.Add(this.txtAddFirstName);
            this.pnlAddOwner.Controls.Add(this.txtAddLastName);
            this.pnlAddOwner.Controls.Add(this.lblAddPhoneNumber);
            this.pnlAddOwner.Controls.Add(this.lblAddSuburb);
            this.pnlAddOwner.Controls.Add(this.lblAddStreetAddress);
            this.pnlAddOwner.Controls.Add(this.lblAddFirstName);
            this.pnlAddOwner.Controls.Add(this.lblAddLastName);
            this.pnlAddOwner.Location = new System.Drawing.Point(494, 30);
            this.pnlAddOwner.Name = "pnlAddOwner";
            this.pnlAddOwner.Size = new System.Drawing.Size(653, 587);
            this.pnlAddOwner.TabIndex = 19;
            this.pnlAddOwner.Visible = false;
            // 
            // pnlUpdateOwner
            // 
            this.pnlUpdateOwner.Controls.Add(this.btnCancelUpdate);
            this.pnlUpdateOwner.Controls.Add(this.btnSaveChanges);
            this.pnlUpdateOwner.Controls.Add(this.txtUpdatePhoneNumber);
            this.pnlUpdateOwner.Controls.Add(this.txtUpdateSuburb);
            this.pnlUpdateOwner.Controls.Add(this.txtUpdateStreetAddress);
            this.pnlUpdateOwner.Controls.Add(this.txtUpdateFirstName);
            this.pnlUpdateOwner.Controls.Add(this.txtUpdateLastName);
            this.pnlUpdateOwner.Controls.Add(this.lblUpdatePhoneNumber);
            this.pnlUpdateOwner.Controls.Add(this.lblUpdateSuburb);
            this.pnlUpdateOwner.Controls.Add(this.lblUpdateStreetAddress);
            this.pnlUpdateOwner.Controls.Add(this.lblUpdateFirstName);
            this.pnlUpdateOwner.Controls.Add(this.lblUpdateLastName);
            this.pnlUpdateOwner.Location = new System.Drawing.Point(503, 91);
            this.pnlUpdateOwner.Name = "pnlUpdateOwner";
            this.pnlUpdateOwner.Size = new System.Drawing.Size(647, 539);
            this.pnlUpdateOwner.TabIndex = 12;
            this.pnlUpdateOwner.Visible = false;
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Location = new System.Drawing.Point(464, 467);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(167, 41);
            this.btnCancelUpdate.TabIndex = 12;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(59, 461);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(194, 47);
            this.btnSaveChanges.TabIndex = 11;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtUpdatePhoneNumber
            // 
            this.txtUpdatePhoneNumber.Location = new System.Drawing.Point(207, 339);
            this.txtUpdatePhoneNumber.Name = "txtUpdatePhoneNumber";
            this.txtUpdatePhoneNumber.Size = new System.Drawing.Size(228, 31);
            this.txtUpdatePhoneNumber.TabIndex = 10;
            // 
            // txtUpdateSuburb
            // 
            this.txtUpdateSuburb.Location = new System.Drawing.Point(207, 261);
            this.txtUpdateSuburb.Name = "txtUpdateSuburb";
            this.txtUpdateSuburb.Size = new System.Drawing.Size(159, 31);
            this.txtUpdateSuburb.TabIndex = 9;
            // 
            // txtUpdateStreetAddress
            // 
            this.txtUpdateStreetAddress.Location = new System.Drawing.Point(207, 180);
            this.txtUpdateStreetAddress.Name = "txtUpdateStreetAddress";
            this.txtUpdateStreetAddress.Size = new System.Drawing.Size(424, 31);
            this.txtUpdateStreetAddress.TabIndex = 8;
            // 
            // txtUpdateFirstName
            // 
            this.txtUpdateFirstName.Location = new System.Drawing.Point(207, 104);
            this.txtUpdateFirstName.Name = "txtUpdateFirstName";
            this.txtUpdateFirstName.Size = new System.Drawing.Size(279, 31);
            this.txtUpdateFirstName.TabIndex = 7;
            // 
            // txtUpdateLastName
            // 
            this.txtUpdateLastName.Location = new System.Drawing.Point(207, 34);
            this.txtUpdateLastName.Name = "txtUpdateLastName";
            this.txtUpdateLastName.Size = new System.Drawing.Size(279, 31);
            this.txtUpdateLastName.TabIndex = 6;
            // 
            // lblUpdatePhoneNumber
            // 
            this.lblUpdatePhoneNumber.AutoSize = true;
            this.lblUpdatePhoneNumber.Location = new System.Drawing.Point(29, 338);
            this.lblUpdatePhoneNumber.Name = "lblUpdatePhoneNumber";
            this.lblUpdatePhoneNumber.Size = new System.Drawing.Size(161, 25);
            this.lblUpdatePhoneNumber.TabIndex = 5;
            this.lblUpdatePhoneNumber.Text = "Phone Number:";
            // 
            // lblUpdateSuburb
            // 
            this.lblUpdateSuburb.AutoSize = true;
            this.lblUpdateSuburb.Location = new System.Drawing.Point(101, 264);
            this.lblUpdateSuburb.Name = "lblUpdateSuburb";
            this.lblUpdateSuburb.Size = new System.Drawing.Size(87, 25);
            this.lblUpdateSuburb.TabIndex = 4;
            this.lblUpdateSuburb.Text = "Suburb:";
            // 
            // lblUpdateStreetAddress
            // 
            this.lblUpdateStreetAddress.AutoSize = true;
            this.lblUpdateStreetAddress.Location = new System.Drawing.Point(30, 184);
            this.lblUpdateStreetAddress.Name = "lblUpdateStreetAddress";
            this.lblUpdateStreetAddress.Size = new System.Drawing.Size(160, 25);
            this.lblUpdateStreetAddress.TabIndex = 3;
            this.lblUpdateStreetAddress.Text = "Street Address:";
            // 
            // lblUpdateFirstName
            // 
            this.lblUpdateFirstName.AutoSize = true;
            this.lblUpdateFirstName.Location = new System.Drawing.Point(66, 115);
            this.lblUpdateFirstName.Name = "lblUpdateFirstName";
            this.lblUpdateFirstName.Size = new System.Drawing.Size(122, 25);
            this.lblUpdateFirstName.TabIndex = 2;
            this.lblUpdateFirstName.Text = "First Name:";
            // 
            // lblUpdateLastName
            // 
            this.lblUpdateLastName.AutoSize = true;
            this.lblUpdateLastName.Location = new System.Drawing.Point(69, 34);
            this.lblUpdateLastName.Name = "lblUpdateLastName";
            this.lblUpdateLastName.Size = new System.Drawing.Size(121, 25);
            this.lblUpdateLastName.TabIndex = 1;
            this.lblUpdateLastName.Text = "Last Name:";
            // 
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 876);
            this.Controls.Add(this.pnlUpdateOwner);
            this.Controls.Add(this.pnlAddOwner);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteOwner);
            this.Controls.Add(this.btnUpdateOwner);
            this.Controls.Add(this.btnAddOwner);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtOwnerID);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblOwnerID);
            this.Controls.Add(this.lstOwners);
            this.Name = "OwnerForm";
            this.Text = "Owner Maintenance";
            this.Load += new System.EventHandler(this.OwnerForm_Load);
            this.pnlAddOwner.ResumeLayout(false);
            this.pnlAddOwner.PerformLayout();
            this.pnlUpdateOwner.ResumeLayout(false);
            this.pnlUpdateOwner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOwners;
        private System.Windows.Forms.Label lblOwnerID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtOwnerID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddOwner;
        private System.Windows.Forms.Button btnUpdateOwner;
        private System.Windows.Forms.Button btnDeleteOwner;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblAddLastName;
        private System.Windows.Forms.Label lblAddFirstName;
        private System.Windows.Forms.Label lblAddStreetAddress;
        private System.Windows.Forms.Label lblAddSuburb;
        private System.Windows.Forms.Label lblAddPhoneNumber;
        private System.Windows.Forms.TextBox txtAddLastName;
        private System.Windows.Forms.TextBox txtAddFirstName;
        private System.Windows.Forms.TextBox txtAddStreetAddress;
        private System.Windows.Forms.TextBox txtAddSuburb;
        private System.Windows.Forms.TextBox txtAddPhoneNumber;
        private System.Windows.Forms.Button btnSaveOwner;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlAddOwner;
        private System.Windows.Forms.Panel pnlUpdateOwner;
        private System.Windows.Forms.Label lblUpdatePhoneNumber;
        private System.Windows.Forms.Label lblUpdateSuburb;
        private System.Windows.Forms.Label lblUpdateStreetAddress;
        private System.Windows.Forms.Label lblUpdateFirstName;
        private System.Windows.Forms.Label lblUpdateLastName;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtUpdatePhoneNumber;
        private System.Windows.Forms.TextBox txtUpdateSuburb;
        private System.Windows.Forms.TextBox txtUpdateStreetAddress;
        private System.Windows.Forms.TextBox txtUpdateFirstName;
        private System.Windows.Forms.TextBox txtUpdateLastName;
    }
}