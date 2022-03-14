using static Exercicios.Calculadora.Valores;

namespace Exercicios.Calculadora
{
    class Operadores
    {
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
    }
}
