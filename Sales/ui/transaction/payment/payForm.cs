using Sales.libs;
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
    public partial class payForm : Form
    {
        String paymentStr = "";

        public String PaymentStr
        {
            get { return paymentStr; }
            set { paymentStr = value; }
        }
        String cashBackStr = "";

        public String CashBackStr
        {
            get { return cashBackStr; }
            set { cashBackStr = value; }
        }
        private Double amount = 0;

        public Double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        private Double payment = 0;

        public Double Payment
        {
            get { return payment; }
            set { payment = value; }
        }
        paymentForm home;
        public payForm(paymentForm home)
        {
            InitializeComponent();
            this.home = home;
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


        private void payForm_Load(object sender, EventArgs e)
        {
            tTotal.Text = Helper.Data.rupiahParser(Amount.ToString());
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

        private void btnPay_Click(object sender, EventArgs e)
        {
            home.CashBackStr = cashBackStr;
            home.PaymentStr = paymentStr;
            home.bindPayment();
            home.PayProcess();
            this.Dispose();
        }

        private void tPayment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                home.CashBackStr = cashBackStr;
                home.PaymentStr = paymentStr;
                home.bindPayment();
                home.PayProcess();
                this.Dispose();   
            }
            else if(e.KeyCode == Keys.Escape)
            {
                home.CashBackStr = cashBackStr;
                home.PaymentStr = paymentStr;
                home.bindPayment();
                this.Dispose(); 
            }
        }
    }
}
