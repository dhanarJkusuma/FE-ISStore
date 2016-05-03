using Sales.libs;
using Sales.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.ui.data.supplier.processForm
{
    public partial class editSuppliercs : Form
    {
        List<Sales.model.Region.Provinces> provinces;
        List<Sales.model.Region.Regencies> regencies;
        List<Sales.model.Region.Districts> districts;
        List<Sales.model.Region.Villages> villages;
        BaseForm home;
        private Supplier currentSupplier;

        internal Supplier CurrentSupplier
        {
            get { return currentSupplier; }
            set { currentSupplier = value; }
        }
        public editSuppliercs()
        {
            InitializeComponent();
        }


    }
}
