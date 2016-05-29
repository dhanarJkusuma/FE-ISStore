using Sales.libs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sales.model
{
    class TrxPayment : BaseModel
    {
        public static String[] Columns = {
                                             "trx_no",
                                             "modi_id",
                                             "member_id",
                                             "total_amount",
                                             "total_pay",
                                             "cash_back",
                                             "created_at",
                                             "is_processed"
                                         };

        private String trx_no;

        public String TrxNo
        {
            get { return trx_no; }
            set { trx_no = value; }
        }
        private Int32 modi_id;

        public Int32 ModiID
        {
            get { return modi_id; }
            set { modi_id = value; }
        }
        private Int64 member_id=-1;

        public Int64 MemberID
        {
            get { return member_id; }
            set { member_id = value; }
        }
        private Double total_amount = 0;

        public Double TotalAmount
        {
            get { return total_amount; }
            set { total_amount = value; }
        }
       
        private Double total_pay = 0;

        public Double TotalPay
        {
            get { return total_pay; }
            set { total_pay = value; }
        }
        private Double cash_back = 0;

        public Double CashBack
        {
            get { return cash_back; }
            set { cash_back = value; }
        }
        private String created_at;

        public String CreatedAt
        {
            get { return created_at; }
            set { created_at = value; }
        }

        public static QueryBuilder query()
        {
            table = VariableBuilder.Table.TrxPayment;
            return new QueryBuilder();
        }

        public void Insert() 
        {
            String[] selectedColumns = {
                                            "trx_no",
                                            "modi_id",
                                            "member_id",
                                            "total_amount",
                                            "total_pay",
                                            "cash_back",
                                            "created_at"
                                        };


            ModiID = VariableBuilder.Session.userLogged.Id;
            CreatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            String[] values = {     TrxNo, 
                                    ModiID.ToString(), 
                                    (MemberID == -1) ? "" : MemberID.ToString(),
                                    TotalAmount.ToString(), 
                                    TotalPay.ToString(), 
                                    CashBack.ToString(), 
                                    CreatedAt 
                              };
            DatabaseBuilder.insert(VariableBuilder.Table.TrxPayment, selectedColumns, selectedColumns, values);
        }

        public void Update()
        {
            String[] selectedColumns = {
                                            "member_id",
                                            "total_amount",
                                            "total_pay",
                                            "cash_back"
                                        };
            String[] values = { MemberID.ToString(), TotalAmount.ToString(), TotalPay.ToString(), CashBack.ToString() };
            DatabaseBuilder.update(VariableBuilder.Table.TrxInvIncome, selectedColumns, selectedColumns, values, Columns[0] + "='" + TrxNo + "'");
        }

        public static String generateTrxNo()
        {
            String TrxNo = "PN";
            String Query = "SElECT MAX(trx_no) FROM " + VariableBuilder.Table.TrxPayment + " WHERE DATEADD(dd, 0, DATEDIFF(dd, 0, created_at))=DATEADD(dd, 0, DATEDIFF(dd, 0, GETDATE()))";
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();

            SqlDataReader reader = DatabaseBuilder.readDataQuery(Query, connection);
            while (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    Int32 newNumber = Convert.ToInt32(reader.GetString(0).Substring(10)) + 1;
                    String serialNumber = newNumber.ToString().PadLeft(5, '0');
                    TrxNo += Helper.Date.getString() + serialNumber;
                }
                else
                {
                    TrxNo += Helper.Date.getString() + "00001";
                }
            }
            connection.Close();
            return TrxNo;
        }

        public static TrxPayment Find(String TrxNo)
        {
            TrxPayment trxPayment = new TrxPayment();
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readData(VariableBuilder.Table.TrxPayment, Columns, Columns[0] + "='" + TrxNo + "'", connection);
            while (reader.Read())
            {
                trxPayment.TrxNo = (reader.IsDBNull(0)) ? "" :reader.GetString(0);
                trxPayment.ModiID = (reader.IsDBNull(1)) ? -1 : Convert.ToInt32(reader.GetValue(1));
                trxPayment.MemberID = (reader.IsDBNull(2)) ? -1 : Convert.ToInt32(reader.GetValue(2));
                trxPayment.TotalAmount = (reader.IsDBNull(3)) ? 0 : Convert.ToDouble(reader.GetValue(3));
                trxPayment.TotalPay = (reader.IsDBNull(4)) ? 0 : Convert.ToDouble(reader.GetValue(4));
                trxPayment.CashBack = (reader.IsDBNull(5)) ? 0 : Convert.ToDouble(reader.GetValue(5));
                trxPayment.CreatedAt = reader.GetDateTime(6).ToString();
            }
            connection.Close();
            return trxPayment;
        }

        public static Double getProfit(String TrxNo) 
        {
            Double profit = 0;
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readDataQuery("SELECT * FROM V_PROFIT_TRX WHERE trx_no='" + TrxNo + "'",connection);
            while (reader.Read()) 
            {
                profit = Convert.ToDouble(reader.GetValue(2));
            }
            return profit;
        }

        
    }
}
