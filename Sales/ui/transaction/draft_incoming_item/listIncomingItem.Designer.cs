namespace Sales.ui.transaction.draft_incoming_item
{
    partial class listIncomingItem
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
            this.incomeList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.incomeList)).BeginInit();
            this.SuspendLayout();
            // 
            // incomeList
            // 
            this.incomeList.AllowUserToAddRows = false;
            this.incomeList.AllowUserToDeleteRows = false;
            this.incomeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.incomeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incomeList.Location = new System.Drawing.Point(12, 13);
            this.incomeList.MultiSelect = false;
            this.incomeList.Name = "incomeList";
            this.incomeList.ReadOnly = true;
            this.incomeList.RowHeadersVisible = false;
            this.incomeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.incomeList.Size = new System.Drawing.Size(651, 397);
            this.incomeList.TabIndex = 0;
            this.incomeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.incomeList_CellContentClick);
            // 
            // listIncomingItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 485);
            this.Controls.Add(this.incomeList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "listIncomingItem";
            this.Text = "Sales :: Transaction :: Draft Income Item";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.listIncomingItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incomeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView incomeList;
    }
}