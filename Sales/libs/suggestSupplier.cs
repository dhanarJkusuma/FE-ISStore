using Sales.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.libs
{
    public partial class suggestSupplier : Form
    {
        private String[] sColumns = {
                                        Supplier.Columns[0] + " as ID",
                                        Supplier.Columns[1] + " as Name"
                                    };

        BaseFormSuggest form;
        public suggestSupplier(BaseFormSuggest form)
        {
            InitializeComponent();
            setData();
            this.form = form;
            rID.Checked = true;
        }

        private void setData()
        {
            supplierGrid.DataSource = Supplier.Get(sColumns);
            supplierGrid.ReadOnly = true;
            supplierGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (supplierGrid.SelectedRows.Count == 1)
            {
                Supplier supplier = Supplier.Find(supplierGrid.SelectedRows[0].Cells[0].Value.ToString());
                form.populateSupplier(supplier);
                this.Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tBindGrid_TextChanged(object sender, EventArgs e)
        {
            if (rID.Checked)
            {
                Helper.Data.setBinding(supplierGrid, "ID", tBindGrid.Text);
            }
            else
            {
                Helper.Data.setBinding(supplierGrid, "Name", tBindGrid.Text);
            }
            
        }

        private void tBindGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
