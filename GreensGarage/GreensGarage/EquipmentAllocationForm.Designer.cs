namespace GreensGarage
{
    partial class EquipmentAllocationForm
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
            this.dgvServiceType = new System.Windows.Forms.DataGridView();
            this.dgvServiceTypeEquipment = new System.Windows.Forms.DataGridView();
            this.dgvEquipment = new System.Windows.Forms.DataGridView();
            this.btnAllocateEquipment = new System.Windows.Forms.Button();
            this.btnRemoveEquipment = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceTypeEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServiceType
            // 
            this.dgvServiceType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceType.Location = new System.Drawing.Point(251, 23);
            this.dgvServiceType.Name = "dgvServiceType";
            this.dgvServiceType.RowTemplate.Height = 33;
            this.dgvServiceType.Size = new System.Drawing.Size(914, 372);
            this.dgvServiceType.TabIndex = 0;
            // 
            // dgvServiceTypeEquipment
            // 
            this.dgvServiceTypeEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceTypeEquipment.Location = new System.Drawing.Point(64, 477);
            this.dgvServiceTypeEquipment.Name = "dgvServiceTypeEquipment";
            this.dgvServiceTypeEquipment.RowTemplate.Height = 33;
            this.dgvServiceTypeEquipment.Size = new System.Drawing.Size(484, 400);
            this.dgvServiceTypeEquipment.TabIndex = 1;
            // 
            // dgvEquipment
            // 
            this.dgvEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipment.Location = new System.Drawing.Point(880, 477);
            this.dgvEquipment.Name = "dgvEquipment";
            this.dgvEquipment.RowTemplate.Height = 33;
            this.dgvEquipment.Size = new System.Drawing.Size(509, 400);
            this.dgvEquipment.TabIndex = 2;
            // 
            // btnAllocateEquipment
            // 
            this.btnAllocateEquipment.Location = new System.Drawing.Point(596, 477);
            this.btnAllocateEquipment.Name = "btnAllocateEquipment";
            this.btnAllocateEquipment.Size = new System.Drawing.Size(232, 68);
            this.btnAllocateEquipment.TabIndex = 3;
            this.btnAllocateEquipment.Text = "Allocate Equipment";
            this.btnAllocateEquipment.UseVisualStyleBackColor = true;
            this.btnAllocateEquipment.Click += new System.EventHandler(this.btnAllocateEquipment_Click);
            // 
            // btnRemoveEquipment
            // 
            this.btnRemoveEquipment.Location = new System.Drawing.Point(596, 814);
            this.btnRemoveEquipment.Name = "btnRemoveEquipment";
            this.btnRemoveEquipment.Size = new System.Drawing.Size(232, 63);
            this.btnRemoveEquipment.TabIndex = 4;
            this.btnRemoveEquipment.Text = "Remove Equipment";
            this.btnRemoveEquipment.UseVisualStyleBackColor = true;
            this.btnRemoveEquipment.Click += new System.EventHandler(this.btnRemoveEquipment_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(1199, 908);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(190, 57);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // EquipmentAllocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 1013);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemoveEquipment);
            this.Controls.Add(this.btnAllocateEquipment);
            this.Controls.Add(this.dgvEquipment);
            this.Controls.Add(this.dgvServiceTypeEquipment);
            this.Controls.Add(this.dgvServiceType);
            this.Name = "EquipmentAllocationForm";
            this.Text = "Equipment Allocation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceTypeEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServiceType;
        private System.Windows.Forms.DataGridView dgvServiceTypeEquipment;
        private System.Windows.Forms.DataGridView dgvEquipment;
        private System.Windows.Forms.Button btnAllocateEquipment;
        private System.Windows.Forms.Button btnRemoveEquipment;
        private System.Windows.Forms.Button btnReturn;
    }
}