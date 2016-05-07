using Sales.libs;
using Sales.model;
using Sales.ui.report.incoming_item.detail;
using Sales.ui.report.incoming_item.reportForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.ui.report.incoming_item
{
    public partial class incomingRpt : Form
    {
        private String[] selectedColumns = { 
                                            VariableBuilder.Table.TrxInvIncome + "." + TrxInvIncome.Columns[0],
                                            VariableBuilder.Table.User + "." + User.Columns[1],
                                            VariableBuilder.Table.TrxInvIncome + "." + TrxInvIncome.Columns[3],
                                            VariableBuilder.Table.TrxInvIncome + "." + TrxInvIncome.Columns[4]
                                           };
        public incomingRpt()
        {
            InitializeComponent();
            firstDate.Value = DateTime.Now;
            secondDate.Value = DateTime.Now;
            loadData();
        }

        private void loadData() 
        {
            incomingList.DataSource = TrxInvIncome.query()
                                                .innerJoin(VariableBuilder.Table.User)
                                                .on(
                                                    VariableBuilder.Table.TrxInvIncome + "." + TrxInvIncome.Columns[1]
                                                    + "=" +
                                                    VariableBuilder.Table.User + "." + User.Columns[0]
                                                )
                                                .where(VariableBuilder.Table.TrxInvIncome + "." + TrxInvIncome.Columns[5] + "=1")
                                                .and(
                                                    VariableBuilder.Table.TrxInvIncome
                                                    + ".created_at BETWEEN '" +
                                                    firstDate.Value.ToString("yyyy-MM-dd") + " 00:00:00"
                                                    + "' and '" +
                                                    secondDate.Value.ToString("yyyy-MM-dd") + " 23:59:59'")
                                                .GetData(selectedColumns);
            incomingList.ReadOnly = true;
            incomingList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            detailIncomeList income = new detailIncomeList();
            income.TrxIncome = TrxInvIncome.Find(incomingList.SelectedRows[0].Cells[0].Value.ToString());
            income.Items = TrxInvIncomeItem.Find(incomingList.SelectedRows[0].Cells[0].Value.ToString());
            income.Modi = incomingList.SelectedRows[0].Cells[1].Value.ToString();
            Helper.Forms.startForm(income);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            rptIncoming rpt = new rptIncoming(incomingList.SelectedRows[0].Cells[0].Value.ToString());
            Helper.Forms.startForm(rpt);
        }

        private void firstDate_ValueChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void secondDate_ValueChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
