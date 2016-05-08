using Sales.libs;
using Sales.model;
using Sales.ui.users.users.processForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.ui.users.users
{
    public partial class usersForm : Form
    {

        private String[] selectedColumns = {
                                                VariableBuilder.Table.User + "." + User.Columns[0] + " as ID",
                                                VariableBuilder.Table.User + "." + User.Columns[1] + " as UserName",
                                                VariableBuilder.Table.Group + "." + Group.Columns[1] + " as UserGroup",
                                                VariableBuilder.Table.User + "." + User.Columns[4] + " as CreatedAt"
                                           };
        public usersForm()
        {
            InitializeComponent();
            refreshData();
            setMenu();
        }

        public void refreshData() 
        {
            userGrid.DataSource = User.query()
                                      .innerJoin(VariableBuilder.Table.Group)
                                      .on(
                                            VariableBuilder.Table.User + "." + User.Columns[3]
                                            + "=" +
                                            VariableBuilder.Table.Group + "." + Group.Columns[0]
                                         )
                                      .GetData(selectedColumns);
            userGrid.ReadOnly = true;
            userGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userGrid.Columns[0].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            userNew newForm = new userNew(this);
            Helper.Forms.startForm(newForm);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (userGrid.SelectedRows.Count == 1) 
            {
                userEdit editForm = new userEdit(this);
                editForm.CurrentUser = User.Find(userGrid.SelectedRows[0].Cells[0].Value.ToString());
                Helper.Forms.startForm(editForm);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete this user?", "Dialog Confirmation", MessageBoxButtons.YesNo);
            //MessageBox.Show(dialogResult.ToString())
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in userGrid.SelectedRows)
                {
                    User.Destroy(row.Cells[0].Value.ToString());
                }
                refreshData();
            }
        }

        private void setMenu()
        {
            List<Sales.model.SalesMenu.CompareRole> role = SalesMenu.getAuth(VariableBuilder.Session.userLogged.Group, 2, "T001B2");
            Sales.model.SalesMenu.CompareRole rlv = role.Find(rl => rl.MenuID == "T001B2P1");
            if (rlv.isActived == 1)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }

            rlv = role.Find(rl => rl.MenuID == "T001B2P2");
            if (rlv.isActived == 1)
            {
                btnEdit.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
            }

            rlv = role.Find(rl => rl.MenuID == "T001B2P3");
            if (rlv.isActived == 1)
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }

    }
}
