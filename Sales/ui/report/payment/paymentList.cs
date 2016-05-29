using Sales.libs;
using Sales.model;
using Sales.ui.report.payment.detail;
using Sales.ui.report.payment.reportForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.ui.report.payment
{
    public partial class paymentList : Form
    {
        private String[] selectedColumns = {
                                                VariableBuilder.Table.TrxPayment + ".trx_no as TrxNo",
                                                VariableBuilder.Table.User + "." + User.Columns[1],
                                                VariableBuilder.Table.Member + "." + Member.Columns[1],
                                                VariableBuilder.Table.TrxPayment + ".total_amount",
                                                VariableBuilder.Table.TrxPayment + ".created_at",
                                                
                                            };
        public paymentList()
        {
            InitializeComponent();
            firstDate.Value = DateTime.Now;
            secondDate.Value = DateTime.Now;
            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            detailPayment payment = new detailPayment();
            payment.Payment = TrxPayment.Find(paymentGrid.SelectedRows[0].Cells[0].Value.ToString());
            payment.Items = TrxPaymentItem.Find(paymentGrid.SelectedRows[0].Cells[0].Value.ToString());
            payment.Modi = paymentGrid.SelectedRows[0].Cells[1].Value.ToString();
            Helper.Forms.startForm(payment);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            reportPayment report = new reportPayment(paymentGrid.SelectedRows[0].Cells[0].Value.ToString());
            Helper.Forms.startForm(report);
           
        }

        private void reloadView() 
        {
            paymentGrid.DataSource = TrxPayment.query()
                                                .innerJoin(VariableBuilder.Table.User)
                                                .on(
                                                    VariableBuilder.Table.TrxPayment + "." + TrxPayment.Columns[1]
                                                    + "=" +
                                                    VariableBuilder.Table.User + "." + User.Columns[0]
                                                )
                                                .leftJoin(VariableBuilder.Table.Member)
                                                .on(
                                                    VariableBuilder.Table.TrxPayment + "." + TrxPayment.Columns[2]
                                                    + "=" +
                                                    VariableBuilder.Table.Member + "." + Member.Columns[0]
                                                )
                                                .where(VariableBuilder.Table.TrxPayment + ".is_processed=1")
                                                .and(
                                                    VariableBuilder.Table.TrxPayment
                                                    + ".created_at BETWEEN '" +
                                                    firstDate.Value.ToString("yyyy-MM-dd") + " 00:00:00"
                                                    + "' and '" +
                                                    secondDate.Value.ToString("yyyy-MM-dd") + " 23:59:59'")
                                                .GetData(selectedColumns);
            paymentGrid.ReadOnly = true;
            paymentGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void paymentList_Load(object sender, EventArgs e)
        {
            
        }

        private void firstDate_ValueChanged(object sender, EventArgs e)
        {
            reloadView();
        }

        private void secondDate_ValueChanged(object sender, EventArgs e)
        {
            reloadView();
        }
    }
}
