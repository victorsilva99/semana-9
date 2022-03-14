using System;
using static System.Console;

using static Exercicios.Calculadora.Valores;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Escolha o Exercicio: ");
            WriteLine("1) Calculadora");
            Int32.TryParse(ReadLine(), out int escolha);

            switch (escolha)
            {
                case 1:
                    Inicio();
                    break;
            }
        }
    }
}