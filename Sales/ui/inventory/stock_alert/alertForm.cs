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

namespace Sales.ui.inventory.stock_alert
{
    public partial class alertForm : Form
    {
        private String[] selectedColumns = {
                                                VariableBuilder.Table.Item + "." + Item.Columns[0] + " as Barcode",
                                                VariableBuilder.Table.Item + "." + Item.Columns[1] + " as Name",
                                                VariableBuilder.Table.Category + "." + Category.Columns[1] + " as Category",
                                                VariableBuilder.Table.StockItem + "." + Item.StockColumns[1] + " as Stock"
                                           };
        public alertForm()
        {
            InitializeComponent();
            refreshData();
        }

        public void refreshData() 
        {
            alertGrid.DataSource = Item.query()
                                       .innerJoin(VariableBuilder.Table.StockItem)
                                       .on(
                                            VariableBuilder.Table.Item + "." + Item.Columns[0] 
                                            + "=" + 
                                            VariableBuilder.Table.StockItem + "." + Item.StockColumns[0]
                                        )
                                        .leftJoin(VariableBuilder.Table.Category)
                                        .on(
                                            VariableBuilder.Table.Category + "." + Category.Columns[0]
                                            + "=" +
                                            VariableBuilder.Table.Item +"." + Item.Columns[2]
                                        )
                                       .where(
                                            VariableBuilder.Table.StockItem + "." + Item.StockColumns[1] 
                                            + "<=" + 
                                            VariableBuilder.Table.Item + "." + Item.Columns[5]
                                        )
                                        .GetData(selectedColumns);

            alertGrid.ReadOnly = true;
            alertGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }
    }
}
