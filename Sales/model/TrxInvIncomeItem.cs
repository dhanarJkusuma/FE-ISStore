using Sales.libs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sales.model
{
    class TrxInvIncomeItem : BaseModel
    {
        public static String[] Columns = {
                                            "item_no",
                                            "trx_no",
                                            "item_barcode",
                                            "item_qty",
                                            "item_purchase_price"
                                           };

        private Int64 item_no;

        public Int64 ItemNo
        {
            get { return item_no; }
            set { item_no = value; }
        }
        private String trx_no;

        public String TrxNo
        {
            get { return trx_no; }
            set { trx_no = value; }
        }
        private String item_barcode;

        public String ItemBarcode
        {
            get { return item_barcode; }
            set { item_barcode = value; }
        }
        private Int32 item_qty;

        public Int32 ItemQuantity
        {
            get { return item_qty; }
            set { item_qty = value; }
        }
        private Double item_purchase_price;

        public Double ItemPurchase
        {
            get { return item_purchase_price; }
            set { item_purchase_price = value; }
        }

        private Int16 is_processed;

        public Int16 IsProcessed
        {
            get { return is_processed; }
            set { is_processed = value; }
        }


      


        public static QueryBuilder query()
        {
            table = VariableBuilder.Table.TrxInvIncome;
            return new QueryBuilder();
        }

        public void Insert() 
        {
            String[] selectedColumns = { Columns[1], Columns[2], Columns[3], Columns[4] };
            String[] values = { TrxNo, ItemBarcode, ItemQuantity.ToString(), ItemPurchase.ToString()};
            DatabaseBuilder.insert(VariableBuilder.Table.TrxInvIncomeItem, selectedColumns, selectedColumns, values);
        }

        public static DataTable All(String TrxNo) 
        {
            String whereArgs = Columns[1] + "=" + TrxNo;
            return DatabaseBuilder.read(VariableBuilder.Table.TrxInvIncomeItem, whereArgs);
        }

        public void Update() 
        {
            List<String> selectedColumns = Columns.ToList();
            selectedColumns.RemoveAt(0);
            String[] values = { TrxNo, ItemBarcode, ItemQuantity.ToString(), ItemPurchase.ToString(),};
            DatabaseBuilder.update(VariableBuilder.Table.TrxInvIncomeItem, selectedColumns.ToArray(), selectedColumns.ToArray(), values, Columns[0] + "=" + ItemNo.ToString());
        }

        public static void Destroy(Int64 itemNo) 
        {
            DatabaseBuilder.destory(VariableBuilder.Table.TrxInvIncomeItem, Columns[0], itemNo.ToString());
        }

        public static List<TrxInvIncomeItem> Find(String trxNo)
        {
            List<TrxInvIncomeItem> items = new List<TrxInvIncomeItem>();
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readData(VariableBuilder.Table.TrxInvIncomeItem, Columns, Columns[1] + "='" + trxNo + "'", connection);
            while (reader.Read())
            {
                TrxInvIncomeItem item = new TrxInvIncomeItem();
                item.ItemNo = Convert.ToInt64(reader.GetValue(0));
                item.TrxNo = reader.GetString(1);
                item.ItemBarcode = reader.GetValue(2).ToString();
                item.ItemQuantity = Convert.ToInt32(reader.GetValue(3));
                item.ItemPurchase = Convert.ToDouble(reader.GetValue(4));
                items.Add(item);
            }
            connection.Close();
            return items;
        }


 
        
    }
}
