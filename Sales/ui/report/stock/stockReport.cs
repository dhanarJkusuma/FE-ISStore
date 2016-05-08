using CrystalDecisions.CrystalReports.Engine;
using Sales.libs;
using Sales.model;
using Sales.report_model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.ui.report
{
    public partial class stockReport : Form
    {
        public stockReport()
        {
            InitializeComponent();
            
            
        }

        private void item_report_Load(object sender, EventArgs e)
        {
            loadReport();   
        }

        private void loadReport() 
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(VariableBuilder.DirectoryLocation + "\\_REPORT\\RptStock.rpt");
            var records = StockRptModel.getAll();

            
            cryRpt.Database.Tables["StockData"].SetDataSource(records);
            cryRpt.SetParameterValue("store_name", VariableBuilder.PermanentVar.storeIndentity.Name);
            cryRpt.SetParameterValue("store_address", VariableBuilder.PermanentVar.storeIndentity.Address);
            cryRpt.SetParameterValue("store_phone","Telp.  " + VariableBuilder.PermanentVar.storeIndentity.Phone);
            cryRpt.SetParameterValue("print_date", DateTime.Now.ToString("yyyy MMMM dd HH:mm:ss"));
            crystalReportViewer1.ReportSource = cryRpt;
        }
    }
}
