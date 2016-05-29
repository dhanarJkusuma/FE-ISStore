using Sales.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.ui.inventory.unit.processForm
{
    public partial class newUnit : Form
    {
        private unitForm home;
        public newUnit(unitForm home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Unit newUnit = new Unit();
            newUnit.Code = tCode.Text;
            newUnit.Name = tName.Text;
            newUnit.Insert();
            home.refreshData();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
