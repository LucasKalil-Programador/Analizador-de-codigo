﻿using AnalizadorLexicoToken;
using LexiconScanner;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.DialogResult;


namespace AnalyzerMain.Lexicon
{
    /// <summary>
    /// Janela aonde o analizador e exibido
    /// </summary>
    public partial class Window : Form
    {

        /// <summary>
        /// Execulta a inicialização da janela
        /// </summary>
        public Window(string initText)
        {
            InitializeComponent();
            fontSize.Value = (decimal)codeTextArea.Font.Size;
            codeTextArea.Text = initText;
        }

        /// <summary>
        /// Execultado ao alterar o texto no Code Text Area
        /// </summary>
        private void CodeTextArea_TextChanged(object sender, EventArgs e)
        {
            if (autoAnalize.Checked) UpdateTable();
        }

        /// <summary>
        /// Execultado ao clickar no Botao de analizar
        /// </summary>
        private void ButtonAnalize_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void UpdateTable()
        {
            long time = System.DateTime.Now.Ticks;
            LexiconCodeScanner analizador = new LexiconCodeScanner(codeTextArea.Lines);
            Token[] resultado = analizador.Scan();
            tokensTable.Rows.Clear();
            errorTable.Rows.Clear();

            for (int i = 0; i < resultado.Length; i++)
                if (resultado[i].GetPossibleError() == null)
                    tokensTable.Rows.Add(resultado[i].ToArray());
                else
                    errorTable.Rows.Add(resultado[i].GetPossibleError());
            Console.WriteLine("Tempo de processamento da analize Lexica demorou: " + new TimeSpan(System.DateTime.Now.Ticks - time));
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

        public bool GoToSyntacticAnalyzer { get; private set; }
        public string TextCode { get; private set; }

        private void GoToSyntacticAnalyzer_Click(object sender, EventArgs e)
        {
            GoToSyntacticAnalyzer = true;
            TextCode = codeTextArea.Text;
            Dispose();
        }

        private void OptionsLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
