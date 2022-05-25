using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntacticScanner.Cases
{

    // Exemplo:
    // GNRdec = 1334.56;
    // GGuard GNRdec = 2323.6767;
    // GLight result = 34;
    class PrimitiveCase : Case
    {
        public override bool CheckCase()
        {
            string lineIndex = Line.Length > 0 ? Line[0].lineIndex : "";
            
            for (int i = 0; i < Line.Length; i++)
            {
                if (State == 0)
                {
                    if (Line[i].type == "Tipo primitivo")
                    {
                        if (Line.Length == i + 1)
                        {
                            Result = $"\"Esperado expreção apos {Line[i].lexema}\" na linha {lineIndex}";
                            return true;
                        }
                        State = 3;
                    }
                    else if (Line[i].type == "Modificador de acesso"
                          || Line[i].type == "Modificadores de classes, variáveis ou métodos")
                    {
                        if (Line.Length == i + 1)
                        {
                            return false;
                        }
                        State = 1;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (State == 1)
                {
                    if (Line[i - 1].type == "Modificador de acesso")
                    {
                        if (Line[i].type == "Modificadores de classes, variáveis ou métodos")
                        {
                            if (Line.Length == i + 1)
                            {
                                return false;
                            }
                            State = 2;
                        } 
                        else
                        {
                            if(Line[i].type == "Tipo primitivo")
                            {
                                if (Line.Length == i + 1)
                                {
                                    Result = $"Esperado variavel apos \"{Line[i].lexema}\" na linha {lineIndex}";
                                    return true;
                                }
                                State = 3;
                            }
                        }
                    }
                    else if (Line[i - 1].type == "Modificadores de classes, variáveis ou métodos")
                    {
                        if (Line[i].type == "Modificador de acesso")
                        {
                            if (Line.Length == i + 1)
                            {
                                return false;
                            }
                            State = 2;
                        }
                        else
                        {
                            if (Line[i].type == "Tipo primitivo")
                            {
                                if (Line.Length == i + 1)
                                {
                                    Result = $"Esperado variavel apos \"{Line[i].lexema}\" na linha {lineIndex}";
                                    return true;
                                }
                                State = 3;
                            }
                        }
                    }
                    else
                    {
                        if (Line.Length == i + 1)
                        {
                            return false;
                        }
                        State = 2;
                    }
                }
                else if (State == 2)
                {
                    if (Line[i].type == "Tipo primitivo")
                    {
                        if (Line.Length == i + 1)
                        {
                            Result = $"Esperado expreção apos \"{Line[i].lexema}\" na linha {lineIndex}";
                            return true;
                        }
                        State = 3;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (State == 3)
                {
                    if (Line[i].type == "Variavel")
                    {
                        if (Line.Length == i + 1)
                        {
                            Result = $"Esperardo expreção apos \"{Line[i].lexema}\" na linha {lineIndex}";
                            return true;
                        }
                        State = 4;
                    }
                    else
                    {
                        Result = $"Esperardo uma variavel ao inves de \"{Line[i].lexema}\" na linha {lineIndex}";
                        return true;
                    }
                }
                else if (State == 4)
                {
                    if (Line[i].lexema == "=")
                    {
                        if (Line.Length == i + 1)
                        {
                            Result = $"Esperado expreção apos \"{Line[i].lexema}\" na linha {lineIndex}";
                            return true;
                        }
                        State = 5;
                    }
                    else if (Line[i].lexema == ";")
                    {
                        if (Line.Length == i + 1)
                        {
                            return true;
                        }
                        State = 7;
                    }
                    else
                    {
                        Result = $"Esperado ';' apos \"{Line[i].lexema}\" na linha {lineIndex}";
                        return true;
                    }
                }
                else if (State == 5)
                {
                    if (Line[i].type == "Variavel"
                    || Line[i].type == "Numero decimal"
                    || Line[i].type == "Numero inteiro")
                    {
                        if (Line.Length == i + 1)
                        {
                            Result = $"Esperado ';' apos \"{Line[i].lexema}\" na linha {lineIndex}";
                            return true;
                        }
                        if (Line[i + 1].lexema == ";")
                        {
                            if (Line.Length == i + 1)
                            {
                                Result = $"Esperado ';' apos \"{Line[i].lexema}\" na linha {lineIndex}";
                                return true;
                            }
                            State = 7;
                        }
                        else
                        {
                            State = 6;
                        }
                    }
                    else
                    {
                        Result = $"Inesperado {Line[i].lexema} na linha {lineIndex}";
                        return true;
                    }
                }
                else if (State == 6)
                {
                    if (Line[i].type == "Operador matematico")
                    {
                        if (Line.Length == i + 1)
                        {
                            Result = $"Esperado variavel apos \"{Line[i].lexema}\" na linha {lineIndex}";
                            return true;
                        }
                        State = 5;
                    }
                    else if (Line[i].lexema == ";")
                    {
                        if (Line.Length == i + 1)
                        {
                            Result = $"Esperado ';' apos \"{Line[i].lexema}\" na linha {lineIndex}";
                            return true;
                        }
                        State = 7;
                    }
                    else
                    {
                        Result = $"Esperado ';' apos \"{Line[i].lexema}\" na linha {lineIndex}";
                        return true;
                    }
                }
                else if (State == 7)
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

                        Result = $"Inesperado \"{Line[i].lexema}\" apos \";\" na linha {lineIndex}";
                        return true;
                    }
                }
            }

            throw new InvalidOperationException($"Erro inesperado no {this.GetType()}");
        }
    }
}
