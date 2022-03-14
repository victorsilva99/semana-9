using System;
using static System.Console;

namespace Exercicios
{
    class Program
    {
        class Calculadora
        {
            static int Resultado = 0;
            static int PrimeiroValor;
            static int SegundoValor;
            static string Operacao;
            static int Escolha;

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
            public static void Opcao()
            {
                Clear();
                WriteLine("Informe a operação:");
                WriteLine("1) Somar");
                WriteLine("2) Subtrair");
                WriteLine("3) Multiplicar");
                WriteLine("4) Dividir");
                Int32.TryParse(ReadLine(), out int escolha);

                Escolha = escolha;
                PassagemValores();
            }
            public static void PassagemValores()
            {
                if (Escolha == 1)
                {
                    Operacao = "Soma";
                    Somar(PrimeiroValor, SegundoValor);
                }
                if (Escolha == 2)
                {
                    Operacao = "Subtração";
                    Subtrair(PrimeiroValor, SegundoValor);
                }
                if (Escolha == 3)
                {
                    Operacao = "Multiplicação";
                    Multiplicar(PrimeiroValor, SegundoValor);
                }
                if (Escolha == 4)
                {
                    Operacao = "Divisão";
                    Dividir(PrimeiroValor, SegundoValor);
                }
            }
            public static void Somar(int primeiroValor, int segundoValor)
            {
                Resultado = primeiroValor + segundoValor;
                ImprimirResultado();
            }
            public static void Subtrair(int primeiroValor, int segundoValor)
            {
                Resultado = primeiroValor - segundoValor;
                ImprimirResultado();
            }
            public static void Multiplicar(int primeiroValor, int segundoValor)
            {
                Resultado = primeiroValor * segundoValor;
                ImprimirResultado();
            }
            public static void Dividir(int primeiroValor, int segundoValor)
            {
                Resultado = primeiroValor / segundoValor;
                ImprimirResultado();
            }
            public static void ContinuarConta()
            {
                Clear();

                WriteLine($"Resultado anterior: {Resultado}");
                WriteLine("Qual operação deseja realizar?");
                WriteLine("1) Somar");
                WriteLine("2) Subtrair");
                WriteLine("3) Multiplicar");
                WriteLine("4) Dividir");
                Int32.TryParse(ReadLine(), out int novaEscolha);

                Escolha = novaEscolha;

                Clear();
                WriteLine($"Resultado anterior: {Resultado}");
                WriteLine("Informe o segundo valor: ");
                Int32.TryParse(ReadLine(), out int novoValor2);

                PrimeiroValor = Resultado;
                SegundoValor = novoValor2;

                PassagemValores();
            }
            public static void ImprimirResultado()
            {
                Clear();
                WriteLine("------------------------------");
                WriteLine($"Resultado da {Operacao}: {Resultado}");
                WriteLine("Deseja fazer outra conta? (S/N)");
                string continuar = ReadLine().ToUpper();

                if (continuar == "S") { 
                    WriteLine("Usando o resultado anterior: (S/N)");
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

        static void Main(string[] args)
        {
            WriteLine("Escolha o Exercicio: ");
            WriteLine("1) Calculadora");
            Int32.TryParse(ReadLine(), out int escolha);

            switch (escolha)
            {
                case 1:
                    Calculadora.Inicio();
                    break;
            }
        }
    }
}