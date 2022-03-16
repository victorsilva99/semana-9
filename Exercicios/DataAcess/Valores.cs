namespace Exercicio.DataAccess
{
    public class Valores
    {
        #region Variaveis 
        public static double Resultado { get; set; }
        public static int Operacao { get; set; }
        public static string Sinal { get; set; }
        public static string Mensagem { get; set; }
        public static double PrimeiroValor { get; set; }
        public static double SegundoValor { get; set; }
        #endregion

        #region Construtor
        public Valores(double resultado, int operacao, string sinal, string mensagem, double primerioValor, double segundoValor)
        {
            Resultado = resultado;
            Operacao = operacao;
            Sinal = sinal;
            Mensagem = mensagem;
            PrimeiroValor = primerioValor;
            SegundoValor = segundoValor;
        }
        #endregion
    }
}
