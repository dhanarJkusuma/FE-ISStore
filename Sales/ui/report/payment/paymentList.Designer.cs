namespace Sales.ui.report.payment
{
    partial class paymentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paymentList));
            this.paymentGrid = new System.Windows.Forms.DataGridView();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.firstDate = new System.Windows.Forms.DateTimePicker();
            this.secondDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.paymentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentGrid
            // 
            this.paymentGrid.AllowUserToAddRows = false;
            this.paymentGrid.AllowUserToDeleteRows = false;
            this.paymentGrid.AllowUserToResizeColumns = false;
            this.paymentGrid.AllowUserToResizeRows = false;
            this.paymentGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentGrid.Location = new System.Drawing.Point(13, 56);
            this.paymentGrid.MultiSelect = false;
            this.paymentGrid.Name = "paymentGrid";
            this.paymentGrid.ReadOnly = true;
            this.paymentGrid.RowHeadersVisible = false;
            this.paymentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paymentGrid.Size = new System.Drawing.Size(595, 334);
            this.paymentGrid.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.Location = new System.Drawing.Point(122, 396);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(101, 99);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(15, 396);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(101, 99);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // firstDate
            // 
            this.firstDate.Location = new System.Drawing.Point(13, 30);
            this.firstDate.Name = "firstDate";
            this.firstDate.Size = new System.Drawing.Size(200, 20);
            this.firstDate.TabIndex = 4;
            this.firstDate.ValueChanged += new System.EventHandler(this.firstDate_ValueChanged);
            // 
            // secondDate
            // 
            this.secondDate.Location = new System.Drawing.Point(408, 30);
            this.secondDate.Name = "secondDate";
            this.secondDate.Size = new System.Drawing.Size(200, 20);
            this.secondDate.TabIndex = 4;
            this.secondDate.ValueChanged += new System.EventHandler(this.secondDate_ValueChanged);
            // 
            // paymentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 499);
            this.Controls.Add(this.secondDate);
            this.Controls.Add(this.firstDate);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.paymentGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "paymentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales :: Report :: Payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.paymentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView paymentGrid;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker firstDate;
        private System.Windows.Forms.DateTimePicker secondDate;
    }
}