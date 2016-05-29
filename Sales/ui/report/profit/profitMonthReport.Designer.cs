namespace Sales.ui.report.profit
{
    partial class profitMonthReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profitMonthReport));
            this.profitViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // profitViewer
            // 
            this.profitViewer.ActiveViewIndex = -1;
            this.profitViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profitViewer.CachedPageNumberPerDoc = 10;
            this.profitViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.profitViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profitViewer.Location = new System.Drawing.Point(0, 0);
            this.profitViewer.Name = "profitViewer";
            this.profitViewer.Size = new System.Drawing.Size(489, 388);
            this.profitViewer.TabIndex = 0;
            this.profitViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // profitMonthReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 388);
            this.Controls.Add(this.profitViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "profitMonthReport";
            this.Text = "Sales :: Report :: Profit :: Print";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.profitMonthReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer profitViewer;
    }
}