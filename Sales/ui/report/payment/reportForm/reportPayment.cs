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
            cryRpt.SetParameterValue("store_name", VariableBuilder.PermanentVar.storeIndentity.Name);
            cryRpt.SetParameterValue("store_address", VariableBuilder.PermanentVar.storeIndentity.Address);
            cryRpt.SetParameterValue("store_phone", "Telp.  " + VariableBuilder.PermanentVar.storeIndentity.Phone);
            cryRpt.SetParameterValue("print_date", DateTime.Now.ToString("yyyy MMMM dd HH:mm:ss"));
            cryRpt.SetParameterValue("TrxNo", TrxNo);

            paymentReportViewer.ReportSource = cryRpt;
        }
    }
}
