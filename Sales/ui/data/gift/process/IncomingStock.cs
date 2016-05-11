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

namespace Sales.ui.data.gift.process
{
    public partial class IncomingStock : Form
    {
        private Gift currentGift;

        internal Gift CurrentGift
        {
            get { return currentGift; }
            set { currentGift = value; }
        }

        private BaseForm home;
        public IncomingStock(BaseForm home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void IncomingStock_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CurrentGift.Item_stock = CurrentGift.Item_stock + Convert.ToInt32(tStock.Text);
            CurrentGift.Update();
            home.refreshData();
            this.Dispose();

        }
    }
}
