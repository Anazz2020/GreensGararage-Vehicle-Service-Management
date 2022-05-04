namespace GreensGarage
{
    partial class EquipmentForm
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
            this.lstEquipments = new System.Windows.Forms.ListBox();
            this.lblEquipmentID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtEquipmentID = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.btnUpdateEquipment = new System.Windows.Forms.Button();
            this.btnDeleteEquipment = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAddEquipment = new System.Windows.Forms.Panel();
            this.lblAddDescription = new System.Windows.Forms.Label();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.btnSaveEquipment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlUpdateEquipment = new System.Windows.Forms.Panel();
            this.lblUpdateEquipmentID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUpdateEquipmentID = new System.Windows.Forms.TextBox();
            this.txtUpdateDescription = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.pnlAddEquipment.SuspendLayout();
            this.pnlUpdateEquipment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEquipments
            // 
            this.lstEquipments.FormattingEnabled = true;
            this.lstEquipments.ItemHeight = 25;
            this.lstEquipments.Location = new System.Drawing.Point(64, 55);
            this.lstEquipments.Name = "lstEquipments";
            this.lstEquipments.Size = new System.Drawing.Size(467, 554);
            this.lstEquipments.TabIndex = 0;
            // 
            // lblEquipmentID
            // 
            this.lblEquipmentID.AutoSize = true;
            this.lblEquipmentID.Location = new System.Drawing.Point(606, 111);
            this.lblEquipmentID.Name = "lblEquipmentID";
            this.lblEquipmentID.Size = new System.Drawing.Size(146, 25);
            this.lblEquipmentID.TabIndex = 1;
            this.lblEquipmentID.Text = "Equipment ID:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(632, 204);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(126, 25);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // txtEquipmentID
            // 
            this.txtEquipmentID.Enabled = false;
            this.txtEquipmentID.Location = new System.Drawing.Point(764, 105);
            this.txtEquipmentID.Name = "txtEquipmentID";
            this.txtEquipmentID.Size = new System.Drawing.Size(120, 31);
            this.txtEquipmentID.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(764, 201);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(475, 31);
            this.txtDescription.TabIndex = 4;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(64, 661);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(157, 51);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(265, 661);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(195, 51);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Location = new System.Drawing.Point(500, 661);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(201, 51);
            this.btnAddEquipment.TabIndex = 7;
            this.btnAddEquipment.Text = "Add Equipment";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // btnUpdateEquipment
            // 
            this.btnUpdateEquipment.Location = new System.Drawing.Point(764, 662);
            this.btnUpdateEquipment.Name = "btnUpdateEquipment";
            this.btnUpdateEquipment.Size = new System.Drawing.Size(208, 50);
            this.btnUpdateEquipment.TabIndex = 8;
            this.btnUpdateEquipment.Text = "Update Equipment";
            this.btnUpdateEquipment.UseVisualStyleBackColor = true;
            this.btnUpdateEquipment.Click += new System.EventHandler(this.btnUpdateEquipment_Click);
            // 
            // btnDeleteEquipment
            // 
            this.btnDeleteEquipment.Location = new System.Drawing.Point(1033, 662);
            this.btnDeleteEquipment.Name = "btnDeleteEquipment";
            this.btnDeleteEquipment.Size = new System.Drawing.Size(194, 50);
            this.btnDeleteEquipment.TabIndex = 9;
            this.btnDeleteEquipment.Text = "Delete Equipment";
            this.btnDeleteEquipment.UseVisualStyleBackColor = true;
            this.btnDeleteEquipment.Click += new System.EventHandler(this.btnDeleteEquipment_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(1033, 776);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(194, 53);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlAddEquipment
            // 
            this.pnlAddEquipment.Controls.Add(this.btnCancel);
            this.pnlAddEquipment.Controls.Add(this.btnSaveEquipment);
            this.pnlAddEquipment.Controls.Add(this.txtAddDescription);
            this.pnlAddEquipment.Controls.Add(this.lblAddDescription);
            this.pnlAddEquipment.Location = new System.Drawing.Point(561, 105);
            this.pnlAddEquipment.Name = "pnlAddEquipment";
            this.pnlAddEquipment.Size = new System.Drawing.Size(678, 289);
            this.pnlAddEquipment.TabIndex = 11;
            this.pnlAddEquipment.Visible = false;
            // 
            // lblAddDescription
            // 
            this.lblAddDescription.AutoSize = true;
            this.lblAddDescription.Location = new System.Drawing.Point(76, 87);
            this.lblAddDescription.Name = "lblAddDescription";
            this.lblAddDescription.Size = new System.Drawing.Size(126, 25);
            this.lblAddDescription.TabIndex = 0;
            this.lblAddDescription.Text = "Description:";
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(224, 81);
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(416, 31);
            this.txtAddDescription.TabIndex = 1;
            // 
            // btnSaveEquipment
            // 
            this.btnSaveEquipment.Location = new System.Drawing.Point(50, 185);
            this.btnSaveEquipment.Name = "btnSaveEquipment";
            this.btnSaveEquipment.Size = new System.Drawing.Size(198, 51);
            this.btnSaveEquipment.TabIndex = 2;
            this.btnSaveEquipment.Text = "Save Equipment";
            this.btnSaveEquipment.UseVisualStyleBackColor = true;
            this.btnSaveEquipment.Click += new System.EventHandler(this.btnSaveEquipment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(398, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(186, 55);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlUpdateEquipment
            // 
            this.pnlUpdateEquipment.Controls.Add(this.btnUpdateCancel);
            this.pnlUpdateEquipment.Controls.Add(this.btnSaveChanges);
            this.pnlUpdateEquipment.Controls.Add(this.txtUpdateDescription);
            this.pnlUpdateEquipment.Controls.Add(this.txtUpdateEquipmentID);
            this.pnlUpdateEquipment.Controls.Add(this.label2);
            this.pnlUpdateEquipment.Controls.Add(this.lblUpdateEquipmentID);
            this.pnlUpdateEquipment.Location = new System.Drawing.Point(548, 97);
            this.pnlUpdateEquipment.Name = "pnlUpdateEquipment";
            this.pnlUpdateEquipment.Size = new System.Drawing.Size(703, 344);
            this.pnlUpdateEquipment.TabIndex = 12;
            this.pnlUpdateEquipment.Visible = false;
            // 
            // lblUpdateEquipmentID
            // 
            this.lblUpdateEquipmentID.AutoSize = true;
            this.lblUpdateEquipmentID.Location = new System.Drawing.Point(33, 60);
            this.lblUpdateEquipmentID.Name = "lblUpdateEquipmentID";
            this.lblUpdateEquipmentID.Size = new System.Drawing.Size(146, 25);
            this.lblUpdateEquipmentID.TabIndex = 0;
            this.lblUpdateEquipmentID.Text = "Equipment ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // txtUpdateEquipmentID
            // 
            this.txtUpdateEquipmentID.Enabled = false;
            this.txtUpdateEquipmentID.Location = new System.Drawing.Point(185, 54);
            this.txtUpdateEquipmentID.Name = "txtUpdateEquipmentID";
            this.txtUpdateEquipmentID.Size = new System.Drawing.Size(100, 31);
            this.txtUpdateEquipmentID.TabIndex = 2;
            // 
            // txtUpdateDescription
            // 
            this.txtUpdateDescription.Location = new System.Drawing.Point(185, 129);
            this.txtUpdateDescription.Name = "txtUpdateDescription";
            this.txtUpdateDescription.Size = new System.Drawing.Size(494, 31);
            this.txtUpdateDescription.TabIndex = 3;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(47, 258);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(196, 49);
            this.btnSaveChanges.TabIndex = 4;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(454, 258);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(225, 49);
            this.btnUpdateCancel.TabIndex = 5;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // EquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 865);
            this.Controls.Add(this.pnlUpdateEquipment);
            this.Controls.Add(this.pnlAddEquipment);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteEquipment);
            this.Controls.Add(this.btnUpdateEquipment);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtEquipmentID);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblEquipmentID);
            this.Controls.Add(this.lstEquipments);
            this.Name = "EquipmentForm";
            this.Text = "Equipment Maintenance";
            this.pnlAddEquipment.ResumeLayout(false);
            this.pnlAddEquipment.PerformLayout();
            this.pnlUpdateEquipment.ResumeLayout(false);
            this.pnlUpdateEquipment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEquipments;
        private System.Windows.Forms.Label lblEquipmentID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtEquipmentID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Button btnUpdateEquipment;
        private System.Windows.Forms.Button btnDeleteEquipment;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlAddEquipment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveEquipment;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.Label lblAddDescription;
        private System.Windows.Forms.Panel pnlUpdateEquipment;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtUpdateDescription;
        private System.Windows.Forms.TextBox txtUpdateEquipmentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUpdateEquipmentID;
    }
}