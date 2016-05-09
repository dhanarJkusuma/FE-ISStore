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
    public partial class userChPass : Form
    {
        private User currentUser;

        public User CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }

        public userChPass()
        {
            InitializeComponent();
        }

        private void userChPass_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tPassword.Text.Equals(tPasswordConf.Text))
            {
                CurrentUser.Password = tPassword.Text;
                CurrentUser.Update();
            }
            else 
            {
                MessageBox.Show("Missmatch Password Confirmation.");
            }
        }
    }
}
