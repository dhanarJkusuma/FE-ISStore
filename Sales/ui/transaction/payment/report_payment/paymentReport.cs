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

namespace Sales.ui.transaction.payment.report_payment
{
    public partial class paymentReport : Form
    {
        ReportDocument cryRpt;
        private List<ItemPaymentRptModel> items;

        internal List<ItemPaymentRptModel> Items
        {
            get { return items; }
            set { items = value; }
        }

        public paymentReport()
        {
            InitializeComponent();
            cryRpt = new ReportDocument();
           // loadData();
        }

        private void loadData() 
        {
            var records = Items;
            cryRpt.Load(VariableBuilder.DirectoryLocation + "\\_REPORT\\RptTrxPayment.rpt");
            cryRpt.Database.Tables["ItemsPayment"].SetDataSource(records);
            paymentReportViewer.ReportSource = cryRpt;
        }

        private void paymentReport_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
