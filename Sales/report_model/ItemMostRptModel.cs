using Sales.libs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sales.report_model
{
    public class ItemMostRptModel
    {

        public static int TYPE_TOP = 1;
        public static int TYPE_DOWN = 2;

        private String _barcode;

        public String Barcode
        {
            get { return _barcode; }
            set { _barcode = value; }
        }

        private Int32 _qty;

        public Int32 Qty
        {
            get { return _qty; }
            set { _qty = value; }
        }

        private String _name;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }



        public static List<ItemMostRptModel> getTop()
        {
            List<ItemMostRptModel> data = new List<ItemMostRptModel>();
            String sql = "SELECT V_TOP_10_ITEM.item_barcode, box_master_item.item_name, V_TOP_10_ITEM.qty from V_TOP_10_ITEM inner join box_master_item on V_TOP_10_ITEM.item_barcode = box_master_item.item_barcode";
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readDataQuery(sql, connection);
            while (reader.Read())
            {
                ItemMostRptModel model = new ItemMostRptModel();
                model.Barcode = reader.GetValue(0).ToString();
                model.Name = reader.GetString(1);
                model.Qty = Convert.ToInt32(reader.GetValue(2));
                data.Add(model);
            }
            connection.Close();
            return data;
        }


        public static List<ItemMostRptModel> getDown()
        {
            List<ItemMostRptModel> data = new List<ItemMostRptModel>();
            String sql = "SELECT V_DOWN_10_ITEM.item_barcode, box_master_item.item_name, V_DOWN_10_ITEM.qty from V_DOWN_10_ITEM inner join box_master_item on V_DOWN_10_ITEM.item_barcode = box_master_item.item_barcode";
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readDataQuery(sql, connection);
            while (reader.Read())
            {
                ItemMostRptModel model = new ItemMostRptModel();
                model.Barcode = reader.GetValue(0).ToString();
                model.Name = reader.GetString(1);
                model.Qty = Convert.ToInt32(reader.GetValue(2));
                data.Add(model);
            }
            connection.Close();
            return data;
        }
    }
}
