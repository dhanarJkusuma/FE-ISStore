using Sales.libs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sales.model
{
    class TrxInvIncome : BaseModel
    {
        public static String[] Columns = {
                                            "trx_no",
                                            "modi_id",
                                            "supplier_id",
                                            "total_amount",
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
        private Int32 _supplier_id;

        public Int32 SupplierID
        {
            get { return _supplier_id; }
            set { _supplier_id = value; }
        }

        private Double amount;

        public Double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        private String _created_at;

        public String CreatedAt
        {
            get { return _created_at; }
            set { _created_at = value; }
        }

        public void New() 
        {
            String[] selectedColumns = {
                                "trx_no",
                                "modi_id",
                                "total_amount",
                                "created_at"
                                };

            TrxNo = generateTrxNo();
            ModiID = VariableBuilder.Session.userLogged.Id;
            CreatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            String[] values = { TrxNo, ModiID.ToString(), Amount.ToString() , CreatedAt };
            DatabaseBuilder.insert(VariableBuilder.Table.TrxInvIncome, selectedColumns, selectedColumns, values);
        }

        public static String generateTrxNo() 
        {
            String TrxNo= "IN";
            String Query = "SElECT MAX(trx_no) FROM trx_inv_income WHERE DATEADD(dd, 0, DATEDIFF(dd, 0, created_at))=DATEADD(dd, 0, DATEDIFF(dd, 0, GETDATE()))";
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

        public void Update() 
        {
            String[] editedColumns = { Columns[3] };
            String[] values = { Amount.ToString() };
            DatabaseBuilder.update(VariableBuilder.Table.TrxInvIncome, editedColumns, editedColumns, values, Columns[0] + "='" + TrxNo + "'");
        }

        public static DataTable Where(String condition) 
        {
            return DatabaseBuilder.read(VariableBuilder.Table.TrxInvIncome, condition);
        }

        public static QueryBuilder query()
        {
            table = VariableBuilder.Table.TrxInvIncome;
            return new QueryBuilder();
        }

        public static TrxInvIncome Find(String TrxNo) 
        {
            TrxInvIncome trxIncome = new TrxInvIncome();
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readData(VariableBuilder.Table.TrxInvIncome, Columns, Columns[0] + "='" + TrxNo + "'", connection);
            while (reader.Read())
            {
                trxIncome.TrxNo = reader.GetString(0);
                trxIncome.ModiID = Convert.ToInt32(reader.GetValue(1));
                trxIncome.SupplierID = (reader.IsDBNull(2)) ? -1 : Convert.ToInt32(reader.GetValue(2));
                trxIncome.Amount = (reader.IsDBNull(3)) ? 0 : Convert.ToDouble(reader.GetValue(3));
                trxIncome.CreatedAt = reader.GetDateTime(4).ToString();
            }
            connection.Close();
            return trxIncome;
        }
        
    }
}
