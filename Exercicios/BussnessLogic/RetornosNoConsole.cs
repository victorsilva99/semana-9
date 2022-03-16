using System;
using static System.Console;
using static Exercicio.DataAccess.Valores;

using static Exercicio.Interface.InsercaoDados;

namespace Exercicio.BussnessLogic
{
    class RetornosNoConsole
    {
        #region Mensagem inicial
        public static string MensagemInicial()
        {
            return "--------------------------------------------------------\n" +
                      "|                 CALCULAR DOIS VALORES                 |\n" +
                      "--------------------------------------------------------\n" +
                      "| Informe dois valores e qual operação deseja realizar, |\n" +
                      "| no final você poderá reutilizar o resultado para      |\n" +
                      "| realizar outra conta.                                 |\n" +
                      "--------------------------------------------------------\n";
        }
        #endregion
        #region Valores atuais
        public static string ImprimirValoresAtuais()
        {
            return "-------------------------------\n\n" +
                  $"{PrimeiroValor} {Sinal} \n" +
                  $"{Mensagem}\n\n" +
                   "--------------------------------";
        }
        #endregion
        #region Resultado
        public static string ImprimirValoresEResultado()
        {
            return "-------------------------------\n\n" +
                  $"{PrimeiroValor} {Sinal} {SegundoValor} = {Resultado}\n" +
                  $"{Mensagem}\n" +
                   "--------------------------------";
        }
        #endregion
        #region Retornar mensagem de erro
        public static string MensagemDeErro()
        {
            return Mensagem;
        }
        #endregion
        #region Finalização da operação
        public static void MostrarResultado(double resultado)
        {
            Clear();
            WriteLine(ImprimirValoresEResultado());
            WriteLine("Deseja fazer outra conta? (S/N)");
            string continuar = ReadLine().ToUpper();
            if (continuar == "S")
            {
                WriteLine("Deseja usar o resultado da conta anterior: (S/N)");
                string usarResultadoAnterior = ReadLine().ToUpper();
                if (usarResultadoAnterior == "S")
                    ContinuarConta(resultado);
                else
                    InformarPrimeiroNumero();
            }
            else
                WriteLine("Até logo!");
        }
        #endregion
        #region Continuar conta usando resultado anterior
        public static void ContinuarConta(double resultado)
        {
            Clear();
            PrimeiroValor = resultado;
            SegundoValor = 0;
            Mensagem = null;
            Sinal = null;
            InformarOperacao();
        }
        #endregion
    }
}