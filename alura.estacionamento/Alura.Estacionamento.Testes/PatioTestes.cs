using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;

namespace Alura.Estacionamento.Testes
{
    public class PatioTestes
    {
        [Fact]
        public void ValidaFaturamentoDoEstacionamentoComUmVeuclo()
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
        public void ValidaFaturamentoDoEstacionamentoComVariosVeiculos(string proprietario, string placa, string cor, string modelo)
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

        [Theory]
        [InlineData("Andre silva", "asd-4585", "preto", "gol")]
        public void LocalizaVeiculoNoPatioComBaseNaPlaca(string proprietario, string placa, string cor, string modelo)
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

            //Act
            var consultado = patio.PesquisaVeiculo(placa);

            //Assert
            Assert.Equal(placa, consultado.Placa);
        }

        [Fact]
        public void AlterarDadosVeiculoDoProprioVeiculo()
        {
            //Arrange
            var patio = new Patio();
            var veiculo = new Veiculo
            {
                Proprietario = "jose silva",
                Cor = "verde",
                Modelo = "opala",
                Placa = "zxc-4565"
            };

            patio.RegistrarEntradaVeiculo(veiculo);

            var veiculoAlterado = new Veiculo
            {
                Proprietario = "jose silva",
                Cor = "preto",
                Modelo = "opala",
                Placa = "zxc-4565"
            };

            //Act
            var alterado = patio.AlterarDadosVeiculo(veiculoAlterado);

            //Assert
            Assert.Equal(alterado.Cor, veiculoAlterado.Cor);
        }
    }
}
