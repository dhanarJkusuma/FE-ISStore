namespace Sales.ui.report.incoming_item.detail
{
    partial class detailIncomeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(detailIncomeList));
            this.itemGrid = new System.Windows.Forms.DataGridView();
            this.cBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trxNo = new System.Windows.Forms.TextBox();
            this.tSupplier = new System.Windows.Forms.TextBox();
            this.tDate = new System.Windows.Forms.TextBox();
            this.tModi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // itemGrid
            // 
            this.itemGrid.AllowUserToAddRows = false;
            this.itemGrid.AllowUserToDeleteRows = false;
            this.itemGrid.AllowUserToResizeColumns = false;
            this.itemGrid.AllowUserToResizeRows = false;
            this.itemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cBarcode,
            this.cQty,
            this.cPurchase,
            this.cSubTotal});
            this.itemGrid.Location = new System.Drawing.Point(13, 64);
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.ReadOnly = true;
            this.itemGrid.RowHeadersVisible = false;
            this.itemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemGrid.Size = new System.Drawing.Size(482, 394);
            this.itemGrid.TabIndex = 0;
            // 
            // cBarcode
            // 
            this.cBarcode.HeaderText = "Barcode";
            this.cBarcode.Name = "cBarcode";
            this.cBarcode.ReadOnly = true;
            // 
            // cQty
            // 
            this.cQty.HeaderText = "Qty";
            this.cQty.Name = "cQty";
            this.cQty.ReadOnly = true;
            // 
            // cPurchase
            // 
            this.cPurchase.HeaderText = "Purchase";
            this.cPurchase.Name = "cPurchase";
            this.cPurchase.ReadOnly = true;
            // 
            // cSubTotal
            // 
            this.cSubTotal.HeaderText = "Sub Total";
            this.cSubTotal.Name = "cSubTotal";
            this.cSubTotal.ReadOnly = true;
            // 
            // trxNo
            // 
            this.trxNo.Enabled = false;
            this.trxNo.Location = new System.Drawing.Point(13, 12);
            this.trxNo.Name = "trxNo";
            this.trxNo.Size = new System.Drawing.Size(482, 20);
            this.trxNo.TabIndex = 1;
            this.trxNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tSupplier
            // 
            this.tSupplier.Enabled = false;
            this.tSupplier.Location = new System.Drawing.Point(13, 38);
            this.tSupplier.Name = "tSupplier";
            this.tSupplier.Size = new System.Drawing.Size(482, 20);
            this.tSupplier.TabIndex = 1;
            this.tSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tDate
            // 
            this.tDate.Enabled = false;
            this.tDate.Location = new System.Drawing.Point(13, 470);
            this.tDate.Name = "tDate";
            this.tDate.Size = new System.Drawing.Size(146, 20);
            this.tDate.TabIndex = 2;
            // 
            // tModi
            // 
            this.tModi.Enabled = false;
            this.tModi.Location = new System.Drawing.Point(383, 470);
            this.tModi.Name = "tModi";
            this.tModi.Size = new System.Drawing.Size(112, 20);
            this.tModi.TabIndex = 1;
            this.tModi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // detailIncomeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 502);
            this.Controls.Add(this.tDate);
            this.Controls.Add(this.tModi);
            this.Controls.Add(this.tSupplier);
            this.Controls.Add(this.trxNo);
            this.Controls.Add(this.itemGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "detailIncomeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales :: Report :: Incoming Item :: Detail";
            this.Load += new System.EventHandler(this.detailIncomeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView itemGrid;
        private System.Windows.Forms.TextBox trxNo;
        private System.Windows.Forms.TextBox tSupplier;
        private System.Windows.Forms.TextBox tDate;
        private System.Windows.Forms.TextBox tModi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSubTotal;
    }
}