using Sales.libs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales.ui
{
    public partial class splashScreen : Form
    {
        credentialForm login;
        int second=0;
        public splashScreen()
        {
            InitializeComponent();
            login = new credentialForm();
            timer.Interval = 1000;
            timer1.Interval = 30;
            timer.Start();
            timer1.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            second += 1;
            if (second.Equals(4)) 
            {
                Helper.Forms.startForm(login);
                this.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
        }

        

        private void splashScreen_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
