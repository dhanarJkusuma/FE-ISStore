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

namespace Sales.ui.transaction.incoming_item
{
    public partial class editPrice : Form
    {
        private Item itemFound;
        private BaseFormSuggest form;

        public editPrice(BaseFormSuggest form,Item item)
        {
            InitializeComponent();
            this.itemFound = item;
            this.form = form;
            tBarcode.Text = itemFound.Barcode;
            tNama.Text = itemFound.Name;
            tHarga.Text = itemFound.Price;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            itemFound.Price = tHarga.Text;
            itemFound.Update();
            this.form.populateItem(itemFound);
            this.Dispose();
        }

        private void tHarga_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void tHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.Forms.justNumber(e);
        }

        private void editPrice_Load(object sender, EventArgs e)
        {

        }




    }
}
