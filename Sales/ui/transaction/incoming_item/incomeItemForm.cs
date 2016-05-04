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
        private Supplier selectedSupplier;
        private suggestItem suggestForm;
        private suggestSupplier suggestSuppForm;
        private List<TrxInvIncomeItem> selectedItem=new List<TrxInvIncomeItem>();
        public incomeItemForm()
        {
            InitializeComponent();
            suggestForm = new suggestItem(new Point(tBarcode.Location.X , tBarcode.Location.Y + tBarcode.Height + 40), this);
            suggestSuppForm = new suggestSupplier(this);
            itemGridList.Columns[0].ReadOnly = true;
            itemGridList.Columns[1].ReadOnly = true;
            itemGridList.Columns[2].ReadOnly = true;
            itemGridList.Columns[3].ReadOnly = false;
            itemGridList.Columns[4].ReadOnly = false;
            itemGridList.Columns[5].ReadOnly = true;
            itemGridList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tTotal.Text = "Rp. 0,00";
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
                tName.Text = "";
                tPrice.Text = "";
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
                TrxInvIncomeItem cart = new TrxInvIncomeItem();
                cart.ItemBarcode = tBarcode.Text;
                cart.ItemQuantity = Convert.ToInt32(tQty.Text);
                cart.ItemPurchase = Convert.ToDouble(tBuy.Text);
                selectedItem.Add(cart);
                itemGridList.Rows.Add(tBarcode.Text, tName.Text, tPrice.Text, tQty.Text, tBuy.Text, Convert.ToInt32(tQty.Text) * Convert.ToDouble(tBuy.Text) + ".00");
                setAmount();
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
                selectedItem.RemoveAll(item => item.ItemBarcode == itemGridList.SelectedRows[0].Cells[0].Value.ToString());
                itemGridList.Rows.Remove(itemGridList.SelectedRows[0]);
            }
            setAmount();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            TrxInvIncome trxInv = new TrxInvIncome();
            trxInv.Amount = amount;
            trxInv.SupplierID = selectedSupplier.No;
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
                DatabaseBuilder.usingStoredProcedure("SP_TRX_INV_INCOME_ITEM", iparams, values,"Process Success.");
                this.Dispose();
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
                itemGridList.Rows[e.RowIndex].Cells[5].Value = Convert.ToDouble(itemGridList.Rows[e.RowIndex].Cells[4].Value) * newQty;
                setAmount();
            }
            if (e.ColumnIndex == 4 && itemGridList.SelectedRows.Count > 0) 
            {
                String barcode = itemGridList.Rows[e.RowIndex].Cells[0].Value.ToString();
                selectedItem.Find(item => item.ItemBarcode == barcode).ItemPurchase = Convert.ToDouble(itemGridList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                Double newPurchase = Convert.ToDouble(itemGridList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                itemGridList.Rows[e.RowIndex].Cells[5].Value = newPurchase * Convert.ToInt32(itemGridList.Rows[e.RowIndex].Cells[3].Value);
                setAmount();
            }
        }

        private void setAmount()
        {
            amount = 0;
            foreach (DataGridViewRow row in itemGridList.Rows)
            {
                if (row.Cells[5].Value != null)
                {
                    amount += Convert.ToDouble(row.Cells[5].Value.ToString());
                }
            }

            tTotal.Text = Helper.Data.rupiahParser(amount.ToString());
        }

        private void btnSup_Click(object sender, EventArgs e)
        {
            suggestSuppForm.Show();
        }

        public override void populateSupplier(Supplier supplier)
        {
            base.populateSupplier(supplier);
            tSupplier.Text = supplier.Name;
            selectedSupplier = supplier;
        }
    }
}
