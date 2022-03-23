using AnalizadorLexicoScanner;
using AnalizadorLexicoToken;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace AnalizadorMain
{
    public partial class AnalizadorWindow : Form
    {

        public AnalizadorWindow()
        {
            InitializeComponent();
            fontSize.Value = (decimal)codeTextArea.Font.Size;
        }

        private void codeTextArea_TextChanged(object sender, EventArgs e)
        {
            if (autoAnalize.Checked) updateTable();
        }

        private void buttonAnalize_Click(object sender, EventArgs e)
        {
            updateTable();
        }

        private void updateTable()
        {
            long time = System.DateTime.Now.Ticks;
            CodeScanner analizador = new CodeScanner(codeTextArea.Lines);
            Token[] resultado = analizador.Scan();
            tokensTable.Rows.Clear();
            errorTable.Rows.Clear();

            for (int i = 0; i < resultado.Length; i++)
                if (resultado[i].GetPossibleError() == null)
                    tokensTable.Rows.Add(resultado[i].ToArray());
                else
                    errorTable.Rows.Add(resultado[i].GetPossibleError());
            Console.WriteLine(new TimeSpan(System.DateTime.Now.Ticks - time));
        }

        private void fontSize_ValueChanged(object sender, EventArgs e)
        {
            Font fontOld = codeTextArea.Font;
            codeTextArea.Font = new Font(
                fontOld.FontFamily,
                (float)fontSize.Value,
                fontOld.Style,
                fontOld.Unit,
                fontOld.GdiCharSet);
        }

        private void openProjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
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

        private void saveProjectButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                StreamWriter streamWriter = new StreamWriter(path);
                streamWriter.Write(codeTextArea.Text);
                streamWriter.Flush();
                streamWriter.Close();
            }
        }
    }
}
