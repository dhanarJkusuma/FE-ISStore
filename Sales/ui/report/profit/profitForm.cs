using Sales.libs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.ui.report.profit
{
    public partial class profitForm : Form
    {
        public profitForm()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (firstDate.Value <= secondDate.Value)
            {
                profitReport report = new profitReport();
                report.FirstDate = firstDate.Value.ToString("yyyy-MM-dd");
                report.SecondDate = secondDate.Value.ToString("yyyy-MM-dd");
                Helper.Forms.startForm(report);
            }
            else if (firstDate.Value > secondDate.Value) 
            {
                MessageBox.Show("Invalid date, First Date must be lower than Second Date");
            }
            
        }

        private void firstDate_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
