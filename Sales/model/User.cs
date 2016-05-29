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
    public class User : BaseModel
    {
        public static String[] Columns = {
                                    "user_id",
                                    "user_name",
                                    "user_fullname",
                                    "user_password",
                                    "user_group",
                                    "created_at",
                                    "is_active"
                                  };

        private Int32 id;

        public Int32 Id
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
        private String password;

        private String fullname;

        public String FullName
        {
            get { return fullname; }
            set { fullname = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        private Int32 group;

        public Int32 Group
        {
            get { return group; }
            set { group = value; }
        }
        private String createdAt;

        public String CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
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
            String[] selectedColumns = { Columns[1],Columns[2],Columns[4],Columns[5] };
            return DatabaseBuilder.read(VariableBuilder.Table.User, selectedColumns);
        }

        public void Insert() 
        {
            String[] selectedColumns = { Columns[1], Columns[2], Columns[3], Columns[4] };
            String[] values = { Name, FullName, Password, Group.ToString() };
            DatabaseBuilder.insert(VariableBuilder.Table.User, selectedColumns, selectedColumns, values,"New User has been added.");
        }

        public void Update() 
        {
            String[] editedColumns = { Columns[1], Columns[2], Columns[3] , Columns[4] };
            String[] values = { Name, FullName, EncryptBuilder.EncryptString(Password), Group.ToString() };
            DatabaseBuilder.update(VariableBuilder.Table.User, editedColumns, editedColumns, values, Columns[0] + "=" + Id,"Selected User has been edited.");
        }

        public void UpdateNonMessage()
        {
            String[] editedColumns = { Columns[1], Columns[2], Columns[3], Columns[4] };
            String[] values = { Name, FullName, EncryptBuilder.EncryptString(Password), Group.ToString() };
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
            DatabaseBuilder.update(VariableBuilder.Table.User, new String[] { Columns[6] }, new String[] { Columns[6] }, new String[] { status.ToString() },Columns[0] + "=" + Id);
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
                user.FullName = reader.GetString(2);
                user.Password = EncryptBuilder.DecryptString(reader.GetString(3));
                user.Group = Convert.ToInt32(reader.GetValue(4));
                user.CreatedAt = reader.GetDateTime(5).ToString();
                user.IsActive = Convert.ToInt32(reader.GetValue(6));
            }
            connection.Close();
            return user;
        }

        public static bool Login(String username,String password) 
        {
            bool isLoggedIn = false;
            DataTable dt = DatabaseBuilder.read(VariableBuilder.Table.User,new String[] { Columns[0],Columns[1],Columns[2],Columns[3],Columns[4],Columns[5],Columns[6]} ,Columns[1] + "='" + username + "' and " + Columns[3] + "='" + password + "'");
            if (dt.Rows.Count > 0) 
            {
                User user = new User();
                user.Id = Convert.ToInt32(dt.Rows[0][0]);
                user.Name = dt.Rows[0][1].ToString();
                user.FullName = dt.Rows[0][2].ToString();
                user.Password = EncryptBuilder.DecryptString(dt.Rows[0][3].ToString());
                user.Group = Convert.ToInt32(dt.Rows[0][4]);
                user.CreatedAt = dt.Rows[0][5].ToString();
                user.IsActive = Convert.ToInt32(dt.Rows[0][6]);
                
                VariableBuilder.Session.userLogged = user;
                isLoggedIn = (user.IsActive == 1) ? true : false;
            }
            return isLoggedIn;
        }
    }
}
