namespace Sales.ui.transaction.payment.report_payment
{
    partial class paymentReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paymentReport));
            this.paymentReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // paymentReportViewer
            // 
            this.paymentReportViewer.ActiveViewIndex = -1;
            this.paymentReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentReportViewer.CachedPageNumberPerDoc = 10;
            this.paymentReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.paymentReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentReportViewer.Location = new System.Drawing.Point(0, 0);
            this.paymentReportViewer.Name = "paymentReportViewer";
            this.paymentReportViewer.Size = new System.Drawing.Size(634, 476);
            this.paymentReportViewer.TabIndex = 0;
            this.paymentReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // paymentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 476);
            this.Controls.Add(this.paymentReportViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "paymentReport";
            this.Text = "Sales :: Transaction :: Payment :: Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.paymentReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer paymentReportViewer;
    }
}