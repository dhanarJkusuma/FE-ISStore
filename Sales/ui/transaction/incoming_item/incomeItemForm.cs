using Sales.libs;
using Sales.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;using System.Text;
using System.Windows.Forms;

namespace Sales.ui.transaction.incoming_item
{
    public partial class incomeItemForm : BaseFormSuggest
    {
        private Double amount=0;
        private suggestItem suggestForm;
        private List<TrxInvIncomeItem> selectedItem=new List<TrxInvIncomeItem>();
        public incomeItemForm()
        {
            InitializeComponent();
            suggestForm = new suggestItem(new Point(tBarcode.Location.X , tBarcode.Location.Y + tBarcode.Height + 40), this);
            
            itemGridList.Columns[0].ReadOnly = true;
            itemGridList.Columns[1].ReadOnly = true;
            itemGridList.Columns[2].ReadOnly = true;
            itemGridList.Columns[3].ReadOnly = false;
            itemGridList.Columns[4].ReadOnly = false;
            itemGridList.Columns[5].ReadOnly = true;
            itemGridList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void tBarcode_TextChanged(object sender, EventArgs e)
        {
            if (tBarcode.Text.Length > 3)
            {
                Helper.Forms.startForm(suggestForm);

                //barangSuggest.ShowDialog();
                suggestForm.bindData(tBarcode.Text);

                tBarcode.Focus();
            }
            else
            {
                suggestForm.Hide();
            }
        }

        public override void populateItem(Item item)
        {
            base.populateItem(item);
            tBarcode.Text = item.Barcode;
            tName.Text = item.Name;
            tPrice.Text = item.Price;
        }

       
        private void incomeItemForm_Load(object sender, EventArgs e)
        {
            tTrxNo.Text = TrxInvIncome.generateTrxNo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (selectedItem.Find(item => item.ItemBarcode == tBarcode.Text) == null)
            {
                Double total = Convert.ToInt32(tQty.Text) * Convert.ToDouble(tBuy.Text);
                amount += total;
                TrxInvIncomeItem cart = new TrxInvIncomeItem();
                cart.ItemBarcode = tBarcode.Text;
                cart.ItemQuantity = Convert.ToInt32(tQty.Text);
                cart.ItemPurchase = Convert.ToDouble(tBuy.Text);
                selectedItem.Add(cart);
                itemGridList.Rows.Add(tBarcode.Text, tName.Text, tPrice.Text, tQty.Text, tBuy.Text, Convert.ToInt32(tQty.Text) * Convert.ToDouble(tBuy.Text) + ".00");
                tTotal.Text = Helper.Data.rupiahParser(amount.ToString());
            }
            else 
            {
                MessageBox.Show("Item you selected is already exist.");
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (itemGridList.SelectedRows.Count == 1) 
            {
                amount -= Convert.ToDouble(itemGridList.SelectedRows[0].Cells[5].Value.ToString());
                tTotal.Text = Helper.Data.rupiahParser(Convert.ToDouble(amount).ToString());
                TrxInvIncomeItem targeted = new TrxInvIncomeItem();
                targeted.ItemBarcode = itemGridList.SelectedRows[0].Cells[0].Value.ToString();
                targeted.ItemQuantity = Convert.ToInt32(itemGridList.SelectedRows[0].Cells[3].Value.ToString());
                targeted.ItemPurchase = Convert.ToDouble(itemGridList.SelectedRows[0].Cells[4].Value.ToString());
                selectedItem.Remove(targeted);
                itemGridList.Rows.Remove(itemGridList.SelectedRows[0]);
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            TrxInvIncome trxInv = new TrxInvIncome();
            trxInv.Amount = amount;
            trxInv.New();
            for (int i = 0; i < selectedItem.Count; i++) 
            {
                selectedItem[i].TrxNo = trxInv.TrxNo;
                selectedItem[i].New();
            }
            DialogResult dialogResult = MessageBox.Show("Process this data?", "Dialog Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String[] iparams = {"pStrTrxNo"};
                String[] values = { trxInv.TrxNo };
                DatabaseBuilder.usingStoredProcedure("SP_TRX_INV_INCOME_ITEM", iparams, values);
            }
            else 
            {
                this.Dispose();
            }
        }

        private void itemGridList_EditModeChanged(object sender, EventArgs e)
        {
            
        }

        private void itemGridList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && itemGridList.SelectedRows.Count > 0) 
            {
                String barcode = itemGridList.Rows[e.RowIndex].Cells[0].Value.ToString();
                Int32 newQty = Convert.ToInt32(itemGridList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                selectedItem.Find(item => item.ItemBarcode == barcode).ItemQuantity = newQty;
                amount -= Convert.ToDouble(itemGridList.Rows[e.RowIndex].Cells[5].Value);
                amount += Convert.ToDouble(itemGridList.Rows[e.RowIndex].Cells[4].Value) * newQty;
                tTotal.Text = Helper.Data.rupiahParser(amount.ToString());
                itemGridList.Rows[e.RowIndex].Cells[5].Value = Convert.ToDouble(itemGridList.Rows[e.RowIndex].Cells[4].Value) * newQty;
            }
            if (e.ColumnIndex == 4 && itemGridList.SelectedRows.Count > 0) 
            {
                String barcode = itemGridList.Rows[e.RowIndex].Cells[0].Value.ToString();
                selectedItem.Find(item => item.ItemBarcode == barcode).ItemPurchase = Convert.ToDouble(itemGridList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                Double newPurchase = Convert.ToDouble(itemGridList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                amount -= Convert.ToDouble(itemGridList.Rows[e.RowIndex].Cells[5].Value);
                amount += newPurchase * Convert.ToInt32(itemGridList.Rows[e.RowIndex].Cells[3].Value);
                tTotal.Text = Helper.Data.rupiahParser(amount.ToString());
                itemGridList.Rows[e.RowIndex].Cells[5].Value = newPurchase * Convert.ToInt32(itemGridList.Rows[e.RowIndex].Cells[3].Value);
            }
        }
    }
}
