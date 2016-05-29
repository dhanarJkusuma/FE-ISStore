using Sales.libs;
using Sales.model;
using Sales.ui.data.member.processForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.ui.data.member
{
    public partial class memberForm : BaseForm
    {

        private String[] selectedColumns = {
                                            VariableBuilder.Table.Member + "." + Member.Columns[0] + " as Identity_No",
                                            VariableBuilder.Table.Member + "." + Member.Columns[1] + " as Name",
                                            VariableBuilder.Table.Member + "." + Member.Columns[2] + " as Telp",
                                            VariableBuilder.Table.Member + "." + Member.Columns[3] + " as Address",
                                            VariableBuilder.Table.Member + "." + Member.Columns[4] + " as Point",
                                            VariableBuilder.Table.Provinces + ".prov_name as Province", 
                                            VariableBuilder.Table.Regencies + ".reg_name as Regency",
                                            VariableBuilder.Table.Districts + ".dis_name as District",
                                            VariableBuilder.Table.Villages + ".vill_name as Village"
                                           };
        private List<Sales.model.SalesMenu.CompareRole> role;
        public memberForm()
        {
            InitializeComponent();
            refreshData();
            role = SalesMenu.getAuth(VariableBuilder.Session.userLogged.Group, 2, "T002B1");
            setMenu();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newMember newForm = new newMember(this);
            Helper.Forms.startForm(newForm);
            
        }

        private void setMenu() 
        {
            Sales.model.SalesMenu.CompareRole rlv = role.Find(rl => rl.MenuID == "T002B1P1");
            if (rlv.isActived == 1)
            {
                btnNew.Enabled = true;
            }
            else
            {
                btnNew.Enabled = false;
            }

            rlv = role.Find(rl => rl.MenuID == "T002B1P2");
            if (rlv.isActived == 1)
            {
                editBtn.Enabled = true;
            }
            else
            {
                editBtn.Enabled = false;
            }

            rlv = role.Find(rl => rl.MenuID == "T002B1P3");
            if (rlv.isActived == 1)
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }

        public override void refreshData()
        {
            base.refreshData();

            memberGrid.DataSource = Member.query()
                                            .innerJoin(VariableBuilder.Table.Provinces)
                                            .on(
                                                VariableBuilder.Table.Member + "." + Member.Columns[5]
                                                + "=" +
                                                VariableBuilder.Table.Provinces + ".prov_code"
                                            )
                                            .innerJoin(VariableBuilder.Table.Regencies)
                                            .on(
                                                VariableBuilder.Table.Member + "." + Member.Columns[6]
                                                + "=" +
                                                VariableBuilder.Table.Regencies + ".reg_code"
                                            )
                                            .innerJoin(VariableBuilder.Table.Districts)
                                            .on(
                                                VariableBuilder.Table.Member + "." + Member.Columns[7]
                                                + "=" +
                                                VariableBuilder.Table.Districts + ".dis_code"
                                            )
                                            .innerJoin(VariableBuilder.Table.Villages)
                                            .on(
                                                VariableBuilder.Table.Member + "." + Member.Columns[8]
                                                + "=" +
                                                VariableBuilder.Table.Villages + ".vill_code"
                                            )
                                            .GetData(selectedColumns);
            memberGrid.ReadOnly = true;
            memberGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (memberGrid.SelectedRows.Count == 1) 
            {
                editMember editForm = new editMember(this);
                editForm.CurrentMember = Member.Find(Convert.ToInt64(memberGrid.SelectedRows[0].Cells[0].Value));
                Helper.Forms.startForm(editForm);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete this member?", "Dialog Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in memberGrid.SelectedRows)
                {
                    Member.Destroy(Convert.ToInt64(row.Cells[0].Value));
                }
                refreshData();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void tSearch_TextChanged(object sender, EventArgs e)
        {
            Helper.Data.setBinding(memberGrid, "Name", tSearch.Text);
        }
    }
}
