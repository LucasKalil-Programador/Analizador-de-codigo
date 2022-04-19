using System;
using System.Windows.Forms;

namespace AnalizadorMain
{
    internal static class Program
    {
        // Main do analizador de codigo
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AnalizadorWindow());
        }    
    }
}
