using Sales.libs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sales.model
{
    class CurrentDate
    {
        private String tahun;

        public String Tahun
        {
            get { return tahun; }
            set { tahun = value; }
        }
        private String bulan;

        public String Bulan
        {
            get { return bulan; }
            set { bulan = value; }
        }
        private String tanggal;

        public String Tanggal
        {
            get { return tanggal; }
            set { tanggal = value; }
        }
        private String jam;

        public String Jam
        {
            get { return jam; }
            set { jam = value; }
        }
        private String menit;

        public String Menit
        {
            get { return menit; }
            set { menit = value; }
        }
        private String detik;

        public String Detik
        {
            get { return detik; }
            set { detik = value; }
        }

        public CurrentDate() 
        {
                
        }

        public static String getStringDateTime(Char delimiter) 
        {
            String returnValue="";
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            String query =  "SELECT YEAR(GETDATE()) as tahun, " +
                            "RIGHT('0' + RTRIM(MONTH(GETDATE())), 2) as bulan, " +
                            "CONVERT(varchar(2), GETDATE(), 103) as tanggal, " + 
                            "DATEPART(HOUR, GETDATE()) as jam, " +
                            "DATEPART(MINUTE, GETDATE()) as menit, " +
                            "DATEPART(SECOND, GETDATE()) as detik";
            SqlDataReader reader = DatabaseBuilder.readDataQuery(query, connection);
            while (reader.Read())
            {
                returnValue += reader.GetString(0);
                returnValue += delimiter;
                returnValue += reader.GetString(1);
                returnValue += delimiter;
                returnValue += reader.GetString(2);
                returnValue += delimiter;
                returnValue += reader.GetString(3);
                returnValue += delimiter;
                returnValue += reader.GetString(4);
                returnValue += delimiter;
                returnValue += reader.GetString(5);
            }
            connection.Close();
            return returnValue;
        }

        public static String getStringDateTime()
        {
            String returnValue = "";
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            String query = "SELECT YEAR(GETDATE()) as tahun, " +
                            "RIGHT('0' + RTRIM(MONTH(GETDATE())), 2) as bulan, " +
                            "CONVERT(varchar(2), GETDATE(), 103) as tanggal, " +
                            "DATEPART(HOUR, GETDATE()) as jam, " +
                            "DATEPART(MINUTE, GETDATE()) as menit, " +
                            "DATEPART(SECOND, GETDATE()) as detik";
            SqlDataReader reader = DatabaseBuilder.readDataQuery(query, connection);
            while (reader.Read())
            {
                returnValue += reader.GetString(0);
                returnValue += reader.GetString(1);
                returnValue += reader.GetString(2);
                returnValue += reader.GetString(3);
                returnValue += reader.GetString(4);
                returnValue += reader.GetString(5);
            }
            connection.Close();
            return returnValue;
        }

        public static String getStringDate() 
        {
            String returnValue = "";
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            String query = "SELECT YEAR(GETDATE()) as tahun, " +
                            "RIGHT('0' + RTRIM(MONTH(GETDATE())), 2) as bulan, " +
                            "CONVERT(varchar(2), GETDATE(), 103) as tanggal";
            SqlDataReader reader = DatabaseBuilder.readDataQuery(query, connection);
            while (reader.Read())
            {
                returnValue += reader.GetString(0);
                returnValue += reader.GetString(1);
                returnValue += reader.GetString(2);
            }
            connection.Close();
            return returnValue;
        }

        public static String getStringDate(Char delimiter)
        {
            String returnValue = "";
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            String query = "SELECT YEAR(GETDATE()) as tahun, " +
                            "RIGHT('0' + RTRIM(MONTH(GETDATE())), 2) as bulan, " +
                            "CONVERT(varchar(2), GETDATE(), 103) as tanggal";
            SqlDataReader reader = DatabaseBuilder.readDataQuery(query, connection);
            while (reader.Read())
            {
                returnValue += reader.GetString(0);
                returnValue += delimiter;
                returnValue += reader.GetString(1);
                returnValue += delimiter;
                returnValue += reader.GetString(2);
            }
            connection.Close();
            return returnValue;
        }
    }
}
