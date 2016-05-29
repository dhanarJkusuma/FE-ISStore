using Sales.libs;
using Sales.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.report_model
{
    class StockRptModel
    {
        private static String[] selectedColumns = {
                                                VariableBuilder.Table.Item + "." + Item.Columns[0] + " as Barcode",
                                                VariableBuilder.Table.Item + "." + Item.Columns[1] + " as Name",
                                                VariableBuilder.Table.Category + "." + Sales.model.Category.Columns[1] + " as Category",
                                                VariableBuilder.Table.StockItem + "." + Item.StockItem.StockColumns[1] + " as Stock"
                                           };
        private String _barcode;
        public String Barcode
        {
            get { return _barcode; }
            set { _barcode = value; }
        }
        private String _name;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private String _category;

        public String Category
        {
            get { return _category; }
            set { _category = value; }
        }
        private Int32 _stock;

        public Int32 Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
        public static List<StockRptModel> getAll() 
        {
            List<StockRptModel> data = new List<StockRptModel>();
            String sql = "SELECT * FROM v_stock";
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readDataQuery(sql, connection);
            while (reader.Read())
            {
                StockRptModel model = new StockRptModel();                
                model.Barcode = reader.GetValue(0).ToString();
                model.Name = reader.GetString(1);
                model.Category = reader.GetString(2);
                model.Stock = Convert.ToInt32(reader.GetValue(3));
                data.Add(model);
            }

            connection.Close();
            return data;
        }

    }
}
