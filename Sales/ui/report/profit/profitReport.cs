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
            
        }

        private void getData() 
        {
            cryRpt.Load(VariableBuilder.DirectoryLocation + "\\_REPORT\\RptProfit.rpt");
            var records = ProfitRptModel.getData(FirstDate,SecondDate);
            cryRpt.Database.Tables["Profit"].SetDataSource(records);
            cryRpt.SetParameterValue("store_name", VariableBuilder.PermanentVar.storeIndentity.Name);
            cryRpt.SetParameterValue("store_address", VariableBuilder.PermanentVar.storeIndentity.Address);
            cryRpt.SetParameterValue("store_phone", "Telp.  " + VariableBuilder.PermanentVar.storeIndentity.Phone);
            cryRpt.SetParameterValue("print_date", DateTime.Now.ToString("yyyy MMMM dd HH:mm:ss"));
            profitReportViewer.ReportSource = cryRpt;
        }

        private void profitReport_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
