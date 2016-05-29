namespace Sales.ui.report
{
    partial class profitReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profitReport));
            this.profitReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // profitReportViewer
            // 
            this.profitReportViewer.ActiveViewIndex = -1;
            this.profitReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profitReportViewer.CachedPageNumberPerDoc = 10;
            this.profitReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.profitReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profitReportViewer.Location = new System.Drawing.Point(0, 0);
            this.profitReportViewer.Name = "profitReportViewer";
            this.profitReportViewer.Size = new System.Drawing.Size(666, 452);
            this.profitReportViewer.TabIndex = 0;
            this.profitReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // profitReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 452);
            this.Controls.Add(this.profitReportViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "profitReport";
            this.Text = "Sales :: Report :: Profit :: Print";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.profitReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer profitReportViewer;
    }
}