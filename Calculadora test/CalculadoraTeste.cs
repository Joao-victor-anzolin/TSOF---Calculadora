using Teste01;

namespace Calculadora_test
{
    public class CalculadoraTeste
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(4, Teste01.Calculadora.Somar(2, 2));
            Assert.Equal(1, Teste01.Calculadora.Subtrair(2, 1));
            Assert.Equal(1, Teste01.Calculadora.Dividir(2, 2));
            Assert.Equal(4, Teste01.Calculadora.Multiplicar(2, 2));
        }
    }
}