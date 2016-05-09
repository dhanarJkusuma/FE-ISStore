using Sales.libs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Sales.model
{
    class Store
    {

        public static String[] Columns = { 
                                            "store_name",
                                            "store_address",
                                            "store_phone",
                                            "increment_point"
                                         };
        private String _store_name;

        public String Name
        {
            get { return _store_name; }
            set { _store_name = value; }
        }
        private String _store_phone;

        public String Phone
        {
            get { return _store_phone; }
            set { _store_phone = value; }
        }
        private String _store_address;

        public String Address
        {
            get { return _store_address; }
            set { _store_address = value; }
        }

        private Double _increment_point;

        public Double IncrementPoint
        {
            get { return _increment_point; }
            set { _increment_point = value; }
        }

        public static Store getInformation() 
        {
            Store store = new Store();
            SqlConnection connection = DatabaseBuilder.getConnection();
            connection.Open();
            SqlDataReader reader = DatabaseBuilder.readData(VariableBuilder.Table.Store, Columns, connection);
            while (reader.Read())
            {
                store.Name = reader.GetString(0);
                store.Address = reader.GetString(1);
                store.Phone = reader.GetString(2);
                store.IncrementPoint = Convert.ToDouble(reader.GetValue(3));
            }
            connection.Close();
            return store;
        }

        public void Update() 
        {
            String[] values = { Name, Address, Phone, IncrementPoint.ToString() };
            DatabaseBuilder.update(VariableBuilder.Table.Store, Columns, Columns, values);
        }
    }
}
