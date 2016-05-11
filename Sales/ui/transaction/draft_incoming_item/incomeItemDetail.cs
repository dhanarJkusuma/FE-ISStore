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
    public partial class incomeItemDetail : BaseFormSuggest
    {
        private TrxInvIncome trxInvIncome;
        private Supplier selectedSupplier;
        private List<TrxInvIncomeItem> items;
        private List<TrxInvIncomeItem> selectedItem = new List<TrxInvIncomeItem>();
        private suggestItem suggestForm;
        private suggestSupplier suggestSuppForm;
        private Double amount = 0;

        internal List<TrxInvIncomeItem> Items
        {
            get { return items; }
            set { items = value; }
        }
        private BaseForm home;

        internal TrxInvIncome vTrxInvIncome
        {
            get { return trxInvIncome; }
            set { trxInvIncome = value; }
        }

        public incomeItemDetail(BaseForm home)
        {
            InitializeComponent();
            suggestForm = new suggestItem(new Point(tBarcode.Location.X, tBarcode.Location.Y + tBarcode.Height + 40), this);
            suggestSuppForm = new suggestSupplier(this);
            this.home = home;
            tTotal.Text = "Rp. 0,00";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            vTrxInvIncome.Amount = amount;
            if (selectedSupplier != null)
            {
                vTrxInvIncome.SupplierID = selectedSupplier.No;
            }
            else 
            {
                vTrxInvIncome.SupplierID = null;
            }
            
            vTrxInvIncome.Update();
            for (int i = 0; i < selectedItem.Count; i++)
            {
                TrxInvIncomeItem cart = new TrxInvIncomeItem();
                cart.TrxNo = vTrxInvIncome.TrxNo;
                cart.ItemBarcode = selectedItem[i].ItemBarcode;
                cart.ItemQuantity = selectedItem[i].ItemQuantity;
                cart.ItemPurchase = selectedItem[i].ItemPurchase;
                cart.New();    
            }
            DialogResult dialogResult = MessageBox.Show("Process this data?", "Dialog Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) 
            {
                String[] iparams = { "pStrTrxNo" };
                String[] values = { vTrxInvIncome.TrxNo };
                DatabaseBuilder.usingStoredProcedure("SP_TRX_INV_INCOME_ITEM", iparams, values, "Process Success.");
                home.refreshData();
                this.Dispose();
            }
            else             
            {
                MessageBox.Show("Transaction Saved.");
                home.refreshData();
                this.Dispose();
            }
            
        }

        private void incomeItemDetail_Load(object sender, EventArgs e)
        {
            amount = vTrxInvIncome.Amount;
            tTotal.Text = Helper.Data.rupiahParser(amount.ToString());
            tTrxNo.Text = vTrxInvIncome.TrxNo;
            for (int i = 0; i < items.Count; i++) 
            {
                Item item = Item.Find(items[i].ItemBarcode);
                itemGridList.Rows.Add(items[i].ItemBarcode, item.Name,item.Price ,items[i].ItemQuantity, items[i].ItemPurchase, Convert.ToInt32(items[i].ItemQuantity) * Convert.ToDouble(items[i].ItemPurchase) + ".00");
            }
            itemGridList.Columns[0].ReadOnly = true;
            itemGridList.Columns[1].ReadOnly = true;
            itemGridList.Columns[2].ReadOnly = true;
            itemGridList.Columns[3].ReadOnly = false;
            itemGridList.Columns[4].ReadOnly = false;
            itemGridList.Columns[5].ReadOnly = true;

            itemGridList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (vTrxInvIncome.SupplierID != "") 
            {
                selectedSupplier = Supplier.Find(vTrxInvIncome.SupplierID);
            }
        }

        public override void populateItem(Item item)
        {
            base.populateItem(item);
            tBarcode.Text = item.Barcode;
            tName.Text = item.Name;
            tPrice.Text = item.Price;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (selectedItem.Find(item => item.ItemBarcode == tBarcode.Text) == null && items.Find(item => item.ItemBarcode == tBarcode.Text) == null)
            {
                TrxInvIncomeItem cart = new TrxInvIncomeItem();
                cart.TrxNo = tTrxNo.Text;
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
                TrxInvIncomeItem itemSelected = new TrxInvIncomeItem();
                itemSelected.ItemBarcode = itemGridList.SelectedRows[0].Cells[0].Value.ToString();
                itemSelected.ItemQuantity = Convert.ToInt32(itemGridList.SelectedRows[0].Cells[3].Value);
                itemSelected.ItemPurchase = Convert.ToDouble(itemGridList.SelectedRows[0].Cells[4].Value);
                if (items.Find(item => item.ItemBarcode == itemGridList.SelectedRows[0].Cells[0].Value.ToString()) != null)
                {
                    TrxInvIncomeItem.Destroy(items.Find(item => item.ItemBarcode == itemGridList.SelectedRows[0].Cells[0].Value.ToString()).ItemNo);
                    items.RemoveAll(item => item.ItemBarcode == itemGridList.SelectedRows[0].Cells[0].Value.ToString());
                }
                else 
                {
                    selectedItem.RemoveAll(item => item.ItemBarcode == itemGridList.SelectedRows[0].Cells[0].Value.ToString());
                }
                itemGridList.Rows.RemoveAt(itemGridList.SelectedRows[0].Index);
            }
            setAmount();
        }

        private void tBarcode_TextChanged(object sender, EventArgs e)
        {
            if (tBarcode.Text.Length > 3)
            {
                Helper.Forms.startForm(suggestForm);
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

        private void itemGridList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && itemGridList.SelectedRows.Count > 0)
            {
                String barcode = itemGridList.Rows[e.RowIndex].Cells[0].Value.ToString();
                Int32 newQty = Convert.ToInt32(itemGridList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                if(selectedItem.Find(item => item.ItemBarcode == barcode)!=null)
                {
                    selectedItem.Find(item => item.ItemBarcode == barcode).ItemQuantity = newQty;
                }
                else
                {
                    items.Find(item => item.ItemBarcode == barcode).ItemQuantity = newQty;
                    items.Find(item => item.ItemBarcode == barcode).Update();
                }
                /*
                amount -= Convert.ToDouble(itemGridList.Rows[e.RowIndex].Cells[5].Value);
                amount += Convert.ToDouble(itemGridList.Rows[e.RowIndex].Cells[4].Value) * newQty;
                tTotal.Text = Helper.Data.rupiahParser(amount.ToString());*/
                
                itemGridList.Rows[e.RowIndex].Cells[5].Value = Convert.ToDouble(itemGridList.Rows[e.RowIndex].Cells[4].Value) * newQty;
                setAmount();
            }
            if (e.ColumnIndex == 4 && itemGridList.SelectedRows.Count > 0)
            {
                String barcode = itemGridList.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (selectedItem.Find(item => item.ItemBarcode == barcode) != null)
                {
                    selectedItem.Find(item => item.ItemBarcode == barcode).ItemPurchase = Convert.ToDouble(itemGridList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                }
                else 
                {
                    items.Find(item => item.ItemBarcode == barcode).ItemPurchase = Convert.ToDouble(itemGridList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    items.Find(item => item.ItemBarcode == barcode).Update();
                }
                
                Double newPurchase = Convert.ToDouble(itemGridList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                /*amount -= Convert.ToDouble(itemGridList.Rows[e.RowIndex].Cells[5].Value);
                amount += newPurchase * Convert.ToInt32(itemGridList.Rows[e.RowIndex].Cells[3].Value);
                tTotal.Text = Helper.Data.rupiahParser(amount.ToString());*/
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

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
