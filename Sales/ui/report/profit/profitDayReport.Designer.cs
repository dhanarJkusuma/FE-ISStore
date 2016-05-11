namespace Sales.ui.report.profit
{
    partial class profitDayReport
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
            this.daysProfitViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // daysProfitViewer
            // 
            this.daysProfitViewer.ActiveViewIndex = -1;
            this.daysProfitViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.daysProfitViewer.CachedPageNumberPerDoc = 10;
            this.daysProfitViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.daysProfitViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.daysProfitViewer.Location = new System.Drawing.Point(0, 0);
            this.daysProfitViewer.Name = "daysProfitViewer";
            this.daysProfitViewer.Size = new System.Drawing.Size(471, 372);
            this.daysProfitViewer.TabIndex = 0;
            this.daysProfitViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // profitDayReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 372);
            this.Controls.Add(this.daysProfitViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "profitDayReport";
            this.Text = "Sales :: Report :: Profit :: Profit per Day";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.profitDayReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer daysProfitViewer;

    }
}