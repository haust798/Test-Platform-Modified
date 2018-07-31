/*
 * Copyright (c) 2016 All Rights Reserved
 * Hugo Honda
 */

namespace TestPlatform
{
    using System;
    using System.Windows.Forms;
    using System.Globalization;
    using System.Threading;
    using TestPlatform.Views;

    public static class MainClass
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-US");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormMain application = new FormMain();
            Global.GlobalFormMain = application;
            Application.Run(application);
        }
    }
}
