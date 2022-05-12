using System;

namespace SyntacticScanner.Cases
{

    // exemplos:
    // GBuy System.Collections.List; 
    // GBuy System;

    internal class ImportCase : Case
    {
        private bool oldCheck = true;

        public override bool CheckCase()
        {
            string lineIndex = Line.Length > 0 ? Line[0].lineIndex : "";

            for (int i = 0; i < Line.Length; i++)
            {
                if (State == 0)
                {
                    if (Line[i].lexema == "GBuy")
                    {
                        if(!oldCheck)
                        {
                            Result = $"linha {lineIndex} fora de lugar";
                            return true;
                        }

                        if (Line.Length == i + 1)
                        {
                            Result = $"Items faltando na linha {lineIndex}";
                            return true;
                        }
                        State = 1;
                    }
                    else
                    {
                        oldCheck = false;
                        return false;
                    }
                }
                else if (State == 1)
                {
                    if (Line[i].type == "Variavel")
                    {
                        if (Line.Length == i + 1)
                        {
                            Result = $"Esperado \";\" apos \"{Line[i].lexema}\" na linha {lineIndex}";
                            return true;
                        }
                        State = 2;
                    }
                    else
                    {
                        Result = $"Variavel faltando na linha {lineIndex}";
                        return true;
                    }
                }
                else if (State == 2)
                {
                    if (Line[i].lexema == ";")
                    {
                        if (Line.Length == i + 1)
                            return true;
                        State = 3;
                    }
                    else if (Line[i].lexema == ".")
                        State = 1;
                    else
                    {
                        Result = $"Esperado \".\" invés de \"{Line[i].lexema}\" na linha {lineIndex}";
                        return true;
                    }
                }
                else if (State == 3)
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

                        Result = $"Inesperado \"{Line[i].lexema}\" apos \";\"";
                        return true;
                    }
                }
            }

            throw new InvalidOperationException($"Erro inesperado no {this.GetType()}");
        }
    }
}
