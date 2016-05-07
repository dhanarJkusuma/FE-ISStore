using Sales.libs;
using Sales.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.ui.report.incoming_item.detail
{
    public partial class detailIncomeList : Form
    {
        private TrxInvIncome trxIncome;

        internal TrxInvIncome TrxIncome
        {
            get { return trxIncome; }
            set { trxIncome = value; }
        }
        private List<TrxInvIncomeItem> items;

        internal List<TrxInvIncomeItem> Items
        {
            get { return items; }
            set { items = value; }
        }

        private String modi;

        public String Modi
        {
            get { return modi; }
            set { modi = value; }
        }
        public detailIncomeList()
        {
            InitializeComponent();
        }

        private void loadTrx() 
        {
            trxNo.Text = TrxIncome.TrxNo;
            tSupplier.Text = "Supplier : " + Supplier.Find(TrxIncome.SupplierID).Name;
            tDate.Text = TrxIncome.CreatedAt;
            tModi.Text = Modi;
        }

        private void loadItems() 
        {
            itemGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            itemGrid.ReadOnly = true;
            for (int i = 0; i<items.Count; i++) 
            {
                itemGrid.Rows.Add(items[i].ItemBarcode, Helper.Data.rupiahParser(items[i].ItemQuantity.ToString()), Helper.Data.rupiahParser(items[i].ItemPurchase.ToString()), Helper.Data.rupiahParser((items[i].ItemQuantity * items[i].ItemPurchase).ToString()));
            }
        }

        private void detailIncomeList_Load(object sender, EventArgs e)
        {
            loadTrx();
            loadItems();
        }

    }
}
