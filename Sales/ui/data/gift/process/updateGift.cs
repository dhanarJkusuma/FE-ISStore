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
    public partial class updateGift : Form
    {
        private Gift currentGift;

        internal Gift CurrentGift
        {
            get { return currentGift; }
            set { currentGift = value; }
        }
        private BaseForm home;
        public updateGift(BaseForm home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CurrentGift.Item_name = tName.Text;
            CurrentGift.Item_point_cost = Convert.ToInt64(tCost.Text);
            CurrentGift.Update();
            home.refreshData();
            this.Dispose();
        }

        private void updateGift_Load(object sender, EventArgs e)
        {
            tName.Text = CurrentGift.Item_name;
            tCode.Text = CurrentGift.Item_code;
            tCost.Text = CurrentGift.Item_point_cost.ToString();
            tCode.Enabled = false;
        }

        private void tCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.Forms.justNumber(e);
        }
    }
}
