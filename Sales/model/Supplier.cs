using Sales.libs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.model
{
    public class Supplier : BaseModel
    {
        public static String[] Columns = { 
                                            "supplier_id",
                                            "supplier_name",
                                            "supplier_desc",
                                            "supplier_telp",
                                            "supplier_address",
                                            "prov_code",
                                            "reg_code",
                                            "dis_code",
                                            "vill_code"
                                         };
        private String _id;

        public String No
        {
            get { return _id; }
            set { _id = value; }
        }
        private String _name;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private String _desc;

        public String Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }
        private String _telp;

        public String Telp
        {
            get { return _telp; }
            set { _telp = value; }
        }
        private String _address;

        public String Address
        {
            get { return _address; }
            set { _address = value; }
        }
        private Int32 _prov_code;

        public Int32 ProvCode
        {
            get { return _prov_code; }
            set { _prov_code = value; }
        }
        private Int32 _reg_code;

        public Int32 RegCode
        {
            get { return _reg_code; }
            set { _reg_code = value; }
        }
        private Int32 _dis_code;

        public Int32 DisCode
        {
            get { return _dis_code; }
            set { _dis_code = value; }
        }
        private Int64 _vill_code;

        public Int64 VillCode
        {
            get { return _vill_code; }
            set { _vill_code = value; }
        }

        private String _tmpNo;

        public String TmpNo
        {
            get { return _tmpNo; }
            set { _tmpNo = value; }
        }

        public static QueryBuilder query()
        {
            table = VariableBuilder.Table.Supplier;
            return new QueryBuilder();
        }
        public void New() 
        {
            String[] values = { No, Name, Desc, Telp, Address, ProvCode.ToString(), RegCode.ToString(), DisCode.ToString(), VillCode.ToString() };
            DatabaseBuilder.insert(VariableBuilder.Table.Supplier, Columns, Columns, values,"Supplier has been added successfully.");
        }

        public void Update() 
        {
            String[] values = { No, Name, Desc, Telp, Address, ProvCode.ToString(), RegCode.ToString(), DisCode.ToString(), VillCode.ToString() };
            DatabaseBuilder.update(VariableBuilder.Table.Supplier, Columns, Columns, values, Columns[0] + "='" + TmpNo + "'","Selected supplier has been edited successfully.");
        }

        public static DataTable Get(String[] selectedColumns) 
        {
            return DatabaseBuilder.read(VariableBuilder.Table.Supplier, selectedColumns);
        }

        public static Supplier Find(String No) 
        {
            Supplier supplier = new Supplier();
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readData(VariableBuilder.Table.Supplier, Columns, Columns[0] + "='" + No + "'", connection);
            while (reader.Read())
            {
                supplier.No = (reader.IsDBNull(0)) ? "" : reader.GetString(0);
                supplier.Name = (reader.IsDBNull(1)) ? "" : reader.GetString(1);
                supplier.Desc = (reader.IsDBNull(2)) ? "" : reader.GetString(2);
                supplier.Telp = (reader.IsDBNull(3)) ? "" : reader.GetValue(3).ToString();
                supplier.Address = (reader.IsDBNull(4)) ? "" : reader.GetString(4);
                supplier.ProvCode = (reader.IsDBNull(5)) ? 0 : Convert.ToInt32(reader.GetValue(5));
                supplier.RegCode = (reader.IsDBNull(6)) ? 0 : Convert.ToInt32(reader.GetValue(6));
                supplier.DisCode = (reader.IsDBNull(7)) ? 0 : Convert.ToInt32(reader.GetValue(7));
                supplier.VillCode = (reader.IsDBNull(8)) ? 0 : Convert.ToInt64(reader.GetValue(8));
                supplier.TmpNo = supplier.No;
            }
            connection.Close();
            return supplier;
        }

        public static void Destroy(String No) 
        {
            DatabaseBuilder.destory(VariableBuilder.Table.Supplier, Columns[0], No,"Selected supplier has been deleted successfully.");
        }

        public static String generateSupplierNo()
        {
            String TrxNo = "SN";
            String Query = "SElECT MAX(supplier_id) FROM " + VariableBuilder.Table.Supplier;
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();

            SqlDataReader reader = DatabaseBuilder.readDataQuery(Query, connection);
            while (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    Int32 newNumber = Convert.ToInt32(reader.GetString(0).Substring(2)) + 1;
                    String serialNumber = newNumber.ToString().PadLeft(5, '0');
                    TrxNo += serialNumber;
                }
                else
                {
                    TrxNo += "000001";
                }
            }
            connection.Close();
            return TrxNo;
        }

        public static List<Supplier> FillComboBox(ComboBox comboBox)
        {
            List<Supplier> values = new List<Supplier>();
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readData(VariableBuilder.Table.Supplier, connection);
            while (reader.Read())
            {
                Supplier supplier = new Supplier();
                supplier.No = reader.GetString(0);
                supplier.Name = reader.GetString(1);
                supplier.Desc = reader.GetString(2);
                supplier.Telp = reader.GetValue(3).ToString();
                supplier.Address = reader.GetString(4);
                supplier.ProvCode = Convert.ToInt32(reader.GetValue(5));
                supplier.RegCode = Convert.ToInt32(reader.GetValue(6));
                supplier.DisCode = Convert.ToInt32(reader.GetValue(7));
                supplier.VillCode = Convert.ToInt64(reader.GetValue(8));
                values.Add(supplier);
                comboBox.Items.Add(supplier.Name);
            }

            connection.Close();
            return values;
        }
    }
}
