using Sales.libs;
using Sales.model;
using Sales.ui.data.gift.process;
using Sales.ui.data.girf.process;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.ui.data.girf
{
    public partial class giftForm : BaseForm
    {
        public giftForm()
        {
            InitializeComponent();
            refreshData();
        }

        public override void refreshData()
        {
            base.refreshData();
            giftList.DataSource = Gift.All();
            giftList.ReadOnly = true;
            giftList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            newGift newForm = new newGift(this);
            Helper.Forms.startForm(newForm);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (giftList.SelectedRows.Count == 1) 
            {
                updateGift up = new updateGift(this);
                up.CurrentGift = Gift.Find(giftList.SelectedRows[0].Cells[0].Value.ToString());
                Helper.Forms.startForm(up);
            }
            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (giftList.SelectedRows.Count == 1) 
            {
                Gift.Destroy(giftList.SelectedRows[0].Cells[0].Value.ToString());
                
            }
            refreshData();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (giftList.SelectedRows.Count == 1) 
            {
                IncomingStock stock = new IncomingStock(this);
                stock.CurrentGift = Gift.Find(giftList.SelectedRows[0].Cells[0].Value.ToString());
                Helper.Forms.startForm(stock);
            }
            
        }
    }
}
