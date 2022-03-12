﻿using System;
using System.Windows.Forms;

namespace GramAIO
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Properties.Settings.Default.username != null && Properties.Settings.Default.password != null)
            {
                Application.Run(new GramAIO());
            }
            else
            {
                Application.Run(new Form1());
            }
        }
    }
}
