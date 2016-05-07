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

namespace Sales.ui.transaction.draft_incoming_item
{
    public partial class listIncomingItem : BaseForm
    {
        private String[] selectedColumns = { 
                                            VariableBuilder.Table.TrxInvIncome + "." + TrxInvIncome.Columns[0],
                                            VariableBuilder.Table.User + "." + User.Columns[1],
                                            VariableBuilder.Table.TrxInvIncome + "." + TrxInvIncome.Columns[3],
                                            VariableBuilder.Table.TrxInvIncome + "." + TrxInvIncome.Columns[4]
                                           };
        public listIncomingItem()
        {
            InitializeComponent();
            refreshData();
            if (incomeList.Rows.Count > 0)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                incomeList.Columns.Add(btn);
                btn.HeaderText = "Action";
                btn.Text = "Details";
                btn.Name = "btnDetails";
                btn.UseColumnTextForButtonValue = true;
            }
        }

        public override void refreshData()
        {
            base.refreshData();

            DataTable dt = TrxInvIncome.query()
                                                .innerJoin(VariableBuilder.Table.User)
                                                .on(
                                                    VariableBuilder.Table.TrxInvIncome + "." + TrxInvIncome.Columns[1]
                                                    + "=" +
                                                    VariableBuilder.Table.User + "." + User.Columns[0]
                                                )
                                                .where(VariableBuilder.Table.TrxInvIncome + "." + TrxInvIncome.Columns[5] + "=0")
                                                .GetData(selectedColumns);
            incomeList.DataSource = dt;
            incomeList.ReadOnly = true;
            incomeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

           
        }

        private void incomeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) 
            {
                //MessageBox.Show(incomeList.SelectedRows[0].Cells[1].Value.ToString());
                incomeItemDetail detail = new incomeItemDetail(this);
                detail.vTrxInvIncome = TrxInvIncome.Find(incomeList.SelectedRows[0].Cells[1].Value.ToString());
                detail.Items = TrxInvIncomeItem.Find(incomeList.SelectedRows[0].Cells[1].Value.ToString());
                Helper.Forms.startForm(detail);
            }
        }

        private void listIncomingItem_Load(object sender, EventArgs e)
        {

        }
    }
}
