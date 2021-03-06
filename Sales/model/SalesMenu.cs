﻿using Sales.libs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.model
{
    public class SalesMenu : BaseModel
    {
        public static String[] Columns = {
                                            "menu_id",
                                            "menu_name",
                                            "menu_lvl",
                                            "menu_root"
                                         };

        public static String[] UserRole = {
                                            "group_id",
                                            "menu_id",
                                            "updated_at",
                                            "is_actived"
                                          };

        
        private String menu_id;

        public String ID
        {
            get { return menu_id; }
            set { menu_id = value; }
        }

        public static QueryBuilder query()
        {
            table = VariableBuilder.Table.Menu;
            return new QueryBuilder();
        }

        public class CompareRole 
        {
            private String id;

            public String MenuID
            {
                get { return id; }
                set { id = value; }
            }
            private String name;

            public String MenuName
            {
                get { return name; }
                set { name = value; }
            }
            private Int32 level;

            public Int32 MenuLvl
            {
                get { return level; }
                set { level = value; }
            }
            private String root;

            public String MenuRoot
            {
                get { return root; }
                set { root = value; }
            }
            private Int32 is_actived=0;

            public Int32 isActived
            {
                get { return is_actived; }
                set { is_actived = value; }
            }
        }


        public class Role 
        {
            public static String[] UserRole = {
                                            "group_id",
                                            "menu_id",
                                            "updated_at",
                                            "is_actived"
                                          };
            private Int32 group_id;

            public Int32 GroupID
            {
                get { return group_id; }
                set { group_id = value; }
            }
            private String menu_id;

            private String root_menu;

            public String RootMenu
            {
                get { return root_menu; }
                set { root_menu = value; }
            }

            public String MenuID
            {
                get { return menu_id; }
                set { menu_id = value; }
            }
            private String updated_at = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ssyyyy-MM-dd HH:mm:ss");

            public String UpdatedAt
            {
                get { return updated_at; }
                set { updated_at = value; }
            }
            private Int32 is_actived=0;

            public Int32 IsActived
            {
                get { return is_actived; }
                set { is_actived = value; }
            }

            public void Update() 
            {
                String[] selectedUpdate = {
                                            "updated_at",
                                            "is_actived"
                                          };
                String[] values = {
                                    UpdatedAt,
                                    IsActived.ToString()
                                  };
                DatabaseBuilder.update(VariableBuilder.Table.Role, selectedUpdate, selectedUpdate, values, UserRole[0] + "='" + GroupID + "' and " + UserRole[1] + "='" + MenuID + "'");
            }
        }

        public static List<CompareRole> getAuth(Int32 groupId, Int32 menu_lv, String menu_root) 
        {
            List<CompareRole> values = new List<CompareRole>();
            String[] selectedColumns = {
                                    VariableBuilder.Table.Menu + ".menu_id",
                                    VariableBuilder.Table.Menu + ".menu_name",
                                    VariableBuilder.Table.Menu + ".menu_lvl",
                                    VariableBuilder.Table.Menu + ".menu_root",
                                    VariableBuilder.Table.Role + ".is_actived"                                            
                                };
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            String query = SalesMenu.
                                query()
                                .innerJoin(VariableBuilder.Table.Role)
                                .on(
                                    VariableBuilder.Table.Menu + ".menu_id"
                                    + "=" +
                                    VariableBuilder.Table.Role + ".menu_id"
                                )
                                .where(VariableBuilder.Table.Role + "." + UserRole[0] + "=" + groupId.ToString() + " and " + VariableBuilder.Table.Menu + "." + Columns[3] + "='" + menu_root + "'")
                                .Query(selectedColumns);
            SqlDataReader reader = DatabaseBuilder.readDataQuery(query, connection);
            while (reader.Read()) 
            {
                CompareRole cR = new CompareRole();
                cR.MenuID = reader.GetString(0);
                cR.MenuName = reader.GetString(1);
                cR.MenuLvl = Convert.ToInt32(reader.GetValue(2));
                cR.MenuRoot = reader.GetString(3);
                cR.isActived = Convert.ToInt32(reader.GetValue(4));
                values.Add(cR);
            }
            return values;
        }

        public static List<CompareRole> getAuth(Int32 groupId, Int32 menu_lv)
        {
            List<CompareRole> values = new List<CompareRole>();
            String[] selectedColumns = {
                                    VariableBuilder.Table.Menu + ".menu_id",
                                    VariableBuilder.Table.Menu + ".menu_name",
                                    VariableBuilder.Table.Menu + ".menu_lvl",
                                    VariableBuilder.Table.Menu + ".menu_root",
                                    VariableBuilder.Table.Role + ".is_actived"                                            
                                };
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            String query = SalesMenu.
                                query()
                                .innerJoin(VariableBuilder.Table.Role)
                                .on(
                                    VariableBuilder.Table.Menu + ".menu_id"
                                    + "=" +
                                    VariableBuilder.Table.Role + ".menu_id"
                                )
                                .where(VariableBuilder.Table.Role + "." + UserRole[0] + "=" + groupId.ToString())
                                .Query(selectedColumns);
            SqlDataReader reader = DatabaseBuilder.readDataQuery(query, connection);
            while (reader.Read())
            {
                CompareRole cR = new CompareRole();
                cR.MenuID = reader.GetString(0);
                cR.MenuName = reader.GetString(1);
                cR.MenuLvl = Convert.ToInt32(reader.GetValue(2));
                cR.MenuRoot = reader.GetString(3);
                cR.isActived = Convert.ToInt32(reader.GetValue(4));
                values.Add(cR);
            }
            return values;
        }

        public static List<Role> fillTreeView(TreeView tree, Int32 role)
        {
            List<Role> values = new List<Role>();
            String[] selectedColumns = {
                                    VariableBuilder.Table.Menu + ".menu_id",
                                    VariableBuilder.Table.Menu + ".menu_name",
                                    VariableBuilder.Table.Menu + ".menu_lvl",
                                    VariableBuilder.Table.Menu + ".menu_root",
                                    VariableBuilder.Table.Role + ".is_actived"                                            
                                };
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            String query = SalesMenu.
                                query()
                                .innerJoin(VariableBuilder.Table.Role)
                                .on(
                                    VariableBuilder.Table.Menu + ".menu_id" 
                                    + "=" +
                                    VariableBuilder.Table.Role + ".menu_id"
                                )
                                .where(VariableBuilder.Table.Role + "." + UserRole[0] + "=" + role.ToString())
                                .Query(selectedColumns);
            SqlDataReader reader = DatabaseBuilder.readDataQuery(query, connection);
            int i = -1;
            int j = -1;
            while (reader.Read())
            {
                Role groupRole = new Role();
                groupRole.GroupID = role;
                groupRole.MenuID = reader.GetString(0);
                groupRole.RootMenu = reader.GetString(3);
                groupRole.UpdatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                groupRole.IsActived = Convert.ToInt32(reader.GetValue(4));

                if (reader.GetInt32(2) == 0)
                {
                    TreeNode node = new TreeNode();
                    node.Name = groupRole.MenuID;
                    node.Text = reader.GetString(1);
                    if (groupRole.IsActived == 1) 
                    {
                        node.Checked = true;
                    }
                    tree.Nodes.Add(node);
                    i++;
                    j = -1;
                }
                else if (reader.GetInt32(2) == 1)
                {
                    TreeNode node = new TreeNode();
                    node.Name = groupRole.MenuID;
                    node.Text = reader.GetString(1);
                    if (groupRole.IsActived == 1)
                    {
                        node.Checked = true;
                    }
                    tree.Nodes[i].Nodes.Add(node);
                    j ++;
                }
                else if (reader.GetInt32(2) == 2) 
                {
                    TreeNode node = new TreeNode();
                    node.Name = groupRole.MenuID;
                    node.Text = reader.GetString(1);
                    if (groupRole.IsActived == 1)
                    {
                        node.Checked = true;
                    }
                    tree.Nodes[i].Nodes[j].Nodes.Add(node);
                }
                values.Add(groupRole);
            }

            connection.Close();
            return values;
        }
    }
}
