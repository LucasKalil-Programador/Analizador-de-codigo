using AnalizadorLexicoToken;
using System;

namespace SyntacticScanner.Cases
{
    public abstract class Case
    {
        public Token[] Line { get; set; }

        private string result = "";

        public string Result { get => result; protected set => result = value; }

        protected int State = 0;

        public abstract bool CheckCase();

        public static Case[] GetAllCases() => new Case[] { 
            new ImportCase(), 
            new ReturnCase(), 
            new PrimitiveCase() };
    }
}
