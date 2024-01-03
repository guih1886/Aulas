using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using Xunit.Abstractions;

namespace Alura_Estacionamento_Testes;

public class VeiculoTeste : IDisposable
{
    private Veiculo veiculo;
    public ITestOutputHelper SaidaConsoleHelper;

    public VeiculoTeste(ITestOutputHelper _saidaConsoleHelper)
    {
        veiculo = new Veiculo();
        SaidaConsoleHelper = _saidaConsoleHelper;
        SaidaConsoleHelper.WriteLine("Executou construtor invocado.");
    }

    [Fact(DisplayName = "Teste Acelerar Com Parametro 10")]
    public void TestaVeiculoAcelerar()
    {
        //Arrange
        //Act
        veiculo.Acelerar(10);
        //Assert
        Assert.Equal(100, veiculo.VelocidadeAtual);
    }

    [Fact]
    public void TestaVeiculoFrear()
    {
        //var veiculo = new Veiculo();
        veiculo.Frear(10);
        Assert.Equal(-150, veiculo.VelocidadeAtual);
    }

    [Fact]
    public void TestaTipoVeiculo()
    {
        //var veiculo = new Veiculo();
        Assert.Equal(TipoVeiculo.Automovel, veiculo.Tipo);
    }

    [Fact(Skip = "Teste ainda não implementado")]
    public void ValidaNomeProprietario()
    {

    }

    [Fact]
    public void DadosVeiculo()
    {
        //Arrange
        //Veiculo carro = new Veiculo();
        veiculo.Proprietario = "Guilherme Henrique";
        veiculo.Modelo = "Cruze";
        veiculo.Cor = "Branco";
        veiculo.Tipo = TipoVeiculo.Automovel;

        //Act
        string dados = veiculo.ToString();

        //Assert
        Assert.Contains("Tipo do Veiculo: Automovel", dados);
    }

    public void Dispose()
    {
        SaidaConsoleHelper.WriteLine("Execução do Cleanup: Limpando os objetos.");
    }
}