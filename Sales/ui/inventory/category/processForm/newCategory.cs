using Sales.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.ui.inventory.category.processForm
{
    public partial class newCategory : Form
    {
        private categoryForm home;
        public newCategory(categoryForm home)
        {
            InitializeComponent();
            this.home = home;
            tCode.Text = "CTG";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Category newCategory = new Category();
            newCategory.Code = tCode.Text;
            newCategory.Name = tName.Text;
            newCategory.Insert();
            home.refreshData();
            this.Dispose();
         }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tName_TextChanged(object sender, EventArgs e)
        {
            tCode.Text = "CTG" + tName.Text;
        }


    }
}
