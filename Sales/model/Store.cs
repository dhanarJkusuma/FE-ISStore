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
        private String store_name;

        public String Name
        {
            get { return store_name; }
            set { store_name = value; }
        }
        private String store_phone;

        public String Phone
        {
            get { return store_phone; }
            set { store_phone = value; }
        }
        private String store_address;

        public String Address
        {
            get { return store_address; }
            set { store_address = value; }
        }

        private Double increment_point;

        public Double IncrementPoint
        {
            get { return increment_point; }
            set { increment_point = value; }
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
