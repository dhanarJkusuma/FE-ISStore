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
    public partial class editUnit : Form
    {
        private Unit currentUnit;
        private unitForm home;

        internal Unit CurrentUnit
        {
            get { return currentUnit; }
            set { currentUnit = value; }
        }

        public editUnit(unitForm home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void editUnit_Load(object sender, EventArgs e)
        {
            tCode.Text = CurrentUnit.Code;
            tName.Text = CurrentUnit.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CurrentUnit.Code = tCode.Text;
            CurrentUnit.Name = tName.Text;
            CurrentUnit.Update();
            home.refreshData();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       


    }
}
