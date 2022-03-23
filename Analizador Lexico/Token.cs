namespace AnalizadorLexicoToken
{
    public class Token
    {
        public string name { get; }
        public string type { get; }
        public string index { get; }
        public string lineIndex { get; }
        private string error { get; }

        public Token(string name, string type, string index, string lineIndex)
        {
            this.name = name;
            this.type = type;
            this.index = index;
            this.lineIndex = lineIndex;
            this.error = null;
        }

        public Token(string error, string lineIndex)
        {
            this.name = null;
            this.type = null;
            this.index = null;
            this.lineIndex = lineIndex;
            this.error = error;
        }

        public string[] ToArray()
        {
            return new string[] { lineIndex, index, name, type };
        }

        public string[] GetPossibleError()
        {
            return error != null ? new string[] { lineIndex, error } : null;
        }
    }
}
