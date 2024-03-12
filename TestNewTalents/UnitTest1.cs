using NewTalents;

namespace TestNewTalents
{
    public class UnitTest1
    {
        public Calculadora ConstruirCalc()
        {
            string data = "11/03/2024";
            Calculadora calculadora = new Calculadora("11/03/2024");
            return calculadora;
        }
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestarSomar(int val1, int val2, int resultado)
        {
            //Calculadora calculadora = new Calculadora();
            Calculadora calculadora = ConstruirCalc();
            int resultadoCalculadora = calculadora.Somar(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(4, 5, -1)]
        public void TestarSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calculadora = ConstruirCalc();
            int resultadoCalculadora = calculadora.Subtrair(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TestarDividir(int val1, int val2, int resultado)
        {
            Calculadora calculadora = ConstruirCalc();
            int resultadoCalculadora = calculadora.Dividir(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Theory]
        [InlineData(6, 2, 12)]
        [InlineData(5, 5, 25)]
        public void TestarMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calculadora = ConstruirCalc();
            int resultadoCalculadora = calculadora.Multiplicar(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Fact]
        public void TestarDividirPorZero()
        {
            Calculadora calculadora = ConstruirCalc();
            Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(3, 0));
        }
        [Fact]
        public void TestarHistorico()
        {
            Calculadora calculadora = ConstruirCalc();
            calculadora.Somar(1, 2);
            calculadora.Somar(2, 8);
            calculadora.Somar(3, 7);
            calculadora.Somar(4, 1);

            var lista = calculadora.Historico();

            Assert.NotEmpty(calculadora.Historico());
            Assert.Equal(3, lista.Count);

        }
    }
}