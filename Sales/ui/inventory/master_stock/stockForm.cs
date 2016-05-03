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

namespace Sales.ui.inventory.master_stock
{
    public partial class stockForm : Form
    {

        private String[] selectedColumns = {
                                                VariableBuilder.Table.Item + "." + Item.Columns[0] + " as Barcode",
                                                VariableBuilder.Table.Item + "." + Item.Columns[1] + " as Name",
                                                VariableBuilder.Table.Category + "." + Category.Columns[1] + " as Category",
                                                VariableBuilder.Table.StockItem + "." + Item.StockColumns[1] + " as Stock"
                                           };
        public stockForm()
        {
            InitializeComponent();
            refreshData();
           
        }
        public void refreshData() 
        {
            stockGrid.DataSource = Item.query()
                                      .innerJoin(VariableBuilder.Table.StockItem)
                                      .on(
                                           VariableBuilder.Table.Item + "." + Item.Columns[0]
                                           + "=" +
                                           VariableBuilder.Table.StockItem + "." + Item.StockColumns[0]
                                         )
                                       .leftJoin(VariableBuilder.Table.Category)
                                       .on(
                                           VariableBuilder.Table.Item + "." + Item.Columns[2]
                                           + "=" +
                                           VariableBuilder.Table.Category + "." + Category.Columns[0]
                                       )
                                       .GetData(selectedColumns);
            stockGrid.ReadOnly = true;
            stockGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
