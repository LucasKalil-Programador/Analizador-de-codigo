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
            new NonReservedWord("Numero inteiro", "\\d+")
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
          /*changed*/ new ReservedWord("GCamp",  "Modificador de acesso"),
          /*changed*/ new ReservedWord("GBell",  "Modificador de acesso"),
          /*changed*/ new ReservedWord("GGuard", "Modificador de acesso"),

          // Modificadores de classes, variáveis ou métodos
          /*changed*/ new ReservedWord("GNeutral", "Modificadores de classes, variáveis ou métodos"),
          /*changed*/ new ReservedWord("GDice",    "Modificadores de classes ou métodos"),
          /*changed*/ new ReservedWord("GTier",    "Declarador de clase"),
          /*changed*/ new ReservedWord("GCombo",   "Modificadores de classes"),
          /*changed*/ new ReservedWord("GOkizeme", "Modificadores de classes, variáveis ou métodos"),
          /*changed*/ new ReservedWord("GPlus",    "Modificadores de classes"),
          /*changed*/ new ReservedWord("GHud",     "Modificadores de classes"),
          /*changed*/ new ReservedWord("GCMneo",   "Inicializador de classe"),

          // Tipos primitivos
          /*changed*/ new ReservedWord("GHit",     "Tipo primitivo"),
          /*changed*/ new ReservedWord("GLight",   "Tipo primitivo"),
          /*changed*/ new ReservedWord("GNRdec",   "Tipo primitivo"),
          /*changed*/ new ReservedWord("GNRint",   "Tipo primitivo"),
          /*changed*/ new ReservedWord("GHeavy",   "Tipo primitivo"),
          /*changed*/ new ReservedWord("GEco",     "Tipo primitivo"),
          /*changed*/ new ReservedWord("GMinions", "Tipo primitivo"),
          /*changed*/ new ReservedWord("GWave",    "Tipo primitivo"),

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
          /*changed*/ new ReservedWord("GComboloop",       "Inicializador de loop",     "for"),
          /*changed*/ new ReservedWord("GWard",           "Inicializador condicional", "GWard"),
          /*changed*/ new ReservedWord("GGank",           "Continuação condiconal",    "GGank"),
          /*changed*/ new ReservedWord("GChalice",        "Inicializador condicional", "GChalice"),
          /*changed*/ new ReservedWord("GGlyph",          "Continuação condiconal",    "GGlyph"),
          /*changed*/ new ReservedWord("GLoop",           "Inicializador de loop",     "while"),
          /*changed*/ new ReservedWord("GSafeonblock",     "Identificador booleano",    "true"),
          /*changed*/ new ReservedWord("GNegativeonblock", "Identificador booleano",    "false"),

          // outros
          /*changed*/ new ReservedWord("GParry",      "Retorno de Metodo", "(\\s|^)GParry(\\s|;)"),
          /*changed*/ new ReservedWord("GFnull",       "Objeto nullo"),
          new ReservedWord(".", "Conector",           "\\."),
          new ReservedWord(";", "Final de instrução", ";"),
          new ReservedWord(",", "Separador",          ","),
          new ReservedWord("!", "Negação",            ","),
          new ReservedWord("?", "Operador Ternario",  "\\?"),
          new ReservedWord(":", "Operador Ternario",  ":")
        };
    }
}
