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

namespace Sales.ui.report.top10
{
    public partial class topItemForm : Form
    {
        public topItemForm()
        {
            InitializeComponent();
            topItemGrid.DataSource = DatabaseBuilder.query("SELECT * FROM V_TOP_10_ITEM");
            topItemGrid.ReadOnly = true;
            topItemGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            mostItemReport.mostItemReport report = new mostItemReport.mostItemReport(ItemMostRptModel.TYPE_TOP);
            Helper.Forms.startForm(report);
        }
    }
}
