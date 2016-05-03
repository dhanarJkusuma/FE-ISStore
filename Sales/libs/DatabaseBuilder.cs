using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.libs
{
    class DatabaseBuilder
    {
        public static String getConnectionString()
        {
            String iniSection = "Database Configuration";
            INIBuilder inifiles = new INIBuilder(VariableBuilder.DirectoryLocation + "\\config.ini");
            SqlConnectionStringBuilder stringConnection = new SqlConnectionStringBuilder();
            stringConnection.DataSource = inifiles.Read(iniSection, "db_server");
            stringConnection.InitialCatalog = inifiles.Read(iniSection, "db_name");
            stringConnection.UserID = inifiles.Read(iniSection, "db_user");
            stringConnection.Password = EncryptBuilder.DecryptString(inifiles.Read(iniSection, "db_password"));
            return stringConnection.ConnectionString;
        }

        public static String generateStringColumns(String[] columns)
        {
            String q_columns = "";
            for (int i = 0; i < columns.Length; i++)
            {
                if (columns[i] != null) 
                {
                    if (i != columns.Length - 1)
                    {
                        q_columns += columns[i] + ",";
                    }
                    else
                    {
                        q_columns += columns[i];
                    }
                }
                
            }
            return q_columns;
        }

        public static String generateValueParams(String[] iparams)
        {
            String q_params = "";
            for (int i = 0; i < iparams.Length; i++)
            {
                if (iparams[i] != null) 
                {
                    if (i != iparams.Length - 1)
                    {
                        q_params += "@" + iparams[i] + ",";
                    }
                    else
                    {
                        q_params += "@" + iparams[i];
                    }
                }
            }
            return q_params;
        }

        public static String generateSetValueParams(String[] columns, String[] iparams)
        {
            String q_params = "";
            for (int i = 0; i < columns.Length; i++)
            {
                if (columns[i] != null && iparams[i] != null) 
                {
                    if (i != columns.Length - 1)
                    {
                        q_params += columns[i] + "=@" + iparams[i] + ",";
                    }
                    else
                    {
                        q_params += columns[i] + "=@" + iparams[i];
                    }
                }
                

            }
            return q_params;
        }



        public static void insert(String table, String[] columns, String[] iparams, String[] value)
        {
            SqlConnection openCon = new SqlConnection(getConnectionString());
            try
            {
                string query = "INSERT INTO " + table + " (" + generateStringColumns(columns) + ") VALUES ( " + generateValueParams(iparams) + ")";
              

                SqlCommand insCommand = new SqlCommand(query, openCon);
                for (int i = 0; i < iparams.Length; i++)
                {
                    insCommand.Parameters.AddWithValue("@" + iparams[i], value[i]);
                }
                openCon.Open();
                insCommand.ExecuteNonQuery();
                openCon.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

       

        public static void insert(String table, String[] columns, String[] iparams, String[] value, String messageSuccess)
        {
            SqlConnection openCon = new SqlConnection(getConnectionString());
            try
            {
                string query = "INSERT INTO " + table + " (" + generateStringColumns(columns) + ") VALUES ( " + generateValueParams(iparams) + ")";


                SqlCommand insCommand = new SqlCommand(query, openCon);
                for (int i = 0; i < iparams.Length; i++)
                {
                    insCommand.Parameters.AddWithValue("@" + iparams[i], value[i]);
                }
                openCon.Open();
                insCommand.ExecuteNonQuery();
                openCon.Close();
                MessageBox.Show(messageSuccess);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        public static DataTable read(String table)
        {
            SqlConnection openCon = new SqlConnection(getConnectionString());
            string query = "SELECT * FROM " + table;
            SqlDataAdapter adapter = new SqlDataAdapter(query, openCon);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static DataTable read(String table, String whereArgs)
        {
            SqlConnection openCon = new SqlConnection(getConnectionString());
            string query = "SELECT * FROM " + table + " WHERE " + whereArgs;
            SqlDataAdapter adapter = new SqlDataAdapter(query, openCon);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static DataTable read(String table, String[] columns)
        {
            SqlConnection openCon = new SqlConnection(getConnectionString());
            string query = "SELECT " + generateStringColumns(columns) + " FROM " + table;
            SqlDataAdapter adapter = new SqlDataAdapter(query, openCon);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static DataTable read(String table, String[] columns, String whereArgs)
        {
            SqlConnection openCon = new SqlConnection(getConnectionString());
            string query = "SELECT " + generateStringColumns(columns) + " FROM " + table + " WHERE " + whereArgs;
            SqlDataAdapter adapter = new SqlDataAdapter(query, openCon);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static DataTable query(String query, String[] columns)
        {
            query = query.Replace("*", generateStringColumns(columns));
            SqlConnection openCon = new SqlConnection(getConnectionString());
            SqlDataAdapter adapter = new SqlDataAdapter(query, openCon);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static DataTable query(String query)
        {
            SqlConnection openCon = new SqlConnection(getConnectionString());
            SqlDataAdapter adapter = new SqlDataAdapter(query, openCon);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }




        public static SqlConnection getConnection()
        {
            SqlConnection openCon = new SqlConnection(getConnectionString());
            return openCon;
        }

        public static SqlDataReader readData(String table, SqlConnection openCon)
        {


            string query = "SELECT * FROM " + table;
            SqlCommand cmd = new SqlCommand(query, openCon);
            SqlDataReader saReader = cmd.ExecuteReader();
            return saReader;

        }

        public static SqlDataReader readDataQuery(String query, SqlConnection openCon) 
        {
            SqlCommand cmd = new SqlCommand(query, openCon);
            SqlDataReader saReader = cmd.ExecuteReader();
            return saReader;
        }

        public static SqlDataReader readData(String table, String[] columns, SqlConnection openCon)
        {


            string query = "SELECT " + generateStringColumns(columns) + " FROM " + table;
            SqlCommand cmd = new SqlCommand(query, openCon);
            SqlDataReader saReader = cmd.ExecuteReader();
            return saReader;

        }

        public static SqlDataReader readData(String table, String[] columns, String condition, SqlConnection openCon)
        {


            string query = "SELECT " + generateStringColumns(columns) + " FROM " + table + " WHERE " + condition;
            SqlCommand cmd = new SqlCommand(query, openCon);
            SqlDataReader saReader = cmd.ExecuteReader();
            return saReader;

        }

        public static void update(String table, String[] columns, String[] iparams, String[] value, String whereArgs)
        {

            SqlConnection openCon = new SqlConnection(getConnectionString());
            try
            {
                string query = "UPDATE " + table + " SET  " + generateSetValueParams(columns, iparams) + " WHERE " + whereArgs;
                SqlCommand updateCommand = new SqlCommand(query, openCon);
                for (int i = 0; i < iparams.Length; i++)
                {
                    updateCommand.Parameters.AddWithValue("@" + iparams[i], value[i]);
                }
                openCon.Open();
                updateCommand.ExecuteNonQuery();
                openCon.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void update(String table, String[] columns, String[] iparams, String[] value, String whereArgs, String message)
        {

            SqlConnection openCon = new SqlConnection(getConnectionString());
            try
            {
                string query = "UPDATE " + table + " SET  " + generateSetValueParams(columns, iparams) + " WHERE " + whereArgs;
                //MessageBox.Show(query);
                SqlCommand updateCommand = new SqlCommand(query, openCon);
                for (int i = 0; i < iparams.Length; i++)
                {
                    updateCommand.Parameters.AddWithValue("@" + iparams[i], value[i]);
                }
                openCon.Open();
                updateCommand.ExecuteNonQuery();
                openCon.Close();
                MessageBox.Show(message);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void destory(String table, String columns, String value, String message)
        {
            SqlConnection openCon = new SqlConnection(getConnectionString());
            try
            {
                string query = "DELETE FROM " + table + " WHERE " + columns + "=@bindDelete";
                SqlCommand destroyCommand = new SqlCommand(query, openCon);
                destroyCommand.Parameters.AddWithValue("@bindDelete", value);
                openCon.Open();
                destroyCommand.ExecuteNonQuery();
                openCon.Close();
                MessageBox.Show(message);

            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.StackTrace);
            }
        }

        public static void destory(String table, String columns, String value)
        {
            SqlConnection openCon = new SqlConnection(getConnectionString());
            try
            {
                string query = "DELETE FROM " + table + " WHERE " + columns + "=@bindDelete";
                SqlCommand destroyCommand = new SqlCommand(query, openCon);
                destroyCommand.Parameters.AddWithValue("@bindDelete", value);
                openCon.Open();
                destroyCommand.ExecuteNonQuery();
                openCon.Close();
                

            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.StackTrace);
            }
        }

        public static void usingStoredProcedure(String storedProcedure, String[] iparams, String[] value)
        {
            SqlConnection openCon = new SqlConnection(getConnectionString());
            try
            {
                SqlCommand spCommand = new SqlCommand(storedProcedure, openCon);
                spCommand.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < iparams.Length; i++)
                {
                    spCommand.Parameters.AddWithValue("@" + iparams[i], value[i]);
                }
                openCon.Open();
                spCommand.ExecuteNonQuery();
                openCon.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void usingStoredProcedure(String storedProcedure, String[] iparams, String[] value,String message)
        {
            SqlConnection openCon = new SqlConnection(getConnectionString());
            try
            {
                SqlCommand spCommand = new SqlCommand(storedProcedure, openCon);
                spCommand.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < iparams.Length; i++)
                {
                    spCommand.Parameters.AddWithValue("@" + iparams[i], value[i]);
                }
                openCon.Open();
                spCommand.ExecuteNonQuery();
                openCon.Close();
                MessageBox.Show(message);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
