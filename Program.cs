﻿using System;
using System.Windows.Forms;

namespace AnalizadorMain
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AnalizadorWindow());
            Console.WriteLine("ola mundo");
            Console.WriteLine("ola mundo");
        }
    }
}
