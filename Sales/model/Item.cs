using Sales.libs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sales.model
{
    public class Item : BaseModel
    {
        public static String[] Columns = {
                                            "item_barcode",
                                            "item_name",
                                            "category_code",
                                            "unit_code",
                                            "item_price",
                                            "item_stock_alert",
                                            "created_at",
                                            "updated_at"
                                         };

        public static String[] StockColumns = { 
                                                "item_barcode",
                                                "item_qty",
                                                "created_at",
                                                "updated_at"
                                              };



        private String tmpBarcode;

        public String TmpBarcode
        {
            get { return tmpBarcode; }
            set { tmpBarcode = value; }
        }

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
        private String _unit;

        public String Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }
        private String _price;

        public String Price
        {
            get { return _price; }
            set { _price = value; }
        }
        private String _stockAlert;

        public String StockAlert
        {
            get { return _stockAlert; }
            set { _stockAlert = value; }
        }


        public static QueryBuilder query()
        {
            table = VariableBuilder.Table.Item;
            return new QueryBuilder();
        }

        public void New() 
        {
            String[] iparams= {
                                            "item_barcode",
                                            "item_name",
                                            "category_code",
                                            "unit_code",
                                            "item_price",
                                            "item_stock_alert" 
                               };
            String[] values = { Barcode, Name, Category, Unit, Price, StockAlert };
            DatabaseBuilder.usingStoredProcedure("SP_NEW_ITEM", iparams, values);
        }

        public static String getItemName(String barcode) 
        {
            String itemName = "N/A";
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readData(VariableBuilder.Table.Item, new String[]{ "item_name" }, Columns[0] + "=" + barcode, connection);
            while (reader.Read())
            {
                itemName = (reader.IsDBNull(0)) ? "N/A" : reader.GetString(0);
            }
            connection.Close();
            return itemName;
        }

        public static Int32 getQty(String barcode) 
        {
            Int32 qty = 0;
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readData(VariableBuilder.Table.StockItem, new String[] { StockColumns[1] }, StockColumns[0] + "=" + barcode, connection);
            while (reader.Read())
            {
                qty = (reader.IsDBNull(0)) ? 0 : Convert.ToInt32(reader.GetValue(0));
            }
            connection.Close();
            return qty;
        }

        public static Item Find(String barcode)
        {
            Item item = new Item();
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readData(VariableBuilder.Table.Item,Columns,Columns[0] + "='" + barcode + "'", connection);
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    item.Barcode = (reader.IsDBNull(0)) ? null : reader.GetString(0);
                    item.Name = reader.GetString(1);
                    item.Category = reader.GetString(2);
                    item.Unit = reader.GetString(3);
                    item.Price = reader.GetValue(4).ToString();
                    item.StockAlert = reader.GetValue(5).ToString();
                    item.tmpBarcode = barcode;
                }
                else 
                {
                    item = null;
                }
            }
            connection.Close();
            return item;
        }

        public void Update()
        {
            List<String> values = new List<String>() { Barcode, Name, Category, Unit, Price, StockAlert, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") };
            List<String> editedColumns = Columns.ToList();
            editedColumns.RemoveAt(6);
            if (tmpBarcode == Barcode)
            {
                values.RemoveAt(0);
                editedColumns.RemoveAt(0);
                DatabaseBuilder.update(VariableBuilder.Table.Item, editedColumns.ToArray(), editedColumns.ToArray(), values.ToArray(), Columns[0] + "='" + tmpBarcode + "'", "Selected Item has been edited.");
            }
            else 
            {
                DatabaseBuilder.update(VariableBuilder.Table.Item, editedColumns.ToArray(), editedColumns.ToArray(), values.ToArray(), Columns[0] + "='" + tmpBarcode + "'", "Selected Item has been edited.");
            }
        }

        public static void Destroy(String barcode) 
        {
            DatabaseBuilder.usingStoredProcedure("SP_DELETE_ITEM", new String[] { "item_barcode" }, new String[] { barcode }, "Selected data has been deleted successfully.");
        }
    }
}
