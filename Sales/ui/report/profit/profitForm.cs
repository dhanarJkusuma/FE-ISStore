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
        String[] monthDate = {
                            "January",
                            "February",
                            "March",
                            "April",
                            "May",
                            "June",
                            "July",
                            "August",
                            "September",
                            "October",
                            "November",
                            "December"
                         };
        public profitForm()
        {
            InitializeComponent();
            
            fillComboBox();
            rTrans.Checked = true;
            monthGroup.Enabled = false;
        }


        private void getProfitTrans_Click(object sender, EventArgs e)
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


       

        private void rTrans_CheckedChanged(object sender, EventArgs e)
        {
            if (rTrans.Checked)
            {
                transGroup.Enabled = true;
            }
            else
            {
                transGroup.Enabled = false;
            }
        }

        private void rMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (rMonth.Checked)
            {
                monthGroup.Enabled = true;
            }
            else 
            {
                monthGroup.Enabled = false;
            }
        }

        private void fillComboBox() 
        {
            for (int i = 0; i < 12; i++) 
            {
                cFirstDate.Items.Add(monthDate[i]);
                cSecondDate.Items.Add(monthDate[i]);
            }

            int now = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            for (int i = 1980; i <= now; i++) 
            {
                cFirstYear.Items.Add(i);
                cEndYear.Items.Add(i);
            }

            cFirstDate.SelectedIndex = Convert.ToInt32(DateTime.Now.ToString("MM"))-1;
            cSecondDate.SelectedIndex = Convert.ToInt32(DateTime.Now.ToString("MM"))-1;
            cFirstYear.SelectedItem = DateTime.Now.ToString("yyyy");
            cEndYear.SelectedItem = DateTime.Now.ToString("yyyy");
        }

        private void getProfitMonth_Click(object sender, EventArgs e)
        {
            MessageBox.Show("asu");
            profitMonthReport monthRep = new profitMonthReport();
            monthRep.FirstMonth = cFirstDate.SelectedIndex + 1;
            monthRep.SecondMonth = cSecondDate.SelectedIndex + 1;
            monthRep.FirstYear = Convert.ToInt32(cFirstYear.SelectedItem);
            monthRep.SecondYear = Convert.ToInt32(cEndYear.SelectedItem);
            Helper.Forms.startForm(monthRep);
        }
    }
}
