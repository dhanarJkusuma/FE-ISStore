namespace Sales.ui.report.payment.detail
{
    partial class detailPayment
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
            this.tDate = new System.Windows.Forms.TextBox();
            this.tModi = new System.Windows.Forms.TextBox();
            this.tMember = new System.Windows.Forms.TextBox();
            this.trxNo = new System.Windows.Forms.TextBox();
            this.itemGrid = new System.Windows.Forms.DataGridView();
            this.cBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.Label();
            this.pay = new System.Windows.Forms.Label();
            this.cashBack = new System.Windows.Forms.Label();
            this.profit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tDate
            // 
            this.tDate.Enabled = false;
            this.tDate.Location = new System.Drawing.Point(12, 470);
            this.tDate.Name = "tDate";
            this.tDate.Size = new System.Drawing.Size(146, 20);
            this.tDate.TabIndex = 7;
            // 
            // tModi
            // 
            this.tModi.Enabled = false;
            this.tModi.Location = new System.Drawing.Point(522, 470);
            this.tModi.Name = "tModi";
            this.tModi.Size = new System.Drawing.Size(112, 20);
            this.tModi.TabIndex = 4;
            this.tModi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tMember
            // 
            this.tMember.Enabled = false;
            this.tMember.Location = new System.Drawing.Point(12, 38);
            this.tMember.Name = "tMember";
            this.tMember.Size = new System.Drawing.Size(622, 20);
            this.tMember.TabIndex = 5;
            this.tMember.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trxNo
            // 
            this.trxNo.Enabled = false;
            this.trxNo.Location = new System.Drawing.Point(12, 12);
            this.trxNo.Name = "trxNo";
            this.trxNo.Size = new System.Drawing.Size(622, 20);
            this.trxNo.TabIndex = 6;
            this.trxNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.cName,
            this.cQty,
            this.cPrice,
            this.cSubTotal});
            this.itemGrid.Location = new System.Drawing.Point(12, 64);
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.ReadOnly = true;
            this.itemGrid.RowHeadersVisible = false;
            this.itemGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemGrid.Size = new System.Drawing.Size(622, 394);
            this.itemGrid.TabIndex = 3;
            // 
            // cBarcode
            // 
            this.cBarcode.HeaderText = "Barcode";
            this.cBarcode.Name = "cBarcode";
            this.cBarcode.ReadOnly = true;
            // 
            // cName
            // 
            this.cName.HeaderText = "Item Name";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // cQty
            // 
            this.cQty.HeaderText = "Qty";
            this.cQty.Name = "cQty";
            this.cQty.ReadOnly = true;
            // 
            // cPrice
            // 
            this.cPrice.HeaderText = "Price";
            this.cPrice.Name = "cPrice";
            this.cPrice.ReadOnly = true;
            // 
            // cSubTotal
            // 
            this.cSubTotal.HeaderText = "Sub Total";
            this.cSubTotal.Name = "cSubTotal";
            this.cSubTotal.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(12, 520);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(31, 13);
            this.amount.TabIndex = 8;
            this.amount.Text = "Total";
            this.amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pay
            // 
            this.pay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pay.AutoSize = true;
            this.pay.Location = new System.Drawing.Point(12, 544);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(25, 13);
            this.pay.TabIndex = 8;
            this.pay.Text = "Pay";
            this.pay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cashBack
            // 
            this.cashBack.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cashBack.AutoSize = true;
            this.cashBack.Location = new System.Drawing.Point(12, 569);
            this.cashBack.Name = "cashBack";
            this.cashBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cashBack.Size = new System.Drawing.Size(56, 13);
            this.cashBack.TabIndex = 8;
            this.cashBack.Text = "CashBack";
            this.cashBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // profit
            // 
            this.profit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.profit.AutoSize = true;
            this.profit.Location = new System.Drawing.Point(12, 592);
            this.profit.Name = "profit";
            this.profit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.profit.Size = new System.Drawing.Size(31, 13);
            this.profit.TabIndex = 8;
            this.profit.Text = "Profit";
            this.profit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // detailPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 612);
            this.Controls.Add(this.profit);
            this.Controls.Add(this.cashBack);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.tDate);
            this.Controls.Add(this.tModi);
            this.Controls.Add(this.tMember);
            this.Controls.Add(this.trxNo);
            this.Controls.Add(this.itemGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "detailPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales :: Report :: Payment :: Detail";
            this.Load += new System.EventHandler(this.detailPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tDate;
        private System.Windows.Forms.TextBox tModi;
        private System.Windows.Forms.TextBox tMember;
        private System.Windows.Forms.TextBox trxNo;
        private System.Windows.Forms.DataGridView itemGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSubTotal;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label pay;
        private System.Windows.Forms.Label cashBack;
        private System.Windows.Forms.Label profit;
    }
}