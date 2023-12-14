using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;

namespace Alura.Estacionamento.Testes
{
    public class PatioTestes
    {
        [Fact]
        public void ValidaFaturamento()
        {
            //Arrange
            var patio = new Patio();
            var veiculo = new Veiculo
            {
                Proprietario = "Beto",
                Tipo = TipoVeiculo.Automovel,
                Cor = "verde",
                Modelo = "Civic",
                Placa = "acd-9999"
            };

            patio.RegistrarEntradaVeiculo(veiculo);
            patio.RegistrarSaidaVeiculo(veiculo.Placa);

            //Act
            double faturamento = patio.TotalFaturado();

            //Assert
            Assert.Equal(2, faturamento);
        }

        [Theory]
        [InlineData("Andre silva", "asd-4585", "preto", "gol")]
        [InlineData("jose silva", "pol-9542", "cinza", "fusca")]
        [InlineData("maria silva", "gdr-6524", "azul", "opala")]
        public void ValidaFaturamentoComVariosVeiculos(string proprietario, string placa, string cor, string modelo)
        {
            //Arrange
            var patio = new Patio();
            var veiculo = new Veiculo
            {
                Proprietario = proprietario,
                Cor = cor,
                Modelo = modelo,
                Placa = placa
            };

            patio.RegistrarEntradaVeiculo(veiculo);
            patio.RegistrarSaidaVeiculo(veiculo.Placa);

            //Act
            double faturamento = patio.TotalFaturado();

            //Assert
            Assert.Equal(2, faturamento);
        }
    }
}
