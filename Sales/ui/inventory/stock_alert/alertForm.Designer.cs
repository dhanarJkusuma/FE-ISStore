namespace Sales.ui.inventory.stock_alert
{
    partial class alertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alertForm));
            this.alertGrid = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.tSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.alertGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // alertGrid
            // 
            this.alertGrid.AllowUserToAddRows = false;
            this.alertGrid.AllowUserToDeleteRows = false;
            this.alertGrid.AllowUserToResizeColumns = false;
            this.alertGrid.AllowUserToResizeRows = false;
            this.alertGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alertGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alertGrid.Location = new System.Drawing.Point(13, 39);
            this.alertGrid.Name = "alertGrid";
            this.alertGrid.RowHeadersVisible = false;
            this.alertGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.alertGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.alertGrid.Size = new System.Drawing.Size(637, 321);
            this.alertGrid.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(13, 366);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 90);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tSearch
            // 
            this.tSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tSearch.Location = new System.Drawing.Point(470, 12);
            this.tSearch.Name = "tSearch";
            this.tSearch.Size = new System.Drawing.Size(180, 20);
            this.tSearch.TabIndex = 0;
            this.tSearch.TextChanged += new System.EventHandler(this.tSearch_TextChanged);
            // 
            // alertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 465);
            this.Controls.Add(this.tSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.alertGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "alertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales :: Dashboard :: Inventory :: Stock Alert";
            ((System.ComponentModel.ISupportInitialize)(this.alertGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView alertGrid;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tSearch;
    }
}