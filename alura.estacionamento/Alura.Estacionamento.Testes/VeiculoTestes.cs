using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;

namespace Alura.Estacionamento.Testes
{
    public class VeiculoTestes
    {
        private Veiculo veiculo;

        public VeiculoTestes()
        {
            veiculo = new Veiculo();
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

        [Fact(Skip = "teste ainda não implementado")]
        public void ValidaNomeProprietarioDoVeiculo()
        {

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
    }
}