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
        String paymentStr = "";
        String cashBackStr = "";
        private List<TrxPaymentItem> items = new List<TrxPaymentItem>();
        private List<Item> gridContainer = new List<Item>();
        private Double amount=0;
        
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
            itemGrid.CurrentCell = itemGrid.Rows[0].Cells[0];
            itemGrid.Focus();
            itemGrid.BeginEdit(true);
            tTotal.Text = "Rp. 0,00";
            tPayment.Text = Helper.Data.rupiahParser(paymentStr);
            tCashback.Text = "Rp. 0,00";
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
            if (e.ColumnIndex == 0 && itemGrid.SelectedCells.Count == 1) 
            {
                if (itemGrid.SelectedCells[0].Value != null)
                {
                    if (itemGrid.SelectedCells[0].Value.ToString().Length > 0) 
                    {
                        Item item = Item.Find(itemGrid.SelectedCells[0].Value.ToString());
                        if (item.Barcode != null)
                        {
                            if (Item.getQty(item.Barcode) > Convert.ToInt32(item.StockAlert))
                            {
                                itemGrid.Rows[e.RowIndex].Cells[2].Value = item.Name;
                                itemGrid.Rows[e.RowIndex].Cells[3].Value = Unit.getUnitName(item.Unit);
                                itemGrid.Rows[e.RowIndex].Cells[4].Value = item.Price;
                                gridContainer.Add(item);
                                if (itemGrid.Rows[e.RowIndex].Cells[1].Value != null) 
                                {
                                    if (itemGrid.Rows[e.RowIndex].Cells[1].Value.ToString().Length > 0)
                                    {
                                        itemGrid.Rows[e.RowIndex].Cells[6].Value = Convert.ToDouble(itemGrid.Rows[e.RowIndex].Cells[4].Value) * Convert.ToInt32(itemGrid.Rows[e.RowIndex].Cells[1].Value);
                                        setAmount();
                                        cashBackStr = (Convert.ToDouble((paymentStr == "") ? "0" : paymentStr) - Convert.ToDouble(amount)).ToString();
                                        tCashback.Text = Helper.Data.rupiahParser(cashBackStr);
                                    }
                                }
                            }
                            else if (Item.getQty(item.Barcode) == Convert.ToInt32(item.StockAlert))
                            {
                                itemGrid.Rows[e.RowIndex].Cells[2].Value = item.Name;
                                itemGrid.Rows[e.RowIndex].Cells[3].Value = Unit.getUnitName(item.Unit);
                                itemGrid.Rows[e.RowIndex].Cells[4].Value = item.Price;
                                gridContainer.Add(item);
                                MessageBox.Show("The item is on stock alert");
                            }
                            else
                            {
                                MessageBox.Show("The item is out of stock.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("The item is not found. [404]");
                            itemGrid.Rows[e.RowIndex].Cells[0].Value = "";
                            itemGrid.Rows[e.RowIndex].Cells[2].Value = "";
                            itemGrid.Rows[e.RowIndex].Cells[3].Value = "";
                            itemGrid.Rows[e.RowIndex].Cells[4].Value = "";
                        }
                    }
                }
                else 
                {
                    itemGrid.Rows[e.RowIndex].Cells[0].Value = "";
                    itemGrid.Rows[e.RowIndex].Cells[2].Value = "";
                    itemGrid.Rows[e.RowIndex].Cells[3].Value = "";
                    itemGrid.Rows[e.RowIndex].Cells[4].Value = "";
                }
            }
            else if (e.ColumnIndex == 1 && itemGrid.SelectedCells.Count > 0)
            {
                if (itemGrid.Rows[e.RowIndex].Cells[0].Value != null) 
                {
                    if (itemGrid.Rows[e.RowIndex].Cells[0].Value.ToString().Length > 0)
                    {
                        String barcode = itemGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                        Int32 itemCount = Item.getQty(barcode);
                        if (Convert.ToInt32(itemGrid.Rows[e.RowIndex].Cells[1].Value) <= itemCount)
                        {
                            TrxPaymentItem item = new TrxPaymentItem();
                            item.ItemBarcode = barcode;
                            item.Qty = Convert.ToInt32(itemGrid.Rows[e.RowIndex].Cells[1].Value);
                            items.Add(item);
                            itemGrid.Rows[e.RowIndex].Cells[6].Value = Convert.ToDouble(itemGrid.Rows[e.RowIndex].Cells[4].Value) * Convert.ToInt32(itemGrid.Rows[e.RowIndex].Cells[1].Value);
                            setAmount();
                            cashBackStr = (Convert.ToDouble((paymentStr == "") ? "0" : paymentStr) - Convert.ToDouble(amount)).ToString();
                            tCashback.Text = Helper.Data.rupiahParser(cashBackStr);

                        }
                        else
                        {
                            MessageBox.Show("The item is out of stock. ");
                            itemGrid.SelectedCells[0].Value = 0;
                        }
                    }
                }
            }
        }

        private void itemGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (itemGrid.CurrentCell.ColumnIndex == 1) 
            {
                e.Control.KeyPress += Control_KeyPress;
            }
        }

        void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.Forms.justNumber(e);
        }

        private void setAmount() 
        {
            amount = 0;
            foreach (DataGridViewRow row in itemGrid.Rows) 
            {
                if (row.Cells[6].Value != null)
                {
                    amount += Convert.ToDouble(row.Cells[6].Value.ToString());                    
                }
            }

            tTotal.Text = Helper.Data.rupiahParser(amount.ToString());
            
        }

        private void tPayment_TextChanged(object sender, EventArgs e)
        {
            if (paymentStr.Length > 0)
            {
                cashBackStr = (Convert.ToDouble(paymentStr) - Convert.ToDouble(amount)).ToString();
                tCashback.Text = Helper.Data.rupiahParser(cashBackStr);
                //MessageBox.Show(paymentStr);
            }
            else 
            {
                cashBackStr = "";
                tCashback.Text = Helper.Data.rupiahParser(cashBackStr);
            }
            tPayment.Text = Helper.Data.rupiahParser(paymentStr);
            
        }

        private void tPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)8)
            {
                if (paymentStr.Length > 0) 
                {
                    paymentStr = paymentStr.Substring(0, paymentStr.Length - 1);
                }
                tPayment.Text = Helper.Data.rupiahParser(paymentStr);
            }
            else if (char.IsNumber(e.KeyChar)) 
            {
                paymentStr += e.KeyChar.ToString();
                tPayment.Text = Helper.Data.rupiahParser(paymentStr);
            }   
        }

        private void tPayment_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void tPayment_Enter(object sender, EventArgs e)
        {
            cashBackStr = "";
        }

        private void paymentForm_Load(object sender, EventArgs e)
        {

        }



    }
}
