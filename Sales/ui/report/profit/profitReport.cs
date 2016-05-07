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

namespace Sales.ui.report
{
    public partial class profitReport : Form
    {
        ReportDocument cryRpt = new ReportDocument();
            

        private String firstDate;

        public String FirstDate
        {
            get { return firstDate; }
            set { firstDate = value; }
        }
        private String secondDate;

        public String SecondDate
        {
            get { return secondDate; }
            set { secondDate = value; }
        }
        public profitReport()
        {
            InitializeComponent();
            cryRpt.Load(VariableBuilder.DirectoryLocation + "\\_REPORT\\RptProfit.rpt");
            
        }

        private void getData() 
        {
            var records = ProfitRptModel.getData(FirstDate,SecondDate);
            cryRpt.Database.Tables["Profit"].SetDataSource(records);
            profitReportViewer.ReportSource = cryRpt;
        }

        private void profitReport_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
