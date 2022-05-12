using System.Text.RegularExpressions;

namespace AnalizadorLexicoWord
{

    /// <summary>
    /// Representação base para palavras do analizador
    /// </summary>
    public abstract class Word
    {

        /// <summary>
        /// Tipo do token que essa palavra representa
        /// </summary>
        public string Token { get; protected set; }

        /// <summary>
        /// Regex usado no reconhecimento na analize
        /// </summary>
        public Regex WordRegex { get; protected set; }

        /// <summary>
        /// Construtor base de uma palavra
        /// </summary>
        /// <param name="token">Tipo do token a ser apresentado</param>
        /// <param name="regex">String contem a expreção regular do regex</param>
        public Word(string token, string regex)
        {
            this.Token = token;
            this.WordRegex = new Regex(regex);
        }
    }

    /// <summary>
    /// Representação de uma palavra não reservada do codigo
    /// </summary>
    public class NonReservedWord : Word
    {
        /// <summary>
        /// Construtor passa para o construtor de Word os parametros
        /// </summary>
        /// <param name="token">Tipo do token a ser apresentado</param>
        /// <param name="regex">String contem a expreção regular do regex</param>
        public NonReservedWord(string token, string regex) : base(token, regex) { }

        /// <summary>
        /// Lista com todas as Palavras Não reservadas
        /// </summary>
        public readonly static NonReservedWord[] nonReservedWords = new NonReservedWord[]
        {
            // Texto char ou strings
            new NonReservedWord("Texto",          "(?<!\\\\)\".*?(?<!\\\\)\\\""),
            new NonReservedWord("Character",      @"'.?'"),

            // Variavel
            new NonReservedWord("Variavel",       @"(?!G)(?<!\w)[a-zA-Z]{1}\w*"),

            // Numeros
            new NonReservedWord("Numero decimal", @"(\d+\.\d+)"),
            new NonReservedWord("Numero inteiro", @"\d+")
        };
    }

    /// <summary>
    /// Representa uma palavra reservada
    /// </summary>
    public class ReservedWord : Word
    {

        /// <summary>
        /// Lexema encontrado no codigo
        /// </summary>
        public string Lexema { get; }

        /// <summary>
        /// Construtor para uma palavra reservada
        /// </summary>
        /// <param name="lexema">Lexema a ser apresentado</param>
        /// <param name="token">Tipo do token a ser apresentado</param>
        /// <param name="regex">String contem a expreção regular do regex</param>
        public ReservedWord(string lexema, string token, string regex) : base(token, regex)
        {
            this.Lexema = lexema;
        }

        /// <summary>
        /// Construto que gera a string do regex apartir do lexema
        /// </summary>
        /// <param name="lexema"></param>
        /// <param name="token"></param>
        public ReservedWord(string lexema, string token) : base(token, @"(\s|^)" + lexema + @"(\s|$)")
        {
            this.Lexema = lexema;
        }

        /// <summary>
        /// Lista com todas as palavras reservadas
        /// </summary>
        public readonly static ReservedWord[] reservedWords = new ReservedWord[]
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
          /*changed*/ new ReservedWord("GEcko",     "Tipo primitivo"),
          /*changed*/ new ReservedWord("GMinions", "Tipo primitivo"),
          /*changed*/ new ReservedWord("GWave",    "Tipo primitivo"),

          // Restritores
          new ReservedWord("{", "Abertura de restritor",    @"\{"),
          new ReservedWord("}", "Feichamento de restritor", @"\}"),
          new ReservedWord("(", "Abertura de restritor",    @"\("),
          new ReservedWord(")", "Feichamento de restritor", @"\)"),
          new ReservedWord("[", "Abertura de restritor",    @"\["),
          new ReservedWord("]", "Feichamento de restritor", @"\]"),
          new ReservedWord("<", "Abertura de restritor",    @"\<"),
          new ReservedWord(">", "Feichamento de restritor", @"\>"),

          // Comparadoradores
          new ReservedWord("!=", "Comparador", "!="),
          new ReservedWord("==", "Comparador", "=="),
          new ReservedWord(">=", "Comparador", ">="),
          new ReservedWord("<=", "Comparador", "<="),
          new ReservedWord(">", "Comparador",  ">"),
          new ReservedWord("<", "Comparador",  "<"),

          // Operadores matematicos
          new ReservedWord("+", "Operador matematico", @"\+"),
          new ReservedWord("*", "Operador matematico", @"\*"),
          new ReservedWord("/", "Operador matematico", "/"),
          new ReservedWord("-", "Operador matematico", "-"),
          new ReservedWord("=", "Operador matematico", "="),

          // Loops e condicionais
          /*changed*/ new ReservedWord("GComboloop",       "Inicializador de loop",     "GComboloop"),
          /*changed*/ new ReservedWord("GWard",           "Inicializador condicional",  "GWard"),
          /*changed*/ new ReservedWord("GGank",           "Continuação condiconal",     "GGank"),
          /*changed*/ new ReservedWord("GChalice",        "Inicializador condicional",  "GChalice"),
          /*changed*/ new ReservedWord("GGlyph",          "Continuação condiconal",     "GGlyph"),
          /*changed*/ new ReservedWord("GLoop",           "Inicializador de loop",      "GLoop"),
          /*changed*/ new ReservedWord("GSafeonblock",     "Identificador booleano",    "GSafeonblock"),
          /*changed*/ new ReservedWord("GNegativeonblock", "Identificador booleano",    "GNegativeonblock"),

          // outros
          /*changed*/ new ReservedWord("GBuy",     "Import de clases externas"),
          /*changed*/ new ReservedWord("GParry",   "Retorno de Metodo"),
          /*changed*/ new ReservedWord("GFnull",   "Objeto nullo"),
          new ReservedWord(".", "Conector",          @"\."),
          new ReservedWord(";", "Final de instrução", ";"),
          new ReservedWord(",", "Separador",          ","),
          new ReservedWord("!", "Negação",            ","),
          new ReservedWord("?", "Operador Ternario", @"\?"),
          new ReservedWord(":", "Operador Ternario",  ":")
        };
    }
}
