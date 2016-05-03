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
    public partial class editCategory : Form
    {

        private Category currentCategory;

        internal Category CurrentCategory
        {
            get { return currentCategory; }
            set { currentCategory = value; }
        }
        private categoryForm home;
        public editCategory(categoryForm home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void editCategory_Load(object sender, EventArgs e)
        {
            tCode.Text = CurrentCategory.Code;
            tName.Text = CurrentCategory.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CurrentCategory.Code = tCode.Text;
            CurrentCategory.Name = tName.Text;
            CurrentCategory.Update();
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
