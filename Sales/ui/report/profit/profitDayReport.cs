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
    public partial class profitDayReport : Form
    {
        private ReportDocument cyRpt;
        private Int32 month;

        public Int32 Month
        {
            get { return month; }
            set { month = value; }
        }
        private Int32 year;

        public Int32 Year
        {
            get { return year; }
            set { year = value; }
        }
        public profitDayReport()
        {
            InitializeComponent();
            cyRpt = new ReportDocument();
        }
        private void getData()
        {
            cyRpt.Load(VariableBuilder.DirectoryLocation + "\\_REPORT\\RptProfitDays.rpt");
            var records = ProfitRptModel.getDataDay(Month, Year);
            cyRpt.Database.Tables["profitDay"].SetDataSource(records);
            cyRpt.SetParameterValue("store_name", VariableBuilder.PermanentVar.storeIndentity.Name);
            cyRpt.SetParameterValue("store_address", VariableBuilder.PermanentVar.storeIndentity.Address);
            cyRpt.SetParameterValue("store_phone", "Telp.  " + VariableBuilder.PermanentVar.storeIndentity.Phone);
            cyRpt.SetParameterValue("print_date", DateTime.Now.ToString("yyyy MMMM dd HH:mm:ss"));

            ProfitRptModel.InMonth dataSum = ProfitRptModel.getSingleDataMonth(Month, Year);
            if (dataSum != null)
            {
                cyRpt.SetParameterValue("total_profit", dataSum.Profit);
            }
            else
            {
                cyRpt.SetParameterValue("total_profit", Helper.Data.rupiahParser("0"));
            }
            
            daysProfitViewer.ReportSource = cyRpt;

        }

        private void profitDayReport_Load(object sender, EventArgs e)
        {
            getData();
        }

    }
}
