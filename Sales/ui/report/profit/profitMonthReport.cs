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

namespace Sales.ui.report.profit
{
    public partial class profitMonthReport : Form
    {
        ReportDocument cyRpt;
        private Int32 firstMonth;

        public Int32 FirstMonth
        {
            get { return firstMonth; }
            set { firstMonth = value; }
        }
        private Int32 secondMonth;

        public Int32 SecondMonth
        {
            get { return secondMonth; }
            set { secondMonth = value; }
        }
        private Int32 firstYear;

        public Int32 FirstYear
        {
            get { return firstYear; }
            set { firstYear = value; }
        }
        private Int32 secondYear;

        public Int32 SecondYear
        {
            get { return secondYear; }
            set { secondYear = value; }
        }
        public profitMonthReport()
        {
            InitializeComponent();
            cyRpt = new ReportDocument();
            
        }

        private void getData() 
        {
            cyRpt.Load(VariableBuilder.DirectoryLocation + "\\_REPORT\\RptProfitMonth.rpt");
            var records = ProfitRptModel.getData(FirstMonth, SecondMonth, FirstYear, SecondYear); ;
            cyRpt.Database.Tables["profitMonth"].SetDataSource(records);
            cyRpt.SetParameterValue("store_name", VariableBuilder.PermanentVar.storeIndentity.Name);
            cyRpt.SetParameterValue("store_address", VariableBuilder.PermanentVar.storeIndentity.Address);
            cyRpt.SetParameterValue("store_phone", "Telp.  " + VariableBuilder.PermanentVar.storeIndentity.Phone);
            cyRpt.SetParameterValue("print_date", DateTime.Now.ToString("yyyy MMMM dd HH:mm:ss"));
            profitViewer.ReportSource = cyRpt;
        
        }

        private void profitMonthReport_Load(object sender, EventArgs e)
        {
            getData();
        }

    }
}
