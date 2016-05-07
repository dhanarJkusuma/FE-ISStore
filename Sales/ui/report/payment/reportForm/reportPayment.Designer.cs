namespace Sales.ui.report.payment.reportForm
{
    partial class reportPayment
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
            this.paymentReportViewer.Size = new System.Drawing.Size(628, 499);
            this.paymentReportViewer.TabIndex = 0;
            this.paymentReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // reportPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 499);
            this.Controls.Add(this.paymentReportViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "reportPayment";
            this.Text = "reportPayment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer paymentReportViewer;
    }
}