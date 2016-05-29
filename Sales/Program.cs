using Sales.ui;
using Sales.ui.report;
using Sales.ui.report.payment;
using Sales.ui.users.auth;
using Sales.ui.users.users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sales
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try 
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new splashScreen());
            }
            catch (Exception ex)
            {
                // Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
                // returns a folder that is usually allowed to write files to
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
