using static Exercicios.Calculadora.Valores;
using static Exercicios.Calculadora.Operadores;

namespace Exercicios.Calculadora
{
    class ValidarValores
    {
        public static void DirecionarParaOperadores()
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
    }
}
