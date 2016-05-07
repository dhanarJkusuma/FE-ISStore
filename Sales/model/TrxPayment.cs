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
                                             "discount",
                                             "total_pay",
                                             "cash_back",
                                             "created_at",
                                             "is_processed"
                                         };

        private String _trx_no;

        public String TrxNo
        {
            get { return _trx_no; }
            set { _trx_no = value; }
        }
        private Int32 _modi_id;

        public Int32 ModiID
        {
            get { return _modi_id; }
            set { _modi_id = value; }
        }
        private Int64 _member_id=-1;

        public Int64 MemberID
        {
            get { return _member_id; }
            set { _member_id = value; }
        }
        private Double _total_amount = 0;

        public Double TotalAmount
        {
            get { return _total_amount; }
            set { _total_amount = value; }
        }
        private Double _discount = 0;

        public Double Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }
        private Double _total_pay = 0;

        public Double TotalPay
        {
            get { return _total_pay; }
            set { _total_pay = value; }
        }
        private Double _cash_back = 0;

        public Double CashBack
        {
            get { return _cash_back; }
            set { _cash_back = value; }
        }
        private String _created_at;

        public String CreatedAt
        {
            get { return _created_at; }
            set { _created_at = value; }
        }

        public static QueryBuilder query()
        {
            table = VariableBuilder.Table.TrxPayment;
            return new QueryBuilder();
        }

        public void New() 
        {
            String[] selectedColumns = {
                                            "trx_no",
                                            "modi_id",
                                            "member_id",
                                            "total_amount",
                                            "discount",
                                            "total_pay",
                                            "cash_back",
                                            "created_at"
                                        };

            TrxNo = generateTrxNo();
            ModiID = VariableBuilder.Session.userLogged.Id;
            CreatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            String[] values = {     TrxNo, 
                                    ModiID.ToString(), 
                                    (MemberID == -1) ? "" : MemberID.ToString(),
                                    TotalAmount.ToString(), 
                                    Discount.ToString(), 
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
                                            "discount",
                                            "total_pay",
                                            "cash_back"
                                        };
            String[] values = { MemberID.ToString(), TotalAmount.ToString(), Discount.ToString(), TotalPay.ToString(), CashBack.ToString() };
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
                trxPayment.Discount = (reader.IsDBNull(4)) ? 0 : Convert.ToDouble(reader.GetValue(4));
                trxPayment.TotalPay = (reader.IsDBNull(5)) ? 0 : Convert.ToDouble(reader.GetValue(5));
                trxPayment.CashBack = (reader.IsDBNull(6)) ? 0 : Convert.ToDouble(reader.GetValue(6));
                trxPayment.CreatedAt = reader.GetDateTime(7).ToString();
            }
            connection.Close();
            return trxPayment;
        }
        

        
    }
}
