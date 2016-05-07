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
            crystalReportViewer1.ReportSource = cryRpt;
        }
    }
}
