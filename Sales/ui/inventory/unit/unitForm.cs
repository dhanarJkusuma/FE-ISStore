using Sales.libs;
using Sales.model;
using Sales.ui.inventory.unit.processForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.ui.inventory.unit
{
    public partial class unitForm : Form
    {
        public unitForm()
        {
            InitializeComponent();
            refreshData();
            setMenu();
        }

        public void refreshData() 
        {
            unitGrid.DataSource = Unit.All();
            unitGrid.ReadOnly = true;
            unitGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            newUnit newForm = new newUnit(this);
            Helper.Forms.startForm(newForm);
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (unitGrid.SelectedRows.Count == 1) 
            {
                DataGridViewRow selected = unitGrid.SelectedRows[0];
                Unit selectedUnit = Unit.Find(selected.Cells[0].Value.ToString());
                editUnit editForm = new editUnit(this);
                editForm.CurrentUnit = selectedUnit;
                Helper.Forms.startForm(editForm);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete this data?", "Dialog Confirmation", MessageBoxButtons.YesNo);
            //MessageBox.Show(dialogResult.ToString())
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in unitGrid.SelectedRows)
                {
                    Unit.Destroy(row.Cells[0].Value.ToString());
                }
                refreshData();
            }
        }

        private void setMenu()
        {
            List<Sales.model.SalesMenu.CompareRole> role = SalesMenu.getAuth(VariableBuilder.Session.userLogged.Group, 2, "T003B1");
            Sales.model.SalesMenu.CompareRole rlv = role.Find(rl => rl.MenuID == "T003B1P1");
            if (rlv.isActived == 1)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }

            rlv = role.Find(rl => rl.MenuID == "T003B1P2");
            if (rlv.isActived == 1)
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }

            rlv = role.Find(rl => rl.MenuID == "T003B1P3");
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
