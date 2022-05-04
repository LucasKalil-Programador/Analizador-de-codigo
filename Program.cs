using System;
using System.Windows.Forms;

namespace AnalyzerMain
{
    internal static class Program
    {
        // Main do analizador de codigo
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Syntactic.Window syntacticWindow = null;
            Lexicon.Window lexiconWindow;


            while (true)
            {
                string initText = syntacticWindow == null ? "" : syntacticWindow.TextCode;
                Application.Run(lexiconWindow = new Lexicon.Window(initText));
                if (!lexiconWindow.GoToSyntacticAnalyzer) break;

                initText = lexiconWindow.TextCode;
                Application.Run(syntacticWindow = new Syntactic.Window(initText));
                if (!syntacticWindow.GoToLexiconAnalyzer) break;
            }
        }
    }
}
