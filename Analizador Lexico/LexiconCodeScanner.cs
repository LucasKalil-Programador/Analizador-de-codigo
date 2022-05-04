using AnalizadorLexicoToken;
using AnalizadorLexicoWord;
using Microsoft.WindowsAPICodePack.Taskbar;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LexiconScanner
{

    /// <summary>
    /// Classe que escanea um codigo
    /// </summary>
    public class LexiconCodeScanner
    {
        /// <summary>
        /// Lista de palavras a serem procuradas no codigo
        /// </summary>
        private readonly static Word[] ListOfWords =
            ((Word[])ReservedWord.reservedWords).Concat(NonReservedWord.nonReservedWords).ToArray();

        /// <summary>
        /// Resultado final do scan
        /// </summary>
        private readonly IList<Token> tokens = new List<Token>();

        /// <summary>
        /// Linhas de codigo onde cada linha é um indice do array
        /// </summary>
        private readonly string[] code;

        /// <summary>
        /// Construtor do CodeScanner 
        /// </summary>
        /// <param name="code">Linhas de codigo a serem escaneadas</param>
        public LexiconCodeScanner(string[] code) { this.code = code; }

        /// <summary>
        /// Realiza o scan processando o codigo passado
        /// </summary>
        /// <returns>Array contendo os tokens encontrados</returns>
        public Token[] Scan()
        {
            if (tokens.Count == 0)
            {
                for (int lineIndex = 0; lineIndex < code.Length; lineIndex++)
                {
                    TaskbarManager.Instance.SetProgressValue(lineIndex, code.Length);
                    ScanLine(code[lineIndex], lineIndex + 1);
                }

                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress);
            }
            return tokens.ToArray();
        }

        /// <summary>
        /// Realiza o scan de apenas uma linha e adiciona o resultado na lista de tokens
        /// </summary>
        /// <param name="line">Linha a ser escaneada</param>
        /// <param name="lineIndex">Numero da linha atual</param>
        private void ScanLine(string line, int lineIndex)
        {
            // rawLine uma copia da linha original 
            string rawLine = line;

            // Linha do inicio da interação
            string startLine;

            // Loop do scan
            do
            {
                // Define variaveis usadas
                startLine = line = line.Trim();
                int currentIndex = int.MaxValue;
                Regex currentRegex = null;
                Token currentToken = null;

                // Procura todas as palavras no codigo
                foreach (Word word in ListOfWords)
                {
                    Match match = word.WordRegex.Match(line);
                    if (match.Success && match.Index <= currentIndex)
                    {
                        currentIndex = match.Index;
                        currentRegex = word.WordRegex;
                        // Constroi um token com a palavra encontrada
                        currentToken = new Token(
                            word is ReservedWord w ? w.Lexema : match.Value,
                            word.Token,
                            tokens.Count.ToString(),
                            lineIndex.ToString());

                        // Caso ja seja 
                        if (currentIndex == 0) break;
                    }
                }

                if (currentRegex != null) line = currentRegex.Replace(line, "", 1);
                if (currentToken != null) tokens.Add(currentToken);
            } while (startLine != line);

            // Caso sobre algo significa que existe coisas invalidas 
            if (new Regex("\\S+").IsMatch(line))
                // Gera a mensagem de erro
                tokens.Add(new Token($"Linha com erro: {rawLine}", lineIndex.ToString()));
        }
    }
}
