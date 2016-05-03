using Sales.libs;
using Sales.model;
using Sales.ui.users.group.processForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.ui.users.group
{
    public partial class groupForm : Form
    {
        public groupForm()
        {
            InitializeComponent();
            refreshData();
        }

        public void refreshData() 
        {
            groupGrid.DataSource = Group.All();
            groupGrid.ReadOnly = true;
            groupGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            groupGrid.Columns[0].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            groupNew newForm = new groupNew(this);
            Helper.Forms.startForm(newForm);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (groupGrid.SelectedRows.Count == 1) 
            {
                groupEdit editForm = new groupEdit(this);
                editForm.CurrentGroup = Group.Find(groupGrid.SelectedRows[0].Cells[0].Value.ToString());
                Helper.Forms.startForm(editForm);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete this group?", "Dialog Konfirmasi", MessageBoxButtons.YesNo);
            //MessageBox.Show(dialogResult.ToString())
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in groupGrid.SelectedRows)
                {
                    Group.Destroy(row.Cells[0].Value.ToString());
                }
                refreshData();
            }
        }

        private void groupGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
