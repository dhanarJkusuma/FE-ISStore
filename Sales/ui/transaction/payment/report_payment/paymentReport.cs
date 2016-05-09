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

        private String trxNo;

        public String TrxNo
        {
            get { return trxNo; }
            set { trxNo = value; }
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
            cryRpt.SetParameterValue("store_name", VariableBuilder.PermanentVar.storeIndentity.Name);
            cryRpt.SetParameterValue("store_address", VariableBuilder.PermanentVar.storeIndentity.Address);
            cryRpt.SetParameterValue("store_phone", "Telp.  " + VariableBuilder.PermanentVar.storeIndentity.Phone);
            cryRpt.SetParameterValue("print_date", DateTime.Now.ToString("yyyy MMMM dd HH:mm:ss"));
            cryRpt.SetParameterValue("TrxNo", TrxNo);
            
            paymentReportViewer.ReportSource = cryRpt;
        }

        private void paymentReport_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
