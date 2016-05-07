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

namespace Sales.ui.report.down10
{
    public partial class downItemForm : Form
    {
        public downItemForm()
        {
            InitializeComponent();
            downItemGrid.DataSource = DatabaseBuilder.query("SELECT * FROM V_DOWN_10_ITEM");
            downItemGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            downItemGrid.ReadOnly = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            mostItemReport.mostItemReport report = new mostItemReport.mostItemReport(ItemMostRptModel.TYPE_DOWN);
            Helper.Forms.startForm(report);
        }
    }
}
