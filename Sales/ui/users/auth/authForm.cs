using Sales.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.ui.users.auth
{
    public partial class authForm : Form
    {
        public authForm()
        {
            InitializeComponent();
            SalesMenu.fillTreeView(authTree);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void authTree_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent != null) 
            {
                MessageBox.Show(e.Node.Name);
            }
            
        }
    }
}
