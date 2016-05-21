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

        public class InMonth
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

        public class InDays 
        {
            private String _date;

            public String Date
            {
                get { return _date; }
                set { _date = value; }
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

        public static List<InMonth> getDataMonth(Int32 firstMonth, Int32 secondMonth, Int32 firstYear, Int32 secondYear)
        {
            List<InMonth> data = new List<InMonth>();
            String sql = "SELECT * FROM FN_GET_PROFIT_MONTH_REPORT('" + firstMonth + "','" + secondMonth + "','" + firstYear + "','" + secondYear + "')";
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readDataQuery(sql, connection);
            while (reader.Read())
            {
                InMonth model = new InMonth();
                model.DateMonth = reader.GetValue(0).ToString() + " " + Helper.Date.getMonthString(Convert.ToInt32(reader.GetValue(1)));
                model.Profit = Helper.Data.rupiahParser(Convert.ToDouble(reader.GetValue(2)).ToString());
                data.Add(model);
            }

            connection.Close();
            return data;
        }

        public static InMonth getSingleDataMonth(Int32 month, Int32 year) 
        {
            InMonth data = null;
            String sql = "SELECT * from V_PROFIT_MONTH WHERE profit_year=" +year + " and profit_month=" + month;
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readDataQuery(sql, connection);
            if (reader.HasRows) 
            {
                while (reader.Read())
                {
                    data = new InMonth();
                    data.DateMonth = reader.GetValue(0).ToString() + " " + Helper.Date.getMonthString(Convert.ToInt32(reader.GetValue(1)));
                    data.Profit = Helper.Data.rupiahParser(Convert.ToDouble(reader.GetValue(2)).ToString());
                }
            }
            
            return data;
        }

        public static List<InDays> getDataDay(Int32 month, Int32 years) 
        {
            List<InDays> data = new List<InDays>();
            String sql = "SELECT * FROM V_PROFIT_DAY where datepart(yyyy,date)=" + years +"and datepart(mm,date)=" + month;
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readDataQuery(sql, connection);
            while (reader.Read())
            {
                InDays days = new InDays();
                days.Date = reader.GetDateTime(0).ToString("yyyy MMMM dd");
                days.Profit = Helper.Data.rupiahParser(Convert.ToDouble(reader.GetValue(1)).ToString());
                data.Add(days);
            }

            connection.Close();
            return data;
        }

        

    }
}
