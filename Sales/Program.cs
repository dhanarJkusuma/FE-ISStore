﻿using Sales.ui;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginForm());
        }
    }
}
