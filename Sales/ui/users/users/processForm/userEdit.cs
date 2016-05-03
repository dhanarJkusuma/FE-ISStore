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
    public partial class userEdit : Form
    {
        private List<Group> groupValue;
        private User currentUser;

        internal User CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }
        private usersForm home;
        public userEdit(usersForm home)
        {
            InitializeComponent();
            this.home = home;
            groupValue = Group.FillComboBox(cGroup);
        }

        private void userEdit_Load(object sender, EventArgs e)
        {
            tUserName.Text = CurrentUser.Name;
            cGroup.SelectedItem = groupValue.Find(group => group.Id == CurrentUser.Group).Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CurrentUser.Name = tUserName.Text;
            CurrentUser.Password = EncryptBuilder.EncryptString(tPassword.Text);
            CurrentUser.Group = groupValue[cGroup.SelectedIndex].Id;
            CurrentUser.Update();
            this.Dispose();
            home.refreshData();
        }

        
    }
}
