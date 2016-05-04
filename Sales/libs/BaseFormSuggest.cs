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
    public partial class BaseFormSuggest : Form
    {
        public BaseFormSuggest()
        {
            InitializeComponent();
        }

        public virtual void populateItem(Item item) 
        {
        
        }

        public virtual void populateMember(Member member) 
        {
            
        }

        public virtual void populateSupplier(Supplier supplier) 
        {
        
        }

    }
}
