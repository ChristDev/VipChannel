﻿using System;
using VipChannel.Front.Definitions;
using VipChannel.Front.Principal;

namespace VipChannel.Front
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new FrmLogin());
        }
    }
}
