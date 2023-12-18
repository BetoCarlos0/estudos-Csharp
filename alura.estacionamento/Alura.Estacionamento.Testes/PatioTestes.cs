using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using Xunit.Abstractions;

namespace Alura.Estacionamento.Testes
{
    public class PatioTestes : IDisposable
    {
        private Patio patio;
        private Operador operador;
        private ITestOutputHelper _saidaConsoleTeste;

        public PatioTestes(ITestOutputHelper saidaConsoleTeste)
        {
            patio = new Patio();
            operador = new Operador
            {
                Nome = "Pedro Fagundes"
            };
            _saidaConsoleTeste = saidaConsoleTeste;
            _saidaConsoleTeste.WriteLine("Construtor invocado");
        }

        [Fact]
        public void ValidaFaturamentoDoEstacionamentoComUmVeuclo()
        {
            //Arrange
            var veiculo = new Veiculo
            {
                Proprietario = "Beto",
                Tipo = TipoVeiculo.Automovel,
                Cor = "verde",
                Modelo = "Civic",
                Placa = "acd-9999"
            };

            patio.OperadorPatio = operador;
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
            var veiculo = new Veiculo
            {
                Proprietario = proprietario,
                Cor = cor,
                Modelo = modelo,
                Placa = placa
            };

            patio.OperadorPatio = operador;
            patio.RegistrarEntradaVeiculo(veiculo);
            patio.RegistrarSaidaVeiculo(veiculo.Placa);

            //Act
            double faturamento = patio.TotalFaturado();

            //Assert
            Assert.Equal(2, faturamento);
        }

        [Theory]
        [InlineData("André Silva", "ASD-1498", "preto", "Gol")]
        public void LocalizaVeiculoNoPatioComBaseNoTicket(string proprietario, string placa, string cor, string modelo)
        {
            //Arrange
            var veiculo = new Veiculo
            {
                Tipo = TipoVeiculo.Automovel,
                Proprietario = proprietario,
                Placa = placa,
                Cor = cor,
                Modelo = modelo
            };
            veiculo.Acelerar(10);
            veiculo.Frear(5);

            patio.OperadorPatio = operador;
            patio.RegistrarEntradaVeiculo(veiculo);

            //Act
            var consultado = patio.PesquisaVeiculoPorTicket(veiculo.IdTicket);

            //Assert
            Assert.Equal(placa, consultado.Placa);
        }

        [Fact]
        public void AlterarDadosDoProprioVeiculo()
        {
            //Arrange
            var veiculo = new Veiculo
            {
                Proprietario = "jose silva",
                Cor = "verde",
                Modelo = "opala",
                Placa = "zxc-4565"
            };

            patio.OperadorPatio = operador;
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

        public void Dispose()
        {
            _saidaConsoleTeste.WriteLine("Dispose invocado");
        }
    }
}
