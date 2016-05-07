using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.libs
{
    class Helper
    {

        public class Forms
        {
           
            public static void setPlaceHolder(TextBox textbox, String placeholder)
            {
                textbox.Text = placeholder;
            }

            public static void setFocusPlaceHolder(TextBox textbox, String placeholder, bool isPassword)
            {
                if (textbox.Text == "" || textbox.Text == placeholder)
                {
                    if (isPassword)
                    {
                        textbox.Text = "";
                        textbox.UseSystemPasswordChar = true;
                    }
                    else
                    {
                        textbox.Text = "";
                        textbox.UseSystemPasswordChar = false;
                    }
                }


            }

            public static void setLeavePlaceholder(TextBox textbox, String placeholder, bool isPassword)
            {
                if (textbox.Text == "")
                {
                    textbox.Text = placeholder;
                    textbox.UseSystemPasswordChar = false;
                }
                else
                {
                    if (isPassword)
                    {
                        textbox.UseSystemPasswordChar = true;
                    }
                    else
                    {
                        textbox.UseSystemPasswordChar = false;
                    }
                }
            }


            public static Boolean fieldisValid(TextBox textbox, String placeholder)
            {
                bool returnVal = (textbox.Text == placeholder || textbox.Text.Length == 0) ? false : true;
                return returnVal;
            }

            public static void forbiddenNull(TextBox textbox, String defaultValue)
            {
                if (textbox.Text == "")
                {
                    textbox.Text = defaultValue;
                }
            }

            public static void forbiddenNull(TextBox textbox)
            {
                if (textbox.Text == "")
                {
                    textbox.Text = "0";
                }
            }

            public static void justNumber(KeyPressEventArgs e)
            {
                if (char.IsNumber(e.KeyChar))
                {

                }
                else
                {
                    e.Handled = e.KeyChar != (char)Keys.Back;
                }
            }

            public static void startForm(Form form)
            {
                form.Show();
            }


            
        }

        public class Data 
        {
            public static void setBinding(DataGridView dataGrid, String columnName, String bindingText)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGrid.DataSource;
                bs.Filter = columnName + " like '" + bindingText + "%'";
                dataGrid.DataSource = bs;
            }

            public static String rupiahParser(String amount) 
            {
                if (amount != "") 
                {
                    for (int i = amount.Length; i >= 1; i -= 3)
                    {
                        if (i != amount.Length)
                        {
                            amount = amount.Substring(0, i) + "," + amount.Substring(i);
                        }

                    }
                }
                else 
                {
                    amount = "0";
                }
                
                return "Rp. " + amount + ",00";
            }
        }

        public class Date
        {
            private Int32 year;

            public Int32 Year
            {
                get { return year; }
                set { year = value; }
            }
            private Int32 month;

            public Int32 Month
            {
                get { return month; }
                set { month = value; }
            }
            private Int32 day;

            public Int32 Day
            {
                get { return day; }
                set { day = value; }
            }
            private Int32 hour;

            public Int32 Hour
            {
                get { return hour; }
                set { hour = value; }
            }
            private Int32 minute;

            public Int32 Minute
            {
                get { return minute; }
                set { minute = value; }
            }
            private Int32 second;

            public Int32 Second
            {
                get { return second; }
                set { second = value; }
            }

            public Date() 
            {

            }

            private static String Query ="SELECT DATEPART(yyyy,GETDATE()) AS YEAR, " +
                                    "DATEPART(month,GETDATE()) AS MONTH," +
		                            "DATEPART(dd,GETDATE()) AS DAY," +
		                            "DATEPART(hh,GETDATE()) AS HOUR," +
		                            "DATEPART(n,GETDATE()) AS MINUTE," +
		                            "DATEPART(s,GETDATE()) AS SECOND";

            public static Date getDate()
            {
                
                Date date = new Date();
                SqlConnection connection = DatabaseBuilder.getConnection();
                connection.Open();
                SqlDataReader reader = DatabaseBuilder.readDataQuery(Query, connection);
                while (reader.Read())
                {
                    date.Year = Convert.ToInt32(reader.GetValue(0));
                    date.Month = Convert.ToInt32(reader.GetValue(1));
                    date.Day = Convert.ToInt32(reader.GetValue(2));
                    date.Hour = Convert.ToInt32(reader.GetValue(3));
                    date.Minute = Convert.ToInt32(reader.GetValue(4));
                    date.Second = Convert.ToInt32(reader.GetValue(5));
                }
                connection.Close();
                return date;
            }

            public static String getString() 
            {
                String date="";
                SqlConnection connection = DatabaseBuilder.getConnection();
                connection.Open();
                SqlDataReader reader = DatabaseBuilder.readDataQuery(Query, connection);
                while (reader.Read())
                {
                    String year = reader.GetValue(0).ToString();
                    String Month = (Convert.ToInt32(reader.GetValue(1)) < 10) ? "0" + reader.GetValue(1).ToString() : reader.GetValue(1).ToString();
                    String Day = (Convert.ToInt32(reader.GetValue(2)) < 10) ? "0" + reader.GetValue(2).ToString() : reader.GetValue(2).ToString();
                    date = year + Month + Day;
                }
                connection.Close();
                return date;
            }

            public static String getMonthString(Int32 month) 
            {
                String[] monthDate = {
                            "January",
                            "February",
                            "March",
                            "April",
                            "May",
                            "June",
                            "July",
                            "August",
                            "September",
                            "October",
                            "November",
                            "December"
                         };

                return monthDate[month - 1];


            }
        }
    }
}
