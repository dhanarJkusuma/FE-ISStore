using Sales.libs;
using Sales.ui.data.member;
using Sales.ui.data.supplier;
using Sales.ui.inventory.category;
using Sales.ui.inventory.master_item;
using Sales.ui.inventory.master_stock;
using Sales.ui.inventory.stock_alert;
using Sales.ui.inventory.unit;
using Sales.ui.transaction.draft_incoming_item;
using Sales.ui.transaction.incoming_item;
using Sales.ui.users.group;
using Sales.ui.users.users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            unitForm unit = new unitForm();
            Helper.Forms.startForm(unit);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            categoryForm category = new categoryForm();
            Helper.Forms.startForm(category);
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            itemForm item = new itemForm();
            Helper.Forms.startForm(item);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            stockForm stock = new stockForm();
            Helper.Forms.startForm(stock);
        }

        private void btnAlert_Click(object sender, EventArgs e)
        {
            alertForm alert = new alertForm();
            Helper.Forms.startForm(alert);
        }

        private void btnIncomeItem_Click(object sender, EventArgs e)
        {
            incomeItemForm incomingItem = new incomeItemForm();
            Helper.Forms.startForm(incomingItem);
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            groupForm group = new groupForm();
            Helper.Forms.startForm(group);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            usersForm users = new usersForm();
            Helper.Forms.startForm(users);
        }

        private void btnListIncome_Click(object sender, EventArgs e)
        {
            listIncomingItem listIncome = new listIncomingItem();
            Helper.Forms.startForm(listIncome);
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            memberForm member = new memberForm();
            Helper.Forms.startForm(member);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            supplierForm supplier = new supplierForm();
            Helper.Forms.startForm(supplier);
        }
    }
}
