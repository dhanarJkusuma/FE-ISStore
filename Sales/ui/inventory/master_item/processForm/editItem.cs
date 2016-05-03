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
    public partial class editItem : Form
    {
        private Item currentItem;
        private itemForm home;
        private List<Category> categoryValue;
        private List<Unit> unitValue;

        internal Item CurrentItem
        {
            get { return currentItem; }
            set { currentItem = value; }
        }

        public editItem(itemForm home)
        {
            InitializeComponent();
            this.home = home;
            categoryValue = Category.FillComboBox(cCategory);
            unitValue = Unit.FillComboBox(cUnit);
        }

        private void editItem_Load(object sender, EventArgs e)
        {
            tBarcode.Text = CurrentItem.Barcode;
            tName.Text = CurrentItem.Name;
            cCategory.SelectedItem = categoryValue.Find(category => category.Code == CurrentItem.Category).Name;
            cUnit.SelectedItem = unitValue.Find(unit => unit.Code == CurrentItem.Unit).Name;
            tPrice.Text = CurrentItem.Price;
            tStockAlert.Text = CurrentItem.StockAlert;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CurrentItem.Barcode = tBarcode.Text;
            CurrentItem.Name = tName.Text;
            CurrentItem.Category = categoryValue[cCategory.SelectedIndex].Code;
            CurrentItem.Unit = unitValue[cUnit.SelectedIndex].Code;
            CurrentItem.Price = tPrice.Text;
            CurrentItem.StockAlert = tStockAlert.Text;
            CurrentItem.Update();
            home.refreshData();
            this.Dispose();
        }

    }
}
