namespace AnalizadorLexicoToken
{
    /// <summary>
    /// Representa um token no codigo
    /// </summary>
    public class Token
    {
        // Lexema encontrado pela  Code Scanner
        public readonly string lexema;

        // Tipo do token
        public readonly string type;

        // Possição a qual o token foi encontrado
        public readonly string index;

        // Linha a qual o token foi encontrado
        public readonly string lineIndex;

        // Sera nullo a menos se seja um erro
        private readonly string error;

        /// <summary>
        /// Construtor de um token valido
        /// </summary>
        /// <param name="lexema">Lexema encontrado pela  Code Scanner</param>
        /// <param name="type">Tipo do token</param>
        /// <param name="index">Possição a qual o token foi encontrado</param>
        /// <param name="lineIndex">Linha a qual o token foi encontrado</param>
        public Token(string lexema, string type, string index, string lineIndex)
        {
            this.lexema = lexema;
            this.type = type;
            this.index = index;
            this.lineIndex = lineIndex;
            this.error = null;
        }

        /// <summary>
        /// Caso o token seja um erro recebera apenas o erro e sua linha
        /// </summary>
        /// <param name="error">Mensagem de erro a ser exibida</param>
        /// <param name="lineIndex">Linha a qual o token foi encontrado</param>
        public Token(string error, string lineIndex)
        {
            this.lexema = null;
            this.type = null;
            this.index = null;
            this.lineIndex = lineIndex;
            this.error = error;
        }

        /// <summary>
        /// Converte o token em um array de string onde cada possição e uma propiedade do token
        /// </summary>
        /// <returns>new string[] { lineIndex, index, lexema, type }; array com tamanho fixo 4</returns>
        public string[] ToArray()
        {
            return new string[] { lineIndex, index, lexema, type };
        }

        /// <summary>
        /// caso exista um erro retorna o mesmo caso contrario retorna null
        /// </summary>
        /// <returns>Caso exista um erro retornara new string[] { lineIndex, error }; caso contrario retornara null </returns>
        public string[] GetPossibleError()
        {
            return error != null ? new string[] { lineIndex, error } : null;
        }
    }
}
