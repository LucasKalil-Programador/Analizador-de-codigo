using System;
using System.Linq;

namespace SyntacticScanner.Cases
{
    // Exemplos 
    // GParry;
    // GParry 0;
    // GParry 1.1;
    // GParry variavel;
    // GParry variavelA.variavelB;
    // GParry "texto";

    internal class ReturnCase : Case
    {
        public override bool CheckCase()
        {
            string lineIndex = Line.Length > 0 ? Line[0].lineIndex : "";

            for (int i = 0; i < Line.Length; i++)
            {
                if (State == 0)
                {
                    if (Line[i].lexema == "GParry")
                    {
                        if (Line.Length == i + 1)
                        {
                            Result = $"Items faltando na linha {lineIndex}";
                            return true;
                        }
                        State = 1;
                    }
                    else
                        return false;
                }
                else if (State == 1)
                {
                    string[] types;
                    if (i >= 2)
                        types = new string[] { "Variavel" };
                    else
                        types = new string[] { "Texto", "Character", "Variavel", "Numero decimal", "Numero inteiro", "Identificador booleano" };

                    if (types.Contains(Line[i].type))
                    {
                        if (Line.Length == i + 1)
                        {
                            Result = $"Esperado \";\" apos \"{Line[i].lexema}\" na linha {lineIndex}";
                            return true;
                        }

                        if (Line[i].type == "Variavel")
                            State = 3;
                        else
                            State = 2;
                    }
                    else
                    {
                        Result = $"Items esperados na linha {Line[i].lineIndex}";
                        return true;
                    }
                }
                else if (State == 2)
                {
                    if (Line[i].lexema == ";")
                    {
                        if (Line.Length == i + 1)
                            return true;
                    }
                    else
                    {
                        string inesperados = "";
                        for (int j = i; j < Line.Length; j++)
                        {
                            inesperados += Line[j].lexema;
                        }

                        Result = $"Inesperado \"{Line[i].lexema}\"";
                        return true;
                    }
                }
                else if (State == 3)
                {
                    if (Line[i].lexema == ".")
                    {
                        if (Line.Length == i + 1)
                        {
                            Result = $"Esperado \";\" apos \"{Line[i].lexema}\" na linha {lineIndex}";
                            return true;
                        }
                        State = 1;
                    }
                    else
                    {
                        if (Line[i].lexema == ";")
                        {
                            if (Line.Length == i + 1)
                                return true;
                            State = 2;
                        }
                        else
                        {
                            Result = $"Esperado \".\" invés de \"{Line[i].lexema}\" na linha {lineIndex}";
                            return true;
                        }
                    }
                }
            }

            throw new InvalidOperationException($"Erro inesperado no {this.GetType()}");
        }
    }
}
