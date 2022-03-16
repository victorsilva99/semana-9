using static System.Console;

using static Exercicio.BussnessLogic.RetornosNoConsole;
using static Exercicio.BussnessLogic.Validacao;


namespace Exercicio.Interface
{
    public class InsercaoDados
    {
        static void Main(string[] args)
        {
            IniciarCalculadora();
        }
        #region Inicio do programa
        public static void IniciarCalculadora()
        {
            WriteLine(MensagemInicial());
            
            WriteLine("Deseja iniciar agora? (S/N)");
            string iniciar = ReadLine().ToUpper();

            if (iniciar == "S")
                InformarPrimeiroNumero();
            else
                WriteLine("Até logo!");
        }
        #endregion
        #region Informando o primeiro número
        public static void InformarPrimeiroNumero()
        {
            Clear();
            WriteLine(MensagemDeErro());
            WriteLine("Informe o primeiro valor: ");
            double.TryParse(ReadLine(), out double primeiroValor);

            InserirPrimeiroValor(primeiroValor);
        }
        #endregion
        #region Informando a operação
        public static void InformarOperacao()
        {
            Clear();
            WriteLine(ImprimirValoresAtuais());
            WriteLine("Informe a operação:\n" +
                      "1) Somar\n" +
                      "2) Subtrair\n" +
                      "3) Multiplicar\n" +
                      "4) Dividir");
            int.TryParse(ReadLine(), out int operacao);
            InserirOperacao(operacao);
        }
        #endregion
        #region Informando segundo número
        public static void InformarSegundoNumero()
        {
            Clear();
            WriteLine(ImprimirValoresAtuais());
            WriteLine("Informe o segundo valor: ");
            double.TryParse(ReadLine(), out double segundoValor);

            InserirSegundoValor(segundoValor);
        }
        #endregion
    }
}