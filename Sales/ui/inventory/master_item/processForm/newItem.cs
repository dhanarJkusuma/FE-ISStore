using Sales.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.ui.inventory.master_item.processForm
{
    public partial class newItem : Form
    {
        private itemForm home;
        private List<Category> valueCategory;
        private List<Unit> valueUnit;
        
        public newItem(itemForm home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void newItem_Load(object sender, EventArgs e)
        {
            valueCategory = Category.FillComboBox(cCategory);
            valueUnit = Unit.FillComboBox(cUnit);
            if (valueCategory.Count > 0) 
            {
                cCategory.SelectedIndex = 0;
            }
            if (valueUnit.Count > 0) 
            {
                cUnit.SelectedIndex = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Barcode = tBarcode.Text;
            item.Name = tName.Text;
            item.Category = valueCategory[cCategory.SelectedIndex].Code;
            item.Unit = valueUnit[cUnit.SelectedIndex].Code;
            item.Price = tPrice.Text;
            item.StockAlert = tStockAlert.Text;
            item.New();
            home.refreshData();
            this.Dispose();
        }

        
    }
}

