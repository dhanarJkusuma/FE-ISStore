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
    public class Category : BaseModel
    {
        public static String[] Columns = {
                                            "category_code",
                                            "category_name"
                                         };

        private String tmpCode;

        public String TmpCode
        {
            get { return tmpCode; }
            set { tmpCode = value; }
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

        public Category() 
        {
        
        }

        public static QueryBuilder query()
        {
            table = VariableBuilder.Table.Category;
            return new QueryBuilder();
        }

        public static DataTable All()
        {
            return DatabaseBuilder.read(
                            VariableBuilder.Table.Category, 
                            new String[]{
                                      Columns[0] + " as Code",
                                      Columns[1] + " as Name"
                            }
                    );
        }

        public void New() 
        {
            String[] values = { Code, Name };
            DatabaseBuilder.insert(VariableBuilder.Table.Category,Columns, Columns, values,"New Category has been added.");
        }

        public static Category Find(String code)
        {
            Category category = new Category();
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readData(VariableBuilder.Table.Category, Columns,Columns[0] + "='" + code + "'", connection);
            while (reader.Read())
            {
                category.Code = reader.GetString(0);
                category.Name = reader.GetString(1);
                category.TmpCode = code;
            }
            connection.Close();
            return category;
        }


        public void Update() 
        {
            List<String> values = new List<String>() { Code, Name };
            List<String> editedColumns = Columns.ToList();
            if (tmpCode == Code)
            {
                values.RemoveAt(0);
                editedColumns.RemoveAt(0);
            }

            DatabaseBuilder.update(VariableBuilder.Table.Category, editedColumns.ToArray(), editedColumns.ToArray(), values.ToArray(), Columns[0] + "='" + tmpCode + "'", "Selected Category has been edited.");
        }

        public static void Destroy(String code) 
        {
            DatabaseBuilder.destory(VariableBuilder.Table.Category, Columns[0], code, "Selected Category has been deleted.");
        }

        public static List<Category> FillComboBox(ComboBox comboBox) 
        {
            List<Category> values = new List<Category>();
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readData(VariableBuilder.Table.Category, connection);
            Category other = new Category();
            while (reader.Read())
            {
                String code = reader.GetString(0);

                if (code.Equals("CTGOTHER")){
                
                    other.Code = code;
                    other.Name = reader.GetString(1);
                }
                else 
                {
                    Category category = new Category();
                    category.Code = code;
                    category.Name = reader.GetString(1);
                    comboBox.Items.Add(category.Name);
                    values.Add(category);
                }
                
            }
            comboBox.Items.Add(other.Name);
            values.Add(other);

            connection.Close();
            return values;
        }


        
    }
}
