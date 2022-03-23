using System.Text.RegularExpressions;

namespace AnalizadorLexicoWord
{
    public abstract class Word
    {
        public string token { get; protected set; }
        public Regex wordRegex { get; protected set; }

        public Word(string token, string regex)
        {
            this.token = token;
            this.wordRegex = new Regex(regex);
        }
    }

    public class NonReservedWord : Word
    {
        public NonReservedWord(string token, string regex) : base(token, regex) { }

        public static NonReservedWord[] nonReservedWords = new NonReservedWord[]
        {
            new NonReservedWord("Texto",          "(?<!\\\\)\".*?(?<!\\\\)\\\""),
            new NonReservedWord("Character",      "'.?'"),
            new NonReservedWord("Variavel",       "[a-zA-Z]{1}\\w*"),

            // Numeros
            new NonReservedWord("Numero decimal", "(\\d+\\.\\d+)"),
            new NonReservedWord("Numero inteiro", "[\\d]+")
        };
    }

    public class ReservedWord : Word
    {
        public string lexema { get; }

        public ReservedWord(string lexema, string token, string regex) : base(token, regex)
        {
            this.lexema = lexema;
        }

        public ReservedWord(string lexema, string token) : base(token, "(\\s|^)" + lexema + "(\\s|$)")
        {
            this.lexema = lexema;
        }

        public static ReservedWord[] reservedWords = new ReservedWord[]
        {
          // Modificador de acesso
          new ReservedWord("private",   "Modificador de acesso"),
          new ReservedWord("public",    "Modificador de acesso"),
          new ReservedWord("protecte", "Modificador de acesso"),

          // Modificadores de classes, variáveis ou métodos
          new ReservedWord("static",    "Modificadores de classes, variáveis ou métodos"),
          new ReservedWord("abstract",  "Modificadores de classes ou métodos"),
          new ReservedWord("class",     "Declarador de clase"),
          new ReservedWord("extends",   "Modificadores de classes"),
          new ReservedWord("final",     "Modificadores de classes, variáveis ou métodos"),
          new ReservedWord("implements","Modificadores de classes"),
          new ReservedWord("interface", "Modificadores de classes"),
          new ReservedWord("new",       "Inicializador de classe"),

          // Tipos primitivos
          new ReservedWord("byte",    "Tipo primitivo"),
          new ReservedWord("short",   "Tipo primitivo"),
          new ReservedWord("int",     "Tipo primitivo"),
          new ReservedWord("long",    "Tipo primitivo"),
          new ReservedWord("boolean", "Tipo primitivo"),
          new ReservedWord("char",    "Tipo primitivo"),

          // Restritores
          new ReservedWord("{", "Abertura de restritor",    "\\{"),
          new ReservedWord("}", "Feichamento de restritor", "\\}"),
          new ReservedWord("(", "Abertura de restritor",    "\\("),
          new ReservedWord(")", "Feichamento de restritor", "\\)"),
          new ReservedWord("[", "Abertura de restritor",    "\\["),
          new ReservedWord("]", "Feichamento de restritor", "\\]"),
          new ReservedWord("<", "Abertura de restritor",    "\\<"),
          new ReservedWord(">", "Feichamento de restritor", "\\>"),

          // Comparadoradores
          new ReservedWord("!=", "Comparador", "!="),
          new ReservedWord("==", "Comparador", "=="),
          new ReservedWord(">=", "Comparador", ">="),
          new ReservedWord("<=", "Comparador", "<="),
          new ReservedWord(">", "Comparador",  ">"),
          new ReservedWord("<", "Comparador",  "<"),

          // Operadores matematicos
          new ReservedWord("+", "Operador matematico", "\\+"),
          new ReservedWord("*", "Operador matematico", "\\*"),
          new ReservedWord("/", "Operador matematico", "/"),
          new ReservedWord("-", "Operador matematico", "-"),
          new ReservedWord("=", "Operador matematico", "="),

          // Loops e condicionais
          new ReservedWord("for",   "Inicializador de loop",     "for"),
          new ReservedWord("if",    "Inicializador Condicional", "if"),
          new ReservedWord("while", "Inicializador de loop",     "while"),
          new ReservedWord("true",  "Identificador booleano",    "true"),
          new ReservedWord("false", "Identificador booleano",    "false"),

          // outros
          new ReservedWord("return", "Retorno de Metodo", "(\\s|^)return"),
          new ReservedWord("null", "Objeto nullo"),
          new ReservedWord(".", "Conector",           "\\."),
          new ReservedWord(";", "Final de instrução", ";"),
          new ReservedWord(",", "Separador",          ","),
          new ReservedWord("?", "Operador Ternario",  "\\?"),
          new ReservedWord(":", "Operador Ternario",  ":")
        };
    }
}
