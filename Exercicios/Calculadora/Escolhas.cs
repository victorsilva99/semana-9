using System;
using static System.Console;

using static Exercicios.Calculadora.Valores;
using static Exercicios.Calculadora.ValidarValores;

namespace Exercicios.Calculadora
{
    class Escolhas
    {
        public static void ImprimirOperacoesNoConsole ()
        {
            WriteLine("Informe a operação:");
            WriteLine("1) Somar");
            WriteLine("2) Subtrair");
            WriteLine("3) Multiplicar");
            WriteLine("4) Dividir");
        }

        public static void Opcao()
        {
            Clear();
            ImprimirOperacoesNoConsole();
            Int32.TryParse(ReadLine(), out int escolha);

            Escolha = escolha;
            DirecionarParaOperadores();
        }
        public static void ContinuarConta()
        {
            Clear();
            ImprimirOperacoesNoConsole();
            Int32.TryParse(ReadLine(), out int novaEscolha);

            Escolha = novaEscolha;

            Clear();
            WriteLine($"Resultado anterior: {Resultado}");
            WriteLine("Informe o segundo valor: ");
            Int32.TryParse(ReadLine(), out int novoValor2);

            PrimeiroValor = Resultado;
            SegundoValor = novoValor2;

            DirecionarParaOperadores();
        }
    }
}
