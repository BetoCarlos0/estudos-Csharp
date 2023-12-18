using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using Xunit.Abstractions;

namespace Alura.Estacionamento.Testes
{
    public class VeiculoTestes : IDisposable
    {
        private Veiculo veiculo;
        private ITestOutputHelper _saidaConsoleTeste;

        public VeiculoTestes(ITestOutputHelper saidaConsoleTeste)
        {
            veiculo = new Veiculo();

            _saidaConsoleTeste = saidaConsoleTeste;
            _saidaConsoleTeste.WriteLine("Construtor invocado");
        }

        [Fact]
        public void TestaVeiculoAcelerarComParametro10()
        {
            //Arrange
            //var veiculo = new Veiculo();
            
            //Act
            veiculo.Acelerar(10);
            
            //Assert
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestaVeiculoFrearComParametro10()
        {
            //Arrange
            //var veiculo = new Veiculo();

            //Act
            veiculo.Frear(10);

            //Assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void FichaDeInformacaoDoVeiculo()
        {
            //Arrange
            veiculo.Proprietario = "jose silva";
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Cor = "preto";
            veiculo.Placa = "zxc-4565";
            veiculo.Modelo = "Variantre";

            //Act
            string dados = veiculo.ToString();

            //Assert
            Assert.Contains("Ficha do Veículo:", dados);
        }

        [Fact]
        public void TestaNomeProprietarioVeiculoComMenosDeTresCaracteres()
        {
            //Arrange
            string nomeProprietario = "ab";

            //Assert
            Assert.Throws<FormatException>(
                //Act
                () => new Veiculo(nomeProprietario));
        }

        [Fact]
        public void TestaMensagemDeExceptionDoQuartoCaractereDaPlaca()
        {
            //Arrange
            string placa = "asdf8888";

            //Act
            var mensagem = Assert.Throws<FormatException>(
                () => new Veiculo().Placa = placa);

            //Assert
            Assert.Equal("O 4° caractere deve ser um hífen", mensagem.Message);
        }

        [Fact(Skip = "teste ainda não implementado")]
        public void ValidaNomeProprietarioDoVeiculo()
        {

        }

        public void Dispose()
        {
            _saidaConsoleTeste.WriteLine("IDispose invocado");
        }
    }
}