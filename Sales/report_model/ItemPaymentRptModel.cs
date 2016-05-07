using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sales.report_model
{
    class ItemPaymentRptModel
    {
        private String barcode;

        public String Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }
        private String item_name;

        public String Item_name
        {
            get { return item_name; }
            set { item_name = value; }
        }
        private String price;

        public String Price
        {
            get { return price; }
            set { price = value; }
        }
        private Int32 qty;

        public Int32 Qty
        {
            get { return qty; }
            set { qty = value; }
        }
        private String sub_total;

        public String Sub_total
        {
            get { return sub_total; }
            set { sub_total = value; }
        }
    }
}
