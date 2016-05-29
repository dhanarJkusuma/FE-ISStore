using Sales.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.ui.users.group.processForm
{
    public partial class groupNew : Form
    {
        private groupForm home;
        public groupNew(groupForm home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Group newGroup = new Group();
            newGroup.Name = tName.Text;
            newGroup.Insert();
            this.Dispose();
            home.refreshData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
