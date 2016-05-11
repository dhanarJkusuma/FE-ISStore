using Sales.libs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sales.model
{
    class Gift : BaseModel
    {

        public static String[] Columns = {
                                            "item_code",
                                            "item_name",
                                            "item_point_cost",
                                            "item_stock",
                                            "item_added"
                                         };
        private String item_code;

        public String Item_code
        {
            get { return item_code; }
            set { item_code = value; }
        }
        private String item_name;

        public String Item_name
        {
            get { return item_name; }
            set { item_name = value; }
        }
        private Int64 item_point_cost;

        public Int64 Item_point_cost
        {
            get { return item_point_cost; }
            set { item_point_cost = value; }
        }
        private Int32 item_stock;

        public Int32 Item_stock
        {
            get { return item_stock; }
            set { item_stock = value; }
        }
        private String item_added;

        public String Item_added
        {
            get { return item_added; }
            set { item_added = value; }
        }

        public void New() 
        {
            String[] values = { Item_code,Item_name, Item_point_cost.ToString() };
            String[] selectedColumns = { Columns[0], Columns[1], Columns[2] };
            DatabaseBuilder.insert(VariableBuilder.Table.Gift, selectedColumns, selectedColumns, values, "Gift successfully added.");
        }

        public void Update() 
        {
            String[] values = { Item_name, Item_point_cost.ToString(), Item_stock.ToString()};
            String[] updatedColumns = { Columns[1], Columns[2], Columns[3] };
            DatabaseBuilder.update(VariableBuilder.Table.Gift, updatedColumns, updatedColumns, values, Columns[0] + "='" + Item_code + "'","Gift successfully updated.");
        }

        public void UpdateSilence() 
        {
            String[] values = { Item_name, Item_point_cost.ToString(), Item_stock.ToString()};
            String[] updatedColumns = { Columns[1], Columns[2], Columns[3] };
            DatabaseBuilder.update(VariableBuilder.Table.Gift, updatedColumns, updatedColumns, values, Columns[0] + "='" + Item_code + "'");
        
        }

        public static DataTable All() 
        {
            return DatabaseBuilder.read(VariableBuilder.Table.Gift);
        }

        public static String generateGiftNo()
        {
            String TrxNo = "G";
            String Query = "SElECT MAX(item_code) FROM " + VariableBuilder.Table.Gift;
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readDataQuery(Query, connection);
            while (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    Int32 newNumber = Convert.ToInt32(reader.GetString(0).Substring(2)) + 1;
                    String serialNumber = newNumber.ToString().PadLeft(7, '0');
                    TrxNo += serialNumber;
                }
                else
                {
                    TrxNo += "00000001";
                }
            }
            connection.Close();
            return TrxNo;
        }

        public static void Destroy(String no) 
        {
            DatabaseBuilder.destory(VariableBuilder.Table.Gift, Columns[0], no,"Gift successfully deleted.");
        }

        public static Gift Find(String barcode)
        {
            Gift item = new Gift();
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readData(VariableBuilder.Table.Gift, Columns, Columns[0] + "='" + barcode + "'", connection);
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    item.Item_code = (reader.IsDBNull(0)) ? null : reader.GetString(0);
                    item.Item_name = reader.GetString(1);
                    item.Item_point_cost = Convert.ToInt64(reader.GetValue(2));
                    item.Item_stock = Convert.ToInt32(reader.GetValue(3));
                    item.Item_added = reader.GetDateTime(4).ToString();
                    
                }
                else
                {
                    item = null;
                }
            }
            connection.Close();
            return item;
        }

    }
}
