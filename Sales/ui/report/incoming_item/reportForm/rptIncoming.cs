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

namespace Sales.ui.report.incoming_item.reportForm
{
    public partial class rptIncoming : Form
    {
        private ReportDocument cryRpt;
        
        public rptIncoming(String TrxNo)
        {
            InitializeComponent();
            cryRpt = new ReportDocument();
            getData(TrxNo);
        }

        private void getData(String TrxNo)
        {
            cryRpt.Load(VariableBuilder.DirectoryLocation + "\\_REPORT\\RptIncomeItem.rpt");
            var records = IncomeItemRptModel.getAll(TrxNo);
            cryRpt.Database.Tables["itemIncome"].SetDataSource(records);
            cryRpt.SetParameterValue("store_name", VariableBuilder.PermanentVar.storeIndentity.Name);
            cryRpt.SetParameterValue("store_address", VariableBuilder.PermanentVar.storeIndentity.Address);
            cryRpt.SetParameterValue("store_phone", "Telp.  " + VariableBuilder.PermanentVar.storeIndentity.Phone);
            cryRpt.SetParameterValue("print_date", DateTime.Now.ToString("yyyy MMMM dd HH:mm:ss"));
            cryRpt.SetParameterValue("TrxNo", TrxNo);
            incomeReportViewer.ReportSource = cryRpt;
        }
    }
}
