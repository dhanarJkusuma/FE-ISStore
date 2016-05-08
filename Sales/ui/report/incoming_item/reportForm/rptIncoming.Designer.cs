namespace Sales.ui.report.incoming_item.reportForm
{
    partial class rptIncoming
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
            this.incomeReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // incomeReportViewer
            // 
            this.incomeReportViewer.ActiveViewIndex = -1;
            this.incomeReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.incomeReportViewer.CachedPageNumberPerDoc = 10;
            this.incomeReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.incomeReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incomeReportViewer.Location = new System.Drawing.Point(0, 0);
            this.incomeReportViewer.Name = "incomeReportViewer";
            this.incomeReportViewer.Size = new System.Drawing.Size(551, 400);
            this.incomeReportViewer.TabIndex = 0;
            this.incomeReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // rptIncoming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 400);
            this.Controls.Add(this.incomeReportViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rptIncoming";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sales :: Report :: Incoming Item :: Print";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer incomeReportViewer;
    }
}