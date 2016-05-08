using Sales.libs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.report_model
{
    public class ProfitRptModel
    {

        private String trx_no;

        public String Trx_no
        {
            get { return trx_no; }
            set { trx_no = value; }
        }

        private String date_transaction;

        public String Date_transaction
        {
            get { return date_transaction; }
            set { date_transaction = value; }
        }

        private String _profit;

        public String Profit
        {
            get { return _profit; }
            set { _profit = value; }
        }

        public class InMounth
        {
            private String _dateMonth;

            public String DateMonth
            {
                get { return _dateMonth; }
                set { _dateMonth = value; }
            }
            private String _profit;

            public String Profit
            {
                get { return _profit; }
                set { _profit = value; }
            }
        }

        public static List<ProfitRptModel> getAll()
        {
            List<ProfitRptModel> data = new List<ProfitRptModel>();
            String sql = "SELECT * FROM V_PROFIT";
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readDataQuery(sql, connection);
            while (reader.Read())
            {
                ProfitRptModel model = new ProfitRptModel();
                model.Trx_no = reader.GetString(0);
                model.Date_transaction = reader.GetDateTime(1).ToString("dd MMMM yyyy");
                model.Profit = Helper.Data.rupiahParser(Convert.ToDouble(reader.GetValue(2)).ToString());
                data.Add(model);
            }

            connection.Close();
            return data;
        }

        public static List<ProfitRptModel> getData(String firstDate, String secondDate)
        {
            List<ProfitRptModel> data = new List<ProfitRptModel>();
            String sql = "SELECT * FROM FN_GET_PROFIT_REPORT('" + firstDate + "','" + secondDate + "')";
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readDataQuery(sql, connection);
            while (reader.Read())
            {
                ProfitRptModel model = new ProfitRptModel();
                model.Trx_no = reader.GetString(0);
                model.Date_transaction = reader.GetDateTime(1).ToString("dd MMMM yyyy");
                model.Profit = Helper.Data.rupiahParser(Convert.ToDouble(reader.GetValue(2)).ToString());
                data.Add(model);
            }

            connection.Close();
            return data;
        }

        public static List<InMounth> getData(Int32 firstMonth, Int32 secondMonth, Int32 firstYear, Int32 secondYear)
        {
            List<InMounth> data = new List<InMounth>();
            String sql = "SELECT * FROM FN_GET_PROFIT_MONTH_REPORT('" + firstMonth + "','" + secondMonth + "','" + firstYear + "','" + secondYear + "')";
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readDataQuery(sql, connection);
            while (reader.Read())
            {
                InMounth model = new InMounth();
                model.DateMonth = reader.GetValue(0).ToString() + " " + Helper.Date.getMonthString(Convert.ToInt32(reader.GetValue(1)));
                model.Profit = Helper.Data.rupiahParser(Convert.ToDouble(reader.GetValue(2)).ToString());
                data.Add(model);
            }

            connection.Close();
            return data;
        }

        

    }
}
