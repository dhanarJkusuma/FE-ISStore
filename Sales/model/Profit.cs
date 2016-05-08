using Sales.libs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sales.model
{
    class Profit
    {
        private String dateMonth;

        public String DateMonth
        {
            get { return dateMonth; }
            set { dateMonth = value; }
        }
        private Double dprofit;

        public Double dProfit
        {
            get { return dprofit; }
            set { dprofit = value; }
        }
        public static List<Profit> getData(Int32 firstMonth, Int32 secondMonth, Int32 firstYear, Int32 secondYear)
        {
            List<Profit> data = new List<Profit>();
            String sql = "SELECT * FROM FN_GET_PROFIT_MONTH_REPORT('" + firstMonth + "','" + secondMonth + "','" + firstYear + "','" + secondYear + "')";
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readDataQuery(sql, connection);
            while (reader.Read())
            {
                Profit model = new Profit();
                model.DateMonth = reader.GetValue(0).ToString() + " " + Helper.Date.getMonthString(Convert.ToInt32(reader.GetValue(1)));
                model.dProfit = Convert.ToDouble(reader.GetValue(2));
                data.Add(model);
            }

            connection.Close();
            return data;
        }

        public static DataTable getDataProfit(Int32 firstMonth, Int32 secondMonth, Int32 firstYear, Int32 secondYear)
        {
            List<Profit> data = new List<Profit>();
            String sql = "SELECT * FROM FN_GET_PROFIT_MONTH_REPORT('" + firstMonth + "','" + secondMonth + "','" + firstYear + "','" + secondYear + "')";
            return DatabaseBuilder.query(sql);
        }
    }
}
