using Sales.libs;
using Sales.ui.data.supplier.processForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.ui.data.supplier
{
    public partial class supplierForm : BaseForm
    {
        public supplierForm()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newSupplier newForm = new newSupplier(this);
            Helper.Forms.startForm(newForm);
        }
    }
}
