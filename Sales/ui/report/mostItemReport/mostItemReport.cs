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

namespace Sales.ui.report.mostItemReport
{
    public partial class mostItemReport : Form
    {
        ReportDocument cyRpt;
        public mostItemReport(int typeValue)
        {
            InitializeComponent();
            cyRpt = new ReportDocument();
            loadData(typeValue);
        }

        private void loadData(int typeValue)
        {
            String title="";
            cyRpt.Load(VariableBuilder.DirectoryLocation + "\\_REPORT\\RptMostItem.rpt");
            var records = new List<ItemMostRptModel>();
            if (typeValue == ItemMostRptModel.TYPE_TOP) 
            {
                records = ItemMostRptModel.getTop();
                title = "TOP 10 BEST SELLING";
            }
            else if(typeValue == ItemMostRptModel.TYPE_DOWN)
            {
                records = ItemMostRptModel.getDown();
                title = "DOWN 10 SELLING";
            }
            
            cyRpt.Database.Tables["mostItem"].SetDataSource(records);
            cyRpt.SetParameterValue("store_name", VariableBuilder.PermanentVar.storeIndentity.Name);
            cyRpt.SetParameterValue("store_address", VariableBuilder.PermanentVar.storeIndentity.Address);
            cyRpt.SetParameterValue("store_phone", "Telp.  " + VariableBuilder.PermanentVar.storeIndentity.Phone);
            cyRpt.SetParameterValue("print_date", DateTime.Now.ToString("yyyy MMMM dd HH:mm:ss"));
            cyRpt.SetParameterValue("title", title);
            mostReportViewer.ReportSource = cyRpt;
        }
    }
}
