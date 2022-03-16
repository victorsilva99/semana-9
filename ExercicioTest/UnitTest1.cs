using Xunit;

namespace ExercicioTest
{
    public class ExercicioTest
    {
        [Fact]
        public void SomarDoisNumerosComSucesso()
        {
            Assert.Equal(10, Exercicio.BussnessLogic.Operacoes.Somar(5, 5));
        }
        [Fact]
        public void SubtrairDoisNumerosComSucesso()
        {
            Assert.Equal(0, Exercicio.BussnessLogic.Operacoes.Subtrair(5, 5));
        }
        [Fact]
        public void MultiplicarDoisNumerosComSucesso()
        {
            Assert.Equal(25, Exercicio.BussnessLogic.Operacoes.Multiplicar(5, 5));
        }
        [Fact]
        public void DividirDoisNumerosComSucesso()
        {
            Assert.Equal(1, Exercicio.BussnessLogic.Operacoes.Dividir(5, 5));
        }
    }
}
