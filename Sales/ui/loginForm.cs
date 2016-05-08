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

namespace Sales.ui
{
    public partial class loginForm : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public loginForm()
        {
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isLoggedIn = User.Login(tUsername.Text, EncryptBuilder.EncryptString(tPassword.Text));
            if (isLoggedIn)
            {
                mainForm home = new mainForm();
                Helper.Forms.startForm(home);
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Wrong Credentials .");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
