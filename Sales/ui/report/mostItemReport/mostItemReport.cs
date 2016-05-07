﻿using CrystalDecisions.CrystalReports.Engine;
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
            var records = new List<ItemMostRptModel>();
            if (typeValue == ItemMostRptModel.TYPE_TOP) 
            {
                records = ItemMostRptModel.getTop();
            }
            else if(typeValue == ItemMostRptModel.TYPE_DOWN)
            {
                records = ItemMostRptModel.getDown();
            }
            cyRpt.Load(VariableBuilder.DirectoryLocation + "\\_REPORT\\RptMostItem.rpt");
            cyRpt.Database.Tables["mostItem"].SetDataSource(records);
            mostReportViewer.ReportSource = cyRpt;
        }
    }
}