using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;

namespace Alura_Estacionamento_Testes;

public class VeiculoTeste
{
    [Fact(DisplayName = "Teste 1")]
    public void TestaVeiculoAcelerar()
    {
        //Arrange
        var veiculo = new Veiculo();
        //Act
        veiculo.Acelerar(10);
        //Assert
        Assert.Equal(100, veiculo.VelocidadeAtual);
    }

    [Fact]
    public void TestaVeiculoFrear()
    {
        var veiculo = new Veiculo();
        veiculo.Frear(10);
        Assert.Equal(-150, veiculo.VelocidadeAtual);
    }

    [Fact]
    public void TestaTipoVeiculo()
    {
        var veiculo = new Veiculo();
        Assert.Equal(TipoVeiculo.Automovel, veiculo.Tipo);
    }

    [Fact(Skip = "Teste ainda não implementado")]
    public void ValidaNomeProprietario()
    {

    }
}