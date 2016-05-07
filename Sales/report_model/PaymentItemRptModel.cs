using Sales.libs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sales.report_model
{
    class PaymentItemRptModel
    {
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
        private String price;

        public String Price
        {
            get { return price; }
            set { price = value; }
        }
        private String sub_total;

        public String Sub_total
        {
            get { return sub_total; }
            set { sub_total = value; }
        }

        public static List<PaymentItemRptModel> getAll(String trxNo)
        {
            List<PaymentItemRptModel> items = new List<PaymentItemRptModel>();
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readDataQuery("SELECT * FROM V_PAYMENT_ITEM WHERE trx_no='" + trxNo + "'", connection);
            while (reader.Read())
            {
                PaymentItemRptModel item = new PaymentItemRptModel();
                item.Barcode = reader.GetValue(1).ToString();
                item.Item_name = reader.GetString(2);
                item.Qty = Convert.ToInt32(reader.GetValue(3));
                item.Price = Helper.Data.rupiahParser(Convert.ToDouble(reader.GetValue(4)).ToString());
                item.Sub_total = Helper.Data.rupiahParser(Convert.ToDouble(reader.GetValue(5)).ToString());
                items.Add(item);
            }
            connection.Close();
            return items;
        }
    }
}
