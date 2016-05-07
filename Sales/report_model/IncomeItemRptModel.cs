using Sales.libs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sales.report_model
{
    class IncomeItemRptModel
    {

        public static String[] Columns = {
                                            "trx_no",
                                            "item_barcode",
                                            "item_qty",
                                            "item_purchase_price"
                                           };

        private String barcode;

        public String Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }
        private String item_name;

        public String Item_name
        {
            get { return item_name; }
            set { item_name = value; }
        }
        private Int32 qty;

        public Int32 Qty
        {
            get { return qty; }
            set { qty = value; }
        }
        private String purchase;

        public String Purchase
        {
            get { return purchase; }
            set { purchase = value; }
        }
        private String sub_total;

        public String Sub_total
        {
            get { return sub_total; }
            set { sub_total = value; }
        }

        public static List<IncomeItemRptModel> getAll(String trxNo) 
        {
            List<IncomeItemRptModel> items = new List<IncomeItemRptModel>();
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readData(VariableBuilder.Table.TrxInvIncomeItem, Columns, Columns[0] + "='" + trxNo + "'", connection);
            while (reader.Read())
            {
                IncomeItemRptModel item = new IncomeItemRptModel();
                item.Barcode = reader.GetValue(1).ToString();
                item.Item_name = Sales.model.Item.getItemName(item.Barcode);
                item.Qty = Convert.ToInt32(reader.GetValue(2));
                item.Purchase = Helper.Data.rupiahParser(Convert.ToDouble(reader.GetValue(3)).ToString());
                item.Sub_total = Helper.Data.rupiahParser((Convert.ToInt32(reader.GetValue(2)) * Convert.ToDouble(reader.GetValue(3))).ToString());
                items.Add(item);
            }
            connection.Close();
            return items;        
        }
    }
}
