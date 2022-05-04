using System;
using System.IO;
using LexiconScanner;
using System.Drawing;
using SyntacticScanner;
using System.Windows.Forms;
using AnalizadorLexicoToken;
using static System.Windows.Forms.DialogResult;

namespace AnalyzerMain.Syntactic
{
    public partial class Window : Form
    {
        public Window(string initText)
        {
            InitializeComponent();
            fontSize.Value = (decimal)codeTextArea.Font.Size;
            codeTextArea.Text = initText;
        }

        private void ButtonAnalize_Click(object sender, EventArgs e)
        {
            UpdateErros();
        }

        private void ErrorsTextArea_TextChanged(object sender, EventArgs e)
        {
            if (autoAnalize.Checked) UpdateErros();
        }

        private void UpdateErros()
        {
            long time = System.DateTime.Now.Ticks;

            Token[] resultScan = new LexiconCodeScanner(codeTextArea.Lines).Scan();
            errorsTextArea.Text = new SyntacticCodeScanner(resultScan).Scan();

            Console.WriteLine("Tempo de processamento da analize Sintatica demorou: " + new TimeSpan(System.DateTime.Now.Ticks - time));
        }

        /// <summary>
        /// Execultado ao alterar o tamanho da font
        /// </summary>
        private void FontSize_ValueChanged(object sender, EventArgs e)
        {
            Font fontOld = codeTextArea.Font;
            codeTextArea.Font = new Font(
                fontOld.FontFamily,
                (float)fontSize.Value,
                fontOld.Style,
                fontOld.Unit,
                fontOld.GdiCharSet);
        }

        /// <summary>
        /// Execultado ao clickar para abrir um projeto
        /// </summary>
        private void OpenProjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == OK)
                {
                    string path = openFileDialog.FileName;
                    StreamReader streamReader = new StreamReader(path);
                    codeTextArea.Text = streamReader.ReadToEnd();
                    streamReader.Close();
                }
            }
            catch
            {
                codeTextArea.Text = "Arquivo não encontrado!";
            }
        }

        /// <summary>
        /// Execultado ao clickar para salvar um projeto
        /// </summary>
        private void SaveProjectButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == OK)
            {
                string path = saveFileDialog.FileName;
                StreamWriter streamWriter = new StreamWriter(path);
                streamWriter.Write(codeTextArea.Text);
                streamWriter.Flush();
                streamWriter.Close();
            }
        }

        public bool GoToLexiconAnalyzer { get; private set; }
        public string TextCode { get; private set; }

        private void GoToLexiconAnalyzerButton_Click(object sender, EventArgs e)
        {
            GoToLexiconAnalyzer = true;
            TextCode = codeTextArea.Text;
            Dispose();
        }
    }
}
