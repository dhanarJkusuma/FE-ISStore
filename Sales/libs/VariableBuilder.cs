using Sales.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.libs
{
    class VariableBuilder
    {
        public static String DirectoryLocation = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        public class Table
        {
            public static String User = "box_user";
            public static String Group = "box_user_group";
            public static String Member = "box_member";
            public static String Supplier = "box_supplier";
            public static String Unit = "box_unit";
            public static String Category = "box_category";
            public static String Item = "box_master_item";
            public static String StockItem = "box_master_stock";


            /* TABLE LOCATION */
            public static String Provinces = "box_provinces";
            public static String Regencies = "box_regencies";
            public static String Districts = "box_districts";
            public static String Villages = "box_villages";
            /* END TABLE LOCATION */

            /* TABLE TRANSACTION */
            public static String TrxInvIncome = "trx_inv_income";
            public static String TrxInvIncomeItem = "trx_inv_income_item";
            public static String TrxPayment = "trx_payment";
            public static String TrxPaymentItem = "trx_payment_item";
            /* END TABLE TRANSACTION */

            
        }

        public class Session 
        {
            public static User userLogged;
        }
        

        
    }
}
