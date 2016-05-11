using Sales.libs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sales.model
{
    public class User : BaseModel
    {
        public static String[] Columns = {
                                    "user_id",
                                    "user_name",
                                    "user_password",
                                    "user_group",
                                    "created_at",
                                    "is_active"
                                  };

        private Int32 _id;

        public Int32 Id
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
        private String _password;

        public String Password
        {
            get { return _password; }
            set { _password = value; }
        }
        private Int32 _group;

        public Int32 Group
        {
            get { return _group; }
            set { _group = value; }
        }
        private String _createdAt;

        public String CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value; }
        }

        private Int32 isActive;

        public Int32 IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }


        public static QueryBuilder query()
        {
            table = VariableBuilder.Table.User;
            return new QueryBuilder();
        }

        public static DataTable All() 
        {
            String[] selectedColumns = { Columns[1],Columns[3],Columns[4] };
            return DatabaseBuilder.read(VariableBuilder.Table.User, selectedColumns);
        }

        public void New() 
        {
            String[] selectedColumns = { Columns[1], Columns[2], Columns[3] };
            String[] values = { Name, Password , Group.ToString() };
            DatabaseBuilder.insert(VariableBuilder.Table.User, selectedColumns, selectedColumns, values,"New User has been added.");
        }

        public void Update() 
        {
            String[] editedColumns = { Columns[1], Columns[2], Columns[3] };
            String[] values = { Name, EncryptBuilder.EncryptString(Password), Group.ToString() };
            DatabaseBuilder.update(VariableBuilder.Table.User, editedColumns, editedColumns, values, Columns[0] + "=" + Id,"Selected User has been edited.");
        }

        public void UpdateNonMessage()
        {
            String[] editedColumns = { Columns[1], Columns[2], Columns[3] };
            String[] values = { Name, EncryptBuilder.EncryptString(Password), Group.ToString() };
            DatabaseBuilder.update(VariableBuilder.Table.User, editedColumns, editedColumns, values, Columns[0] + "=" + Id);
        }

        public static void Destroy(String id)
        {
            DatabaseBuilder.destory(VariableBuilder.Table.User, Columns[0], id);
        }

        public static Boolean isAdmin(String id) 
        {
            bool admin = false;
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readData(VariableBuilder.Table.User, new String[]{ "is_admin" }, Columns[0] + "='" + id + "'", connection);
            while (reader.Read())
            {
                int status = Convert.ToInt32(reader.GetValue(0));
                if (status == 1) 
                {
                    admin = true;
                }
            }
            connection.Close();
            return admin;
        }

        public void ChangeStatus(Int32 status) 
        {
            DatabaseBuilder.update(VariableBuilder.Table.User, new String[] { Columns[5] }, new String[] { Columns[5] }, new String[] { status.ToString() },Columns[0] + "=" + Id);
        }


        public static User Find(String id)
        {
            User user = new User();
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readData(VariableBuilder.Table.User, Columns, Columns[0] + "='" + id + "'", connection);
            while (reader.Read())
            {
                user.Id = Convert.ToInt32(reader.GetValue(0));
                user.Name = reader.GetString(1);
                user.Password = EncryptBuilder.DecryptString(reader.GetString(2));
                user.Group = Convert.ToInt32(reader.GetValue(3));
                user.CreatedAt = reader.GetDateTime(4).ToString();
                user.IsActive = Convert.ToInt32(reader.GetValue(5));
            }
            connection.Close();
            return user;
        }

        public static bool Login(String username,String password) 
        {
            bool isLoggedIn = false;
            DataTable dt = DatabaseBuilder.read(VariableBuilder.Table.User,new String[] { Columns[0],Columns[1],Columns[2],Columns[3],Columns[4],Columns[5]} ,Columns[1] + "='" + username + "' and " + Columns[2] + "='" + password + "'");
            if (dt.Rows.Count > 0) 
            {
                User user = new User();
                user.Id = Convert.ToInt32(dt.Rows[0][0]);
                user.Name = dt.Rows[0][1].ToString();
                user.Password = dt.Rows[0][2].ToString();
                user.Group = Convert.ToInt32(dt.Rows[0][3]);
                user.CreatedAt = dt.Rows[0][4].ToString();
                user.IsActive = Convert.ToInt32(dt.Rows[0][5]);
                
                VariableBuilder.Session.userLogged = user;
                isLoggedIn = (user.IsActive == 1) ? true : false;
            }
            return isLoggedIn;
        }
    }
}
