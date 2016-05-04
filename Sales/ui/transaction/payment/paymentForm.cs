using Sales.libs;
using Sales.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.ui.transaction.payment
{
    public partial class paymentForm : BaseFormSuggest
    {
        private suggestMember memberForm;
        private Member customer;
        
        public paymentForm()
        {
            InitializeComponent();
            if (VariableBuilder.Session.userLogged != null) 
            {
                tCashier.Text = VariableBuilder.Session.userLogged.Name;
                tDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                tCustomer.Text = "General";
            }
            setGrid();
            memberForm = new suggestMember(new Point(memberBtn.Location.X, memberBtn.Location.Y + memberBtn.Height + 5), this);
        }

        private void memberBtn_Click(object sender, EventArgs e)
        {
            memberForm.Show();

        }

        public override void populateMember(Member member)
        {
            base.populateMember(member);
            this.customer = member;
            tCustomer.Text = this.customer.Name;
        }

        private void setGrid() 
        {
            itemGrid.Columns[0].ReadOnly = false;
            itemGrid.Columns[1].ReadOnly = false;
            itemGrid.Columns[2].ReadOnly = true;
            itemGrid.Columns[3].ReadOnly = true;
            itemGrid.Columns[4].ReadOnly = true;
            itemGrid.Columns[5].ReadOnly = true;
            itemGrid.Columns[6].ReadOnly = true;

        }

        private void itemGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && itemGrid.SelectedRows.Count > 0) 
            {
                Item item = Item.Find(itemGrid.SelectedRows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                if (item != null) 
                {
                    if (Item.getQty(item.Barcode) > Convert.ToInt32(item.StockAlert)) 
                    {
                        itemGrid.SelectedRows[e.RowIndex].Cells[2].Value = item.Name;
                    }
                    else if (Item.getQty(item.Barcode) == Convert.ToInt32(item.StockAlert))
                    {
                        itemGrid.SelectedRows[e.RowIndex].Cells[2].Value = item.Name;
                        MessageBox.Show("The item is on stock alert");
                    }
                    else 
                    {
                        MessageBox.Show("The item is out of stock.");
                    }
                }
            }
            else if(e.ColumnIndex == 1 && itemGrid.SelectedRows.Count > 0)
            {
                if (itemGrid.SelectedRows[e.RowIndex].Cells[0].Value != "" && itemGrid.SelectedRows[e.RowIndex].Cells[0].Value != null) 
                {
                    String barcode = itemGrid.SelectedRows[e.RowIndex].Cells[0].Value.ToString();
                    Int32 itemCount = Item.getQty(barcode);
                    if ( Convert.ToInt32(itemGrid.SelectedRows[e.RowIndex].Cells[1].Value) <= itemCount) 
                    {
                        
                    }
                
                }
            }
        }
    }
}
