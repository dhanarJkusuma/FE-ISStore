using Sales.libs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sales.model
{
    class TrxPaymentItem : BaseModel
    {
        public static String[] Columns = {
                                            "item_no",
                                            "trx_no",
                                            "item_barcode",
                                            "item_qty"
                                         };

        private Int64 _item_no;

        public Int64 ItemNo
        {
            get { return _item_no; }
            set { _item_no = value; }
        }
        private String _trx_no;

        public String TrxNo
        {
            get { return _trx_no; }
            set { _trx_no = value; }
        }
        private String _item_barcode;

        public String ItemBarcode
        {
            get { return _item_barcode; }
            set { _item_barcode = value; }
        }
        private Int32 _qty;

        public Int32 Qty
        {
            get { return _qty; }
            set { _qty = value; }
        }

        public static QueryBuilder query()
        {
            table = VariableBuilder.Table.TrxPaymentItem;
            return new QueryBuilder();
        }

        public void New()
        {
            String[] selectedColumns = { Columns[1], Columns[2], Columns[3] };
            String[] values = { TrxNo, ItemBarcode, Qty.ToString()};
            DatabaseBuilder.insert(VariableBuilder.Table.TrxPaymentItem, selectedColumns, selectedColumns, values);
        }

        public static DataTable All(String TrxNo)
        {
            String whereArgs = Columns[1] + "=" + TrxNo;
            return DatabaseBuilder.read(VariableBuilder.Table.TrxPaymentItem, whereArgs);
        }

        public void Update()
        {
            List<String> selectedColumns = Columns.ToList();
            selectedColumns.RemoveAt(0);
            String[] values = { TrxNo, ItemBarcode, Qty.ToString() };
            DatabaseBuilder.update(VariableBuilder.Table.TrxPaymentItem, selectedColumns.ToArray(), selectedColumns.ToArray(), values, Columns[0] + "=" + ItemNo.ToString());
        }

        public static void Destroy(Int32 itemNo)
        {
            DatabaseBuilder.destory(VariableBuilder.Table.TrxPaymentItem, Columns[0], itemNo.ToString());
        }

        public static List<TrxPaymentItem> Find(String trxNo)
        {
            List<TrxPaymentItem> items = new List<TrxPaymentItem>();
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readData(VariableBuilder.Table.TrxPaymentItem, Columns, Columns[1] + "='" + trxNo + "'", connection);
            while (reader.Read())
            {
                TrxPaymentItem item = new TrxPaymentItem();
                item.ItemNo = Convert.ToInt64(reader.GetValue(0));
                item.TrxNo = reader.GetString(1);
                item.ItemBarcode = reader.GetValue(2).ToString();
                item.Qty = Convert.ToInt32(reader.GetValue(3));
                items.Add(item);
            }
            connection.Close();
            return items;
        }

    }
}
