using System;
using static System.Console;
using static Exercicios.Calculadora.Escolhas;

namespace Exercicios.Calculadora
{
    class Valores
    {
        public static int Resultado;
        public static int PrimeiroValor;
        public static int SegundoValor;
        public static string Operacao;
        public static int Escolha;

        public static void Inicio()
        {
            Clear();
            WriteLine("------------------------------");
            WriteLine("Informe o primeiro valor: ");
            Int32.TryParse(ReadLine(), out int valor1);

            WriteLine("Informe o segundo valor: ");
            Int32.TryParse(ReadLine(), out int valor2);

            PrimeiroValor = valor1;
            SegundoValor = valor2;

            Opcao();
        }
        public static void ImprimirResultado()
        {
            Clear();
            WriteLine("------------------------------");
            WriteLine($"Resultado da {Operacao}: {Resultado}");
            WriteLine("Deseja fazer outra conta? (S/N)");
            string continuar = ReadLine().ToUpper();

            if (continuar == "S")
            {
                WriteLine("Deseja usar o resultado da conta anterior: (S/N)");
                string resultadoAnterior = ReadLine().ToUpper();
                if (resultadoAnterior == "S")
                    ContinuarConta();
                else
                    Inicio();
            }
            else
                WriteLine("Até logo!");
        }
    }
}
