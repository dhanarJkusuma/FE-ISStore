using Sales.libs;
using Sales.model;
using Sales.ui.inventory.category.processForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.ui.inventory.category
{
    public partial class categoryForm : Form
    {
        public categoryForm()
        {
            InitializeComponent();
            refreshData();
            setMenu();
        }

        public void refreshData() 
        {
            categoryGrid.DataSource = Category.All();
            categoryGrid.ReadOnly = true;
            categoryGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void setMenu() 
        {
            List<Sales.model.SalesMenu.CompareRole> role = SalesMenu.getAuth(VariableBuilder.Session.userLogged.Group, 2, "T003B2");
            Sales.model.SalesMenu.CompareRole rlv = role.Find(rl => rl.MenuID == "T003B2P1");
            if (rlv.isActived == 1)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }

            rlv = role.Find(rl => rl.MenuID == "T003B2P2");
            if (rlv.isActived == 1)
            {
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }

            rlv = role.Find(rl => rl.MenuID == "T003B2P3");
            if (rlv.isActived == 1)
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (categoryGrid.SelectedRows.Count == 1) 
            {
                DataGridViewRow selected = categoryGrid.SelectedRows[0];
                Category selectedCategory = Category.Find(selected.Cells[0].Value.ToString());
                editCategory editForm = new editCategory(this);
                editForm.CurrentCategory = selectedCategory;
                Helper.Forms.startForm(editForm);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            newCategory newForm = new newCategory(this);
            Helper.Forms.startForm(newForm);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete this data?", "Dialog Confirmation", MessageBoxButtons.YesNo);
            //MessageBox.Show(dialogResult.ToString())
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in categoryGrid.SelectedRows)
                {
                    if (!row.Cells[0].Value.ToString().Equals("CTGOTHER"))
                    {
                        Category.Destroy(row.Cells[0].Value.ToString());
                    }
                    else 
                    {
                        MessageBox.Show("Cannot delete default category");
                    }
                    
                }
                refreshData();
            }
        }

        private void tSearch_TextChanged(object sender, EventArgs e)
        {
            Helper.Data.setBinding(categoryGrid, "Name", tSearch.Text);
        }



    }
}
