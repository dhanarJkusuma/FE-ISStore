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

namespace Sales.ui.data.girf.process
{
    public partial class newGift : Form
    {
        private BaseForm home;
        public newGift(BaseForm home)
        {
            InitializeComponent();
            tCode.Text = Gift.generateGiftNo();
            tCode.Enabled = false;
            this.home = home;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Gift gift = new Gift();
            gift.Item_code = tCode.Text;
            gift.Item_name = tName.Text;
            gift.Item_point_cost = Convert.ToInt64(tCost.Text);
            gift.Insert();
            home.refreshData();
            this.Dispose();
        }
    }
}
