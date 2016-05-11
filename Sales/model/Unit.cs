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
    public class Unit : BaseModel
    {

        public static String[] Columns = {
                                        "unit_code",
                                        "unit_name"
                                  };


        private String tmpCode;

        public String TmpCode
        {
            get { return tmpCode; }
            set { tmpCode = value; }
        }
        public static QueryBuilder query()
        {
            table = VariableBuilder.Table.Unit;
            return new QueryBuilder();
        }

        private String _code;

        public String Code
        {
            get { return _code; }
            set { _code = value; }
        }
        private String _name;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public static DataTable All() 
        {
            return DatabaseBuilder.read(VariableBuilder.Table.Unit,new String[] { Columns[0] + " as Code" ,Columns[1] + " as Name" });
        }

        public void New() 
        {
            String[] iparams = { "CodeSatuan", "NamaSatuan" };
            String[] values = { Code, Name };
            DatabaseBuilder.insert(VariableBuilder.Table.Unit, Columns, iparams, values, "New Unit has been added.");
        }

        public static Unit Find(String code) 
        {
            Unit unit = new Unit();
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readData(VariableBuilder.Table.Unit, Columns,Columns[0] + "='" + code + "'", connection);
            while (reader.Read())
            {
                unit.Code = reader.GetString(0);
                unit.Name = reader.GetString(1);
                unit.TmpCode = code;
            }
            connection.Close();   
            return unit;
        }

        public static String getUnitName(String code) 
        {
            String name="";
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readData(VariableBuilder.Table.Unit,new String[]{ Columns[1] }, Columns[0] + "='" + code + "'", connection);
            while (reader.Read())
            {
                name = reader.GetString(0);
            }
            connection.Close();
            return name;
        }


        public void Update() 
        {
            List<String> values = new List<String>(){ Code, Name };
            List<String> editedColumns = Columns.ToList();
            if (tmpCode == Code) 
            {
                values.RemoveAt(0);
                editedColumns.RemoveAt(0);
            }
           
            DatabaseBuilder.update(VariableBuilder.Table.Unit, editedColumns.ToArray(), editedColumns.ToArray(), values.ToArray(), Columns[0] + "='" + tmpCode + "'","Selected Unit has been edited.");
        }

        public static void Destroy(String id) 
        {
            DatabaseBuilder.destory(VariableBuilder.Table.Unit, Columns[0], id,"Selected Unit has been deleted.");
        }


        public static List<Unit> FillComboBox(ComboBox comboBox) 
        {
            List<Unit> values = new List<Unit>();
            
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readData(VariableBuilder.Table.Unit, connection);
            Unit other = new Unit();
            while (reader.Read())
            {
                String code = reader.GetString(0);
                if (code.Equals("OTHER"))
                {
                    other.Code = code;
                    other.Name = reader.GetString(1);
                }
                else 
                {
                    Unit unit = new Unit();
                    unit.Code = code;
                    unit.Name = reader.GetString(1);
                    comboBox.Items.Add(unit.Name);
                    values.Add(unit);
                }
                
            }
            comboBox.Items.Add(other.Name);
            values.Add(other);

            connection.Close();
            return values;
        }


    }
}
