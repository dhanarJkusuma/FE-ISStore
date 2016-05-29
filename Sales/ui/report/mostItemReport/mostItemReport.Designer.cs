namespace Sales.ui.report.mostItemReport
{
    partial class mostItemReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mostItemReport));
            this.mostReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // mostReportViewer
            // 
            this.mostReportViewer.ActiveViewIndex = -1;
            this.mostReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mostReportViewer.CachedPageNumberPerDoc = 10;
            this.mostReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.mostReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mostReportViewer.Location = new System.Drawing.Point(0, 0);
            this.mostReportViewer.Name = "mostReportViewer";
            this.mostReportViewer.Size = new System.Drawing.Size(661, 468);
            this.mostReportViewer.TabIndex = 0;
            this.mostReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // mostItemReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 468);
            this.Controls.Add(this.mostReportViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mostItemReport";
            this.Text = "Sales :: Report :: [ DOWN | TOP ] 10 Item  :: Print";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer mostReportViewer;
    }
}