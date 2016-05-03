using Sales.libs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sales.model
{
    class Member : BaseModel
    {
        public static String[] Columns = {
                                            "member_id",
                                            "member_name",
                                            "member_telp",
                                            "member_address",
                                            "member_point",
                                            "prov_code",
                                            "reg_code",
                                            "dis_code",
                                            "vill_code",
                                            "created_at"
                                         };
        private Int64 _member_id;

        public Int64 Id
        {
            get { return _member_id; }
            set { _member_id = value; }
        }
        private String _member_name;

        public String Name
        {
            get { return _member_name; }
            set { _member_name = value; }
        }
        private String _member_telp;

        public String Telp
        {
            get { return _member_telp; }
            set { _member_telp = value; }
        }
        private String _member_address;

        public String Address
        {
            get { return _member_address; }
            set { _member_address = value; }
        }
        private Int64 _member_point=0;

        public Int64 Point
        {
            get { return _member_point; }
            set { _member_point = value; }
        }
        private Int32 _prov_code = 0;

        public Int32 ProvCode
        {
            get { return _prov_code; }
            set { _prov_code = value; }
        }
        private Int32 _reg_code = 0;

        public Int32 RegCode
        {
            get { return _reg_code; }
            set { _reg_code = value; }
        }
        private Int32 _dis_code = 0;

        public Int32 DisCode
        {
            get { return _dis_code; }
            set { _dis_code = value; }
        }
        private Int64 _vill_code = 0;

        public Int64 VillCode
        {
            get { return _vill_code; }
            set { _vill_code = value; }
        }

        private Int64 tmpId;

        public Int64 TmpId
        {
            get { return tmpId; }
            set { tmpId = value; }
        }
        public static QueryBuilder query()
        {
            table = VariableBuilder.Table.Member;
            return new QueryBuilder();
        }

        public void New() 
        {
            String[] selectedColumns = { Columns[0], Columns[1], Columns[2], Columns[3], Columns[4], Columns[5], Columns[6], Columns[7], Columns[8] };
            String[] values = { Id.ToString(), Name, Telp, Address, Point.ToString(), ProvCode.ToString(), RegCode.ToString(), DisCode.ToString(), VillCode.ToString()  };
            DatabaseBuilder.insert(VariableBuilder.Table.Member, selectedColumns, selectedColumns, values,"New member has been added successfully.");
        }

        public DataTable All() 
        {
            return DatabaseBuilder.read(VariableBuilder.Table.Member);
        }

        public static Member Find(Int64 member_id)
        {
            Member member = new Member();
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readData(VariableBuilder.Table.Member, Columns, Columns[0] + "='" + member_id + "'", connection);
            while (reader.Read())
            {
                member.Id = (reader.IsDBNull(0)) ? -1 : Convert.ToInt64(reader.GetValue(0));
                member.Name = (reader.IsDBNull(1)) ? "" : reader.GetString(1);
                member.Telp = (reader.IsDBNull(2)) ? "" : reader.GetString(2);
                member.Address = (reader.IsDBNull(3)) ? "" : reader.GetString(3);
                member.Point = (reader.IsDBNull(4)) ? 0 : Convert.ToInt64(reader.GetValue(4));
                member.ProvCode = (reader.IsDBNull(5)) ? 0 : Convert.ToInt32(reader.GetValue(5));
                member.RegCode = (reader.IsDBNull(6)) ? 0 : Convert.ToInt32(reader.GetValue(6));
                member.DisCode = (reader.IsDBNull(7)) ? 0 : Convert.ToInt32(reader.GetValue(7));
                member.VillCode = (reader.IsDBNull(8)) ? 0 : Convert.ToInt64(reader.GetValue(8));
                member.TmpId = member.Id;
            }
            connection.Close();
            return member;
        }

        public void Update() 
        {
            String[] selectedColumns = { Columns[0], Columns[1], Columns[2], Columns[3], Columns[4], Columns[5], Columns[6], Columns[7], Columns[8] };
            String[] values = { Id.ToString(), Name, Telp, Address, Point.ToString(), ProvCode.ToString(), RegCode.ToString(), DisCode.ToString(), VillCode.ToString() };
            DatabaseBuilder.update(VariableBuilder.Table.Member, selectedColumns, selectedColumns, values, Columns[0] + "='" + TmpId + "'", "Selected Member has been edited successfully.");   
        }

        public static void Destroy(Int64 member_id) 
        {
            DatabaseBuilder.destory(VariableBuilder.Table.Member, Columns[0], member_id.ToString(),"Selected member has been deleted successfully.");
        }

    }
}
