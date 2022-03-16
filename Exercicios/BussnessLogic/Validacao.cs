using static Exercicio.DataAccess.Valores;
using static Exercicio.Interface.InsercaoDados;
using static Exercicio.BussnessLogic.Operacoes;
using static Exercicio.BussnessLogic.RetornosNoConsole;

namespace Exercicio.BussnessLogic
{
    public class Validacao
    {
        #region Inserção do primeiro valor
        public static void InserirPrimeiroValor(double valor)
        {
                PrimeiroValor = valor;
                InformarOperacao();
        }
        #endregion
        #region Inserção da operação
        public static void InserirOperacao(int operacao)
        {
            if (operacao <= 0 && operacao > 4)
            {
                Mensagem = "Informe uma operação válida!";
                InformarOperacao();
            }
            if (operacao == 4 && PrimeiroValor == 0)
            {
                Mensagem = "Dividendo sendo 0, o quociente será 0.";
                InformarPrimeiroNumero();
            }
            else
                Mensagem = null;
                Operacao = operacao;

            switch (Operacao)
            {
                case 1:
                    Sinal = "+";
                    InformarSegundoNumero();
                    break;
                case 2:
                    Sinal = "-";
                    InformarSegundoNumero();
                    break;
                case 3:
                    Sinal = "*";
                    InformarSegundoNumero();
                    break;
                case 4:
                    Sinal = "/";
                    InformarSegundoNumero();
                    break;
                default:
                    Mensagem = "Informe uma operação válida!\n";
                    InformarOperacao();
                    break;
            }
        }
        #endregion
        #region Inserção do segundo valor
        public static void InserirSegundoValor(double valor)
        {
            if (valor == 0 && Operacao == 4)
            {
                Mensagem = "Impossível dividir por zero!";
                InformarSegundoNumero();
            }
            if (PrimeiroValor == 0 && Operacao == 3 || SegundoValor == 0 && Operacao == 3)
            {
                Mensagem = "Qualquer número multiplicado por 0 é igual a 0!";
                SegundoValor = valor;
                Resultado = 0;
                MostrarResultado(Resultado);
            }
            else
                Mensagem = null;
                SegundoValor = valor;

            ChamarCalculo(PrimeiroValor, SegundoValor);
        }
        #endregion
        #region Chamar o calculo passando os valores
        public static void ChamarCalculo(double primeiroValor, double segundoValor)
        {
            switch (Operacao)
            {
                case 1:
                    MostrarResultado(Resultado = Somar(primeiroValor, segundoValor));
                    break;
                case 2:
                    MostrarResultado(Resultado = Subtrair(primeiroValor, segundoValor));
                    break;
                case 3:
                    MostrarResultado(Resultado = Multiplicar(primeiroValor, segundoValor));
                    break;
                case 4:
                    MostrarResultado(Resultado = Dividir(primeiroValor, segundoValor));
                    break;
            }
        }
        #endregion
    }
}
