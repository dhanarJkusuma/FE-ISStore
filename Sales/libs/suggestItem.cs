using Sales.model;
using Sales.ui.transaction.incoming_item;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.libs
{
    public partial class suggestItem : Form
    {
        private String[] selectedColumns = { 
                                       "CAST(" + VariableBuilder.Table.Item + "." + Item.Columns[0] + " as VARCHAR(100)) as Barcode",
                                       VariableBuilder.Table.Item + "." + Item.Columns[1] + " as Name",
                                       VariableBuilder.Table.Category + "." + Category.Columns[1] + " as Category",
                                       VariableBuilder.Table.StockItem + "." + Item.StockItem.StockColumns[1] + " as Quantity",
                                       VariableBuilder.Table.Item + "." + Item.Columns[4] + " as Price"
                                   };
        private BaseFormSuggest incomeItemForm;

        public suggestItem(Point point, BaseFormSuggest incomeItemForm)
        {
            InitializeComponent();
            this.Location = point;
            
            setData();
            //gridSuggest.Focus();
            //gridSuggest.Rows[0].Selected = true;
            this.incomeItemForm = incomeItemForm;
        }

        public void setData() 
        {
            gridSuggest.DataSource = Item.query()
                                         .innerJoin(VariableBuilder.Table.StockItem)
                                         .on(
                                            VariableBuilder.Table.Item + "." + Item.Columns[0]
                                            + "=" +
                                            VariableBuilder.Table.StockItem + "." + Item.StockItem.StockColumns[0]
                                         )
                                         .leftJoin(VariableBuilder.Table.Category)
                                         .on(
                                            VariableBuilder.Table.Item + "." + Item.Columns[2]
                                            + "=" +
                                            VariableBuilder.Table.Category + "." + Category.Columns[0]
                                         )
                                         .GetData(selectedColumns);
            gridSuggest.ReadOnly = true;
            gridSuggest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void bindData(String bindText)
        {
            Helper.Data.setBinding(gridSuggest, "Barcode", bindText);
            if (gridSuggest.Rows.Count > 0)
            {
                gridSuggest.CurrentCell = gridSuggest.Rows[0].Cells[0];
            }
            gridSuggest.Focus();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gridSuggest_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void gridSuggest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gridSuggest.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = gridSuggest.SelectedRows[0];
                this.incomeItemForm.populateItem(Item.Find(selectedRow.Cells[0].Value.ToString()));
                this.Hide();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = gridSuggest.SelectedRows[0];
            this.incomeItemForm.populateItem(Item.Find(selectedRow.Cells[0].Value.ToString()));
            this.Hide();
        }

    }
}
