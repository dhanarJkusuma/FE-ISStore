using Sales.libs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sales.model
{
    public class Member : BaseModel
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
        private Int64 id;

        public Int64 Id
        {
            get { return id; }
            set { id = value; }
        }
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private String telp;

        public String Telp
        {
            get { return telp; }
            set { telp = value; }
        }
        private String address;

        public String Address
        {
            get { return address; }
            set { address = value; }
        }
        private Int64 point=0;

        public Int64 Point
        {
            get { return point; }
            set { point = value; }
        }
        private Int32 prov_code = 0;

        public Int32 ProvCode
        {
            get { return prov_code; }
            set { prov_code = value; }
        }
        private Int32 reg_code = 0;

        public Int32 RegCode
        {
            get { return reg_code; }
            set { reg_code = value; }
        }
        private Int32 dis_code = 0;

        public Int32 DisCode
        {
            get { return dis_code; }
            set { dis_code = value; }
        }
        private Int64 vill_code = 0;

        public Int64 VillCode
        {
            get { return vill_code; }
            set { vill_code = value; }
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

        public void Insert() 
        {
            String[] selectedColumns = { Columns[0], Columns[1], Columns[2], Columns[3], Columns[4], Columns[5], Columns[6], Columns[7], Columns[8] };
            String[] values = { Id.ToString(), Name, Telp, Address, Point.ToString(), ProvCode.ToString(), RegCode.ToString(), DisCode.ToString(), VillCode.ToString()  };
            DatabaseBuilder.insert(VariableBuilder.Table.Member, selectedColumns, selectedColumns, values,"New member has been added successfully.");
        }

        public void setPoint(Int64 point) 
        {
            DatabaseBuilder.update(VariableBuilder.Table.Member, new String[] { Columns[4] }, new String[] { Columns[4] },new String[]{ point.ToString() }, Columns[0] + "=" + Id.ToString());
        }

        public static DataTable All() 
        {
            return DatabaseBuilder.read(VariableBuilder.Table.Member);
        }

        public static DataTable Get(String[] sColumns) 
        {
            return DatabaseBuilder.read(VariableBuilder.Table.Member, sColumns);
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

        public void UpdateSilence()
        {
            String[] selectedColumns = { Columns[0], Columns[1], Columns[2], Columns[3], Columns[4], Columns[5], Columns[6], Columns[7], Columns[8] };
            String[] values = { Id.ToString(), Name, Telp, Address, Point.ToString(), ProvCode.ToString(), RegCode.ToString(), DisCode.ToString(), VillCode.ToString() };
            DatabaseBuilder.update(VariableBuilder.Table.Member, selectedColumns, selectedColumns, values, Columns[0] + "='" + TmpId + "'");
        }

        public static void Destroy(Int64 member_id) 
        {
            DatabaseBuilder.destory(VariableBuilder.Table.Member, Columns[0], member_id.ToString(),"Selected member has been deleted successfully.");
        }

    }
}
