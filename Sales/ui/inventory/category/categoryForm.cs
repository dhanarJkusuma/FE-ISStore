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
        }

        public void refreshData() 
        {
            categoryGrid.DataSource = Category.All();
            categoryGrid.ReadOnly = true;
            categoryGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                    Category.Destroy(row.Cells[0].Value.ToString());
                }
                refreshData();
            }
        }



    }
}
