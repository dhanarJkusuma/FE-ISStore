using Sales.libs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.model
{
    class SalesMenu
    {
        private String menu_id;

        public String ID
        {
            get { return menu_id; }
            set { menu_id = value; }
        }

        private List<SalesMenu> _childMenu;

        internal List<SalesMenu> ChildMenu
        {
            get { return _childMenu; }
            set { _childMenu = value; }
        }

        public static void fillTreeView(TreeView tree)
        {
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readData(VariableBuilder.Table.Menu, connection);
            int i = -1;
            int j = -1;
            while (reader.Read())
            {
                if (reader.GetInt32(2) == 0)
                {
                    tree.Nodes.Add(reader.GetString(0), reader.GetString(1));
                    i++;
                    j = -1;
                }
                else if (reader.GetInt32(2) == 1)
                {
                    tree.Nodes[i].Nodes.Add(reader.GetString(0), reader.GetString(1));
                    j ++;
                }
                else if (reader.GetInt32(2) == 2) 
                {
                    tree.Nodes[i].Nodes[j].Nodes.Add(reader.GetString(0), reader.GetString(1));
                }
                
            }

            connection.Close();
        }
    }
}
