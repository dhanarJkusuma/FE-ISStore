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
            topItemGrid.DataSource = DatabaseBuilder.query("SELECT V_TOP_10_ITEM.item_barcode, box_master_item.item_name, V_TOP_10_ITEM.qty from V_TOP_10_ITEM inner join box_master_item on V_TOP_10_ITEM.item_barcode = box_master_item.item_barcode");
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
