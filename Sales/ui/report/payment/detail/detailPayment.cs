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

namespace Sales.ui.report.payment.detail
{
    public partial class detailPayment : Form
    {
        private TrxPayment payment;

        internal TrxPayment Payment
        {
            get { return payment; }
            set { payment = value; }
        }
        private List<TrxPaymentItem> items;
        

        internal List<TrxPaymentItem> Items
        {
            get { return items; }
            set { items = value; }
        }

        private String modi;

        public String Modi
        {
            get { return modi; }
            set { modi = value; }
        }
        public detailPayment()
        {
            InitializeComponent();
           
        }

        private void loadTrx() 
        {
            trxNo.Text = Payment.TrxNo;
            tMember.Text = Member.Find(Payment.MemberID).Name;
            tDate.Text = Payment.CreatedAt;
            tModi.Text = Modi;
            amount.Text = "TOTAL\t : " + Helper.Data.rupiahParser(Payment.TotalAmount.ToString());
            pay.Text = "PAY\t : "  + Helper.Data.rupiahParser(Payment.TotalPay.ToString());
            cashBack.Text = "CASHBACK\t : " + Helper.Data.rupiahParser(Convert.ToDouble(Payment.TotalPay - Payment.TotalAmount).ToString());
            profit.Text = "PROFIT\t : " + Helper.Data.rupiahParser(TrxPayment.getProfit(Payment.TrxNo).ToString());
        }

        private void loadItems() 
        {
            for (int i = 0; i < items.Count; i++) 
            {
                Item item = Item.Find(items[i].ItemBarcode);
                Double sub = items[i].Qty * Convert.ToDouble(item.Price);
                itemGrid.Rows.Add(
                        items[i].ItemBarcode,
                        item.Name,
                        items[i].Qty,
                        Helper.Data.rupiahParser(Convert.ToDouble(item.Price).ToString()),
                        Helper.Data.rupiahParser(sub.ToString())
                       );
            }
            itemGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            itemGrid.ReadOnly = true;
        }

        private void detailPayment_Load(object sender, EventArgs e)
        {
            loadTrx();
            loadItems();
        }
    }
}
