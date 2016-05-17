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
    public partial class credentialForm : Form
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
        
        public credentialForm()
        {

            InitializeComponent();
            VariableBuilder.PermanentVar.storeIndentity = Store.getInformation();
          
        }



        private void lClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginIn();
        }

        private void loginIn() 
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
                MessageBox.Show("Invalid Login. ");
            }
        }

        private void tPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void credentialForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Keys.Enter)) 
            {
                loginIn();
            }
        }

        private void tPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                loginIn();
            }
        }


    }
}
