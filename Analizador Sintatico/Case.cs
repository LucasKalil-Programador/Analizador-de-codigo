using AnalizadorLexicoToken;
using System;

namespace SyntacticScanner.Cases
{
    public abstract class Case
    {
        public Token[] Line { get; set; }

        public string Result { get; protected set; }

        protected int State = 0;

        public abstract bool CheckCase();

        public static Case[] GetAllCases() => new Case[] { new ImportCase(), new ReturnCase() };
    }
}
