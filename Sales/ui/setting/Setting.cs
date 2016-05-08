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

namespace Sales.ui.setting
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            tName.Text = VariableBuilder.Session.userLogged.Name;
            tStore.Text = VariableBuilder.PermanentVar.storeIndentity.Name;
            tPhone.Text = VariableBuilder.PermanentVar.storeIndentity.Phone;
            tAddress.Text = VariableBuilder.PermanentVar.storeIndentity.Address;
            gName.Enabled = false;
            gPassword.Enabled = false;
            gSystem.Enabled = false;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cName.Checked) 
            {
                updateName(tName.Text);
            }

            if (cPassword.Checked) 
            {
                changePassword();
            }
            if (cSystem.Checked) 
            {
                changeSystem();
            }
            MessageBox.Show("Configuration saved.");

        }

        private void changeSystem() 
        {
            VariableBuilder.PermanentVar.storeIndentity.Name = tStore.Text;
            VariableBuilder.PermanentVar.storeIndentity.Phone = tPhone.Text;
            VariableBuilder.PermanentVar.storeIndentity.Address = tAddress.Text;
            VariableBuilder.PermanentVar.storeIndentity.Update();

        }

        private void changePassword() 
        {
            if (getMatchOldPassword() && getMatchConfirmPassword())
            {
                updatePassword(tPassword.Text);
            }
            else if (!getMatchOldPassword())
            {
                MessageBox.Show("Wrong Old Password.");
            }
            else
            {
                MessageBox.Show("Missmatch Password Confirmation.");
            }
        }
        /* PASSWORD FIELD */
        private bool getMatchOldPassword() 
        {
            return EncryptBuilder.EncryptString(tOldPassword.Text).Equals(VariableBuilder.Session.userLogged.Password);
        }

        private bool getMatchConfirmPassword() 
        {
            return tPassword.Text.Equals(tConfirm.Text);
        }

        private void updatePassword(String password) 
        {
            VariableBuilder.Session.userLogged.Password = password;
            VariableBuilder.Session.userLogged.UpdateNonMessage();
        }
        /* PASSWORD SECTION */


        /* NAME SECTION */
        private void updateName(String name)
        {
            VariableBuilder.Session.userLogged.Name = name;
            VariableBuilder.Session.userLogged.UpdateNonMessage();
        }
        /* NAME SECTION */

        private void cName_CheckedChanged(object sender, EventArgs e)
        {
            if (cName.Checked)
            {
                gName.Enabled = true;
            }
            else 
            {
                gName.Enabled = false;
                tName.Text = VariableBuilder.Session.userLogged.Name;
            }
        }

        private void cPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cPassword.Checked)
            {
                gPassword.Enabled = true;
            }
            else 
            {
                gPassword.Enabled = false;
                
            }
        }

        private void cSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (cSystem.Checked)
            {
                gSystem.Enabled = true;
            }
            else 
            {
                gSystem.Enabled = false;
                tStore.Text = VariableBuilder.PermanentVar.storeIndentity.Name;
                tPhone.Text = VariableBuilder.PermanentVar.storeIndentity.Phone;
                tAddress.Text = VariableBuilder.PermanentVar.storeIndentity.Address;
            }
        }
    }
}
