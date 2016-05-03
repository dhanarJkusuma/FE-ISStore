using Sales.libs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.model
{
    class Region : BaseModel
    {

        public class Provinces 
        {
            private Int32 prov_code;

            public Int32 Code
            {
                get { return prov_code; }
                set { prov_code = value; }
            }
            private String prov_name;

            public String Name
            {
                get { return prov_name; }
                set { prov_name = value; }
            }

        }
        public class Regencies 
        {
            private Int32 reg_code;

            public Int32 Code
            {
                get { return reg_code; }
                set { reg_code = value; }
            }
            private Provinces province;

            public Provinces Province
            {
                get { return province; }
                set { province = value; }
            }


            
            private String reg_name;

            public String Name
            {
                get { return reg_name; }
                set { reg_name = value; }
            }
        }

        public class Districts 
        {
            private Int32 dis_code;

            public Int32 Code
            {
                get { return dis_code; }
                set { dis_code = value; }
            }
            private Regencies regency;

            public Regencies Regency
            {
                get { return regency; }
                set { regency = value; }
            }
            private String dis_name;

            public String Name
            {
                get { return dis_name; }
                set { dis_name = value; }
            }
        }

        public class Villages 
        {
            private Int64 vill_code;

            public Int64 Code
            {
                get { return vill_code; }
                set { vill_code = value; }
            }
            private Districts districts;

            public Districts Districts
            {
                get { return districts; }
                set { districts = value; }
            }
            private String vill_name;

            public String Name
            {
                get { return vill_name; }
                set { vill_name = value; }
            }
        }
        public static List<Provinces> FillProvinces(ComboBox comboBox)
        {
            List<Provinces> value = new List<Provinces>();
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            String[] columns = { "prov_code", "prov_name" };
            SqlDataReader reader = DatabaseBuilder.readData(VariableBuilder.Table.Provinces, columns, connection);
            while (reader.Read())
            {
                Provinces provinces = new Provinces();
                provinces.Code = reader.GetInt32(0);
                provinces.Name = reader.GetString(1);
                comboBox.Items.Add(provinces.Name);
                value.Add(provinces);
            }

            connection.Close();
            return value;
        }

        public static List<Regencies> FillRegencies(Provinces province, ComboBox comboBox)
        {
            List<Regencies> value = new List<Regencies>();
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            String[] columns = { "reg_code", "reg_name" };
            SqlDataReader reader = DatabaseBuilder.readData(VariableBuilder.Table.Regencies, columns, "prov_code='" + province.Code + "'", connection);
            while (reader.Read())
            {
                Regencies regency = new Regencies();
                regency.Code = reader.GetInt32(0);
                regency.Province = province;
                regency.Name = reader.GetString(1);
                comboBox.Items.Add(regency.Name);
                value.Add(regency);
            }

            connection.Close();
            return value;
        }


        public static List<Districts> FillDistricts(Regencies regency, ComboBox comboBox)
        {
            List<Districts> values = new List<Districts>();
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            String[] columns = { "dis_code", "dis_name" };
            SqlDataReader reader = DatabaseBuilder.readData(VariableBuilder.Table.Districts, columns, "reg_code='" + regency.Code + "'", connection);
            while (reader.Read())
            {
                Districts district = new Districts();
                district.Code = reader.GetInt32(0);
                district.Name = reader.GetString(1);
                district.Regency = regency;
                comboBox.Items.Add(district.Name);
                values.Add(district);
            }
            connection.Close();
            return values;
        }

        public static List<Villages> FillVillages(Districts district, ComboBox comboBox)
        {
            List<Villages> values = new List<Villages>();
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            String[] columns = { "vill_code", "vill_name" };
            SqlDataReader reader = DatabaseBuilder.readData(VariableBuilder.Table.Villages, columns, "dis_code='" + district.Code + "'", connection);
            while (reader.Read())
            {
                Villages village = new Villages();
                village.Code = reader.GetInt64(0);
                village.Name = reader.GetString(1);
                village.Districts = district;
                comboBox.Items.Add(village.Name);
                values.Add(village);
            }
            return values;
        }


    }
}
