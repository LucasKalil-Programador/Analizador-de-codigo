using AnalizadorLexicoToken;
using AnalizadorLexicoWord;
using Microsoft.WindowsAPICodePack.Taskbar;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AnalizadorLexicoScanner
{
    public class CodeScanner
    {
        private static NonReservedWord[] nonReservedWords = NonReservedWord.nonReservedWords;
        private static ReservedWord[] reservedWords = ReservedWord.reservedWords;

        private IList<Token> tokens = new List<Token>();
        private string[] code;

        public CodeScanner(string[] code)
        {
            this.code = code;
        }

        public Token[] Scan()
        {
            if (tokens.Count == 0)
            {
                for (int lineIndex = 0; lineIndex < code.Length; lineIndex++)
                {
                    TaskbarManager.Instance.SetProgressValue(lineIndex, code.Length);
                    ScanLine(code[lineIndex], tokens.Count, lineIndex + 1);
                }

                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress);
            }
            return tokens.ToArray();
        }

        private void ScanLine(string line, int index, int lineIndex)
        {
            string rawLine = line;

            while (true)
            {
                string startLine = line = line.Trim();
                Regex currentRegex = new Regex("");
                int currentIndex = int.MaxValue;
                Token currentToken = null;

                for (int i = 0; i < nonReservedWords.Length; i++)
                {
                    Match match = nonReservedWords[i].wordRegex.Match(line);
                    if (match.Success && match.Index < currentIndex)
                    {
                        currentIndex = match.Index;
                        currentRegex = nonReservedWords[i].wordRegex;
                        currentToken = new Token(match.Value, nonReservedWords[i].token, index.ToString(), lineIndex.ToString());
                        if (currentIndex == 0) break;
                    }
                }

                for (int i = 0; i < reservedWords.Length; i++)
                {
                    Match match = reservedWords[i].wordRegex.Match(line);
                    if (match.Success && match.Index <= currentIndex)
                    {
                        currentIndex = match.Index;
                        currentRegex = reservedWords[i].wordRegex;
                        currentToken = new Token(reservedWords[i].lexema, reservedWords[i].token, index.ToString(), lineIndex.ToString());
                        if (currentIndex == 0) break;
                    }
                }

                line = currentRegex.Replace(line, "", 1);
                if (currentToken != null) tokens.Add(currentToken);
                if (startLine == line) break;
                index++;
            }
          
            if (new Regex("\\S+").Match(line).Success)
                tokens.Add(new Token("Linha com erro: \"" + rawLine + "\"", lineIndex.ToString()));
        }
    }
}
