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
            downItemGrid.DataSource = DatabaseBuilder.query("SELECT V_DOWN_10_ITEM.item_barcode, box_master_item.item_name, V_DOWN_10_ITEM.qty from V_DOWN_10_ITEM inner join box_master_item on V_DOWN_10_ITEM.item_barcode = box_master_item.item_barcode");
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
