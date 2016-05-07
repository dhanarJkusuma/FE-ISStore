using CrystalDecisions.CrystalReports.Engine;
using Sales.libs;
using Sales.report_model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.ui.report.payment.reportForm
{
    public partial class reportPayment : Form
    {
        private ReportDocument cryRpt;
        public reportPayment(String TrxNo)
        {
            InitializeComponent();
            cryRpt = new ReportDocument();
            getData(TrxNo);
        }

        private void getData(String TrxNo)
        {
            cryRpt.Load(VariableBuilder.DirectoryLocation + "\\_REPORT\\RptTrxPayment.rpt");
            var records = PaymentItemRptModel.getAll(TrxNo);
            cryRpt.Database.Tables["ItemsPayment"].SetDataSource(records);
            paymentReportViewer.ReportSource = cryRpt;
        }
    }
}
