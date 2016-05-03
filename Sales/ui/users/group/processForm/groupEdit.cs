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
    public partial class groupEdit : Form
    {
        private groupForm home;
        private Group currentGroup;

        internal Group CurrentGroup
        {
            get { return currentGroup; }
            set { currentGroup = value; }
        }
        public groupEdit(groupForm home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void groupEdit_Load(object sender, EventArgs e)
        {
            tName.Text = CurrentGroup.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CurrentGroup.Name = tName.Text;
            CurrentGroup.Update();
            this.Dispose();
            home.refreshData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
