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

namespace Sales.ui.users.users.processForm
{
    public partial class userNew : Form
    {
        private List<Group> groupValue;
        private usersForm home;
        public userNew(usersForm home)
        {
            InitializeComponent();
            this.home = home;
            groupValue = Group.FillComboBox(cGroup);
            cGroup.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = tUserName.Text;
            user.Password = EncryptBuilder.EncryptString(tPassword.Text);
            user.Group = groupValue[cGroup.SelectedIndex].Id;
            user.New();
            this.Dispose();
            home.refreshData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
