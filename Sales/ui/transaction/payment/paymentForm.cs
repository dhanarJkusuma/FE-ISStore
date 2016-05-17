using Sales.libs;
using Sales.model;
using Sales.report_model;
using Sales.ui.transaction.payment.report_payment;
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
        private String paymentStr = "";

        public String PaymentStr
        {
            get { return paymentStr; }
            set { paymentStr = value; }
        }
        private String cashBackStr = "";

        public String CashBackStr
        {
            get { return cashBackStr; }
            set { cashBackStr = value; }
        }
        private List<TrxPaymentItem> items = new List<TrxPaymentItem>();
        private List<Item> gridContainer = new List<Item>();
        private List<ItemPaymentRptModel> itemsRpt = new List<ItemPaymentRptModel>();
        private Double amount=0;
        private Double payment = 0;

        
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
            memberForm = new suggestMember(this);
            itemGrid.CurrentCell = itemGrid.Rows[0].Cells[0];
            itemGrid.Focus();
            itemGrid.BeginEdit(true);
            tTotal.Text = "Rp. 0,00";
            tPayment.Text = Helper.Data.rupiahParser(paymentStr);
            tCashback.Text = "Rp. 0,00";
            tTrxNo.Text = TrxPayment.generateTrxNo();
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
                            Int32 qty = Item.getQty(item.Barcode);
                            if (qty > Convert.ToInt32(item.StockAlert))
                            {
                                itemGrid.Rows[e.RowIndex].Cells[2].Value = item.Name;
                                itemGrid.Rows[e.RowIndex].Cells[3].Value = Unit.getUnitName(item.Unit);
                                itemGrid.Rows[e.RowIndex].Cells[4].Value = item.Price;
                                if (itemGrid.Rows[e.RowIndex].Cells[1].Value != null) 
                                {
                                    if (itemGrid.Rows[e.RowIndex].Cells[1].Value.ToString().Length > 0)
                                    {
                                        itemGrid.Rows[e.RowIndex].Cells[5].Value = Convert.ToDouble(itemGrid.Rows[e.RowIndex].Cells[4].Value) * Convert.ToInt32(itemGrid.Rows[e.RowIndex].Cells[1].Value);
                                        setAmount();
                                        cashBackStr = (Convert.ToDouble((paymentStr == "") ? "0" : paymentStr) - Convert.ToDouble(amount)).ToString();
                                        tCashback.Text = Helper.Data.rupiahParser(cashBackStr);
                                    }
                                }
                            }
                            else if (qty <= Convert.ToInt32(item.StockAlert) && qty > 0)
                            {
                                itemGrid.Rows[e.RowIndex].Cells[2].Value = item.Name;
                                itemGrid.Rows[e.RowIndex].Cells[3].Value = Unit.getUnitName(item.Unit);
                                itemGrid.Rows[e.RowIndex].Cells[4].Value = item.Price;
                                MessageBox.Show("The item is on stock alert");
                            }
                            else if (qty == 0)
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
                    itemGrid.Rows[e.RowIndex].Cells[1].Value = null;
                    itemGrid.Rows[e.RowIndex].Cells[2].Value = "";
                    itemGrid.Rows[e.RowIndex].Cells[3].Value = "";
                    itemGrid.Rows[e.RowIndex].Cells[4].Value = "";
                    itemGrid.Rows[e.RowIndex].Cells[5].Value = null;
                    setAmount();
                    cashBackStr = (Convert.ToDouble((paymentStr == "") ? "0" : paymentStr) - Convert.ToDouble(amount)).ToString();
                    tCashback.Text = Helper.Data.rupiahParser(cashBackStr);
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
                            itemGrid.Rows[e.RowIndex].Cells[5].Value = Convert.ToDouble(itemGrid.Rows[e.RowIndex].Cells[4].Value) * Convert.ToInt32(itemGrid.Rows[e.RowIndex].Cells[1].Value);
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
                if (row.Cells[5].Value != null)
                {
                    amount += Convert.ToDouble(row.Cells[5].Value.ToString());                    
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

        public void bindPayment() 
        {
            if (paymentStr.Length > 0) 
            {
                tPayment.Text = Helper.Data.rupiahParser(paymentStr);
                payment = Convert.ToDouble(paymentStr);
            }
            
            tCashback.Text = Helper.Data.rupiahParser(cashBackStr);
        }

        private void tPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)8)
            {
                if (paymentStr.Length > 0) 
                {
                    paymentStr = paymentStr.Substring(0, paymentStr.Length - 1);
                    tPayment.Text = Helper.Data.rupiahParser(paymentStr);
                    if (paymentStr == "") 
                    {
                        payment = Convert.ToDouble(0);
                    }
                }
                
            }
            else if (char.IsNumber(e.KeyChar)) 
            {
                paymentStr += e.KeyChar.ToString();
                tPayment.Text = Helper.Data.rupiahParser(paymentStr);
                payment = Convert.ToDouble(paymentStr);
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

        private void btnPay_Click(object sender, EventArgs e)
        {
            payForm pay = new payForm(this);
            pay.PaymentStr = paymentStr;
            pay.CashBackStr = cashBackStr;
            pay.Amount = amount;
            Helper.Forms.startForm(pay);

        }

        public void PayProcess() 
        {
            if (payment >= amount)
            {
                DialogResult dialogResult = MessageBox.Show("Confirm Payment?", "Dialog Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    TrxPayment vpayment = new TrxPayment();
                    vpayment.TrxNo = tTrxNo.Text;
                    if (customer != null)
                    {
                        vpayment.MemberID = customer.Id;
                    }
                    vpayment.TotalAmount = amount;
                    vpayment.Discount = 0;
                    vpayment.TotalPay = payment;
                    vpayment.CashBack = payment - amount;
                    vpayment.New();
                    getItemList();
                    String[] iparams = { "pStrTrxNo" };
                    String[] values = { vpayment.TrxNo };
                    DatabaseBuilder.usingStoredProcedure("SP_TRX_PAYMENT", iparams, values, "Process Success.");
                    if (customer != null)
                    {
                        if (VariableBuilder.PermanentVar.storeIndentity.IncrementPoint != 0)
                        {
                            Double pointInc = Math.Round(amount / VariableBuilder.PermanentVar.storeIndentity.IncrementPoint, 0);
                            customer.setPoint(Convert.ToInt64(customer.Point + pointInc));
                        }

                    }


                    printTrx();

                }
            }
            else
            {
                MessageBox.Show("Please pay your order.");
            }
        
        }

        private void tDiscount_TextChanged(object sender, EventArgs e)
        {
            setAmount();
            tCashback.Text = Helper.Data.rupiahParser((payment - amount).ToString());
        }

        private void getItemList() 
        {
            foreach (DataGridViewRow row in itemGrid.Rows) 
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null) 
                {
                    TrxPaymentItem newItem = new TrxPaymentItem();
                    newItem.TrxNo = tTrxNo.Text;
                    newItem.ItemBarcode = row.Cells[0].Value.ToString();
                    newItem.Qty = Convert.ToInt32(row.Cells[1].Value);
                    newItem.New();

                    ItemPaymentRptModel modelItem = new ItemPaymentRptModel();
                    modelItem.Barcode = row.Cells[0].Value.ToString();
                    modelItem.Item_name = row.Cells[2].Value.ToString();
                    modelItem.Qty = Convert.ToInt32(row.Cells[1].Value);
                    modelItem.Price = Helper.Data.rupiahParser(Convert.ToDouble(row.Cells[4].Value).ToString());
                    modelItem.Sub_total = Helper.Data.rupiahParser(Convert.ToDouble(row.Cells[5].Value).ToString());
                    itemsRpt.Add(modelItem);
                }                                
            }
        }

        private void printTrx() 
        {
            paymentReport rpt = new paymentReport();
            rpt.Items = itemsRpt;
            rpt.TrxNo = tTrxNo.Text;
            rpt.Amount = Helper.Data.rupiahParser(amount.ToString());
            rpt.Payment = Helper.Data.rupiahParser(paymentStr);
            rpt.Cashback = Helper.Data.rupiahParser(cashBackStr);
            Helper.Forms.startForm(rpt);
        }

        private void tPayment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) 
            {
                payForm pay = new payForm(this);
                pay.PaymentStr = paymentStr;
                pay.CashBackStr = cashBackStr;
                pay.Amount = amount;
                Helper.Forms.startForm(pay);
            }
        }

        private void paymentForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void itemGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B) 
            {
                payForm pay = new payForm(this);
                pay.PaymentStr = paymentStr;
                pay.CashBackStr = cashBackStr;
                pay.Amount = amount;
                Helper.Forms.startForm(pay);
            }
        }



    }
}
