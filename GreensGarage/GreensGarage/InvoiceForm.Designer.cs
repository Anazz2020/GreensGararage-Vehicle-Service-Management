namespace GreensGarage
{
    partial class InvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.prvInvoices = new System.Windows.Forms.PrintPreviewDialog();
            this.printInvoices = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.Location = new System.Drawing.Point(275, 184);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(279, 71);
            this.btnPrintInvoice.TabIndex = 0;
            this.btnPrintInvoice.Text = "Print Invoice";
            this.btnPrintInvoice.UseVisualStyleBackColor = true;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(792, 184);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(300, 71);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // prvInvoices
            // 
            this.prvInvoices.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvInvoices.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvInvoices.ClientSize = new System.Drawing.Size(400, 300);
            this.prvInvoices.Document = this.printInvoices;
            this.prvInvoices.Enabled = true;
            this.prvInvoices.Icon = ((System.Drawing.Icon)(resources.GetObject("prvInvoices.Icon")));
            this.prvInvoices.Name = "printPreviewDialog1";
            this.prvInvoices.Visible = false;
            // 
            // printInvoices
            // 
            this.printInvoices.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printInvoices_PrintPage);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 445);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrintInvoice);
            this.Name = "InvoiceForm";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PrintPreviewDialog prvInvoices;
        private System.Drawing.Printing.PrintDocument printInvoices;
    }
}