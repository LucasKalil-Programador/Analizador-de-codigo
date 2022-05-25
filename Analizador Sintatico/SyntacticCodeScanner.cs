using AnalizadorLexicoToken;
using SyntacticScanner.Cases;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SyntacticScanner
{
    class SyntacticCodeScanner
    {
        private readonly Token[][] tokens;

        public SyntacticCodeScanner(Token[] tokens)
        {
            IList<IList<Token>> list = new List<IList<Token>>();
            string line = "";
            for (int i = 0; i < tokens.Length; i++)
            {
                if (tokens[i].lineIndex != line)
                {
                    list.Add(new List<Token>());
                    line = tokens[i].lineIndex;
                }

                list[list.Count - 1].Add(tokens[i]);
            }

            this.tokens = new Token[list.Count][];
            for (int i = 0; i < list.Count; i++)
                this.tokens[i] = list[i].ToArray();
        }

        public string Scan()
        {
            string result = "";

            for (int i = 0; i < tokens.Length; i++)
            {
                string tmpResult = ScanLine(tokens[i]);
                if(tmpResult != "") result += tmpResult + "\r\n";
            }
            
            return result == "" ? "Nenhum erro encontrado" : result;
        }

        public string ScanLine(Token[] line)
        {
            foreach(Token token in line)
            {
                if (token.GetPossibleError() != null)
                    return $"Existem erros lexicos na linha {token.lineIndex}";
            }

            Case[] cases = Case.GetAllCases();

            foreach (Case c in cases)
            {
                c.Line = line;
                if (c.CheckCase()) return c.Result;
            }

            return "";
        }
    }
}
