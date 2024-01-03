using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System.Numerics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using Xunit.Abstractions;

namespace Alura_Estacionamento_Testes;

public class PatioTeste : IDisposable
{
    private Veiculo veiculo;
    private Patio estacionamento;
    public ITestOutputHelper SaidaConsoleHelper;

    public PatioTeste(ITestOutputHelper _saidaConsoleHelper)
    {
        veiculo = new Veiculo();
        estacionamento = new Patio();
        SaidaConsoleHelper = _saidaConsoleHelper;
        SaidaConsoleHelper.WriteLine("Executou construtor invocado.");
    }
    [Fact]
    public void ValidaFaturamento()
    {
        //Arrange
        //Patio estacionamento = new Patio();
        //Veiculo veiculo = new Veiculo();
        veiculo.Proprietario = "Guilherme";
        veiculo.Tipo = TipoVeiculo.Automovel;
        veiculo.Cor = "Verde";
        veiculo.Modelo = "Cruze";
        veiculo.Placa = "ASD-9999";

        estacionamento.Veiculos.Add(veiculo);
        estacionamento.RegistrarEntradaVeiculo(veiculo);
        estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

        //Act
        double faturamento = estacionamento.TotalFaturado();

        //Assert
        Assert.Equal(2, faturamento);
    }

    [Theory]
    [InlineData("Guilherme", "ASD-9999", "Branco", "Cruze")]
    [InlineData("Pedro", "DSA-8888", "Preto", "Fiesta")]
    [InlineData("Maria", "EFD-3226", "Vermelho", "Ferrari")]
    public void ValidaFaturamentoVariosVeiculos(string proprietario, string placa, string cor, string modelo)
    {
        //Arrange
        //Patio estacionamento = new Patio();
        //Veiculo veiculo = new Veiculo();
        veiculo.Proprietario = proprietario;
        veiculo.Tipo = TipoVeiculo.Automovel;
        veiculo.Cor = cor;
        veiculo.Modelo = modelo;
        veiculo.Placa = placa;
        estacionamento.RegistrarEntradaVeiculo(veiculo);
        estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);
        //Act
        double faturamento = estacionamento.TotalFaturado();
        //Assert
        Assert.Equal(2, faturamento);
    }

    [Theory]
    [InlineData("Guilherme", "ASD-9999", "Branco", "Cruze")]
    public void LocalizaVeiculoNoPatio(string proprietario, string placa, string cor, string modelo)
    {
        //Arrange
        //Patio estacionamento = new Patio();
        //Veiculo veiculo = new Veiculo();
        veiculo.Proprietario = proprietario;
        veiculo.Tipo = TipoVeiculo.Automovel;
        veiculo.Cor = cor;
        veiculo.Modelo = modelo;
        veiculo.Placa = placa;
        estacionamento.RegistrarEntradaVeiculo(veiculo);

        //Act
        var consultado = estacionamento.PesquisaVeiculo(placa);

        //Assert
        Assert.Equal(placa, consultado.Placa);
    }

    [Fact]
    public void AlterarDadosVeiculo()
    {
        //Arrange
        //Patio estacionamento = new Patio();
        //Veiculo veiculo = new Veiculo();
        veiculo.Proprietario = "Pedro Felipe";
        veiculo.Tipo = TipoVeiculo.Automovel;
        veiculo.Cor = "Verde";
        veiculo.Modelo = "Opala";
        veiculo.Placa = "ZXC-8524";
        estacionamento.RegistrarEntradaVeiculo(veiculo);

        Veiculo veiculoAlterado = new Veiculo();
        veiculoAlterado.Proprietario = "Pedro Felipe";
        veiculoAlterado.Tipo = TipoVeiculo.Automovel;
        veiculoAlterado.Cor = "Vermelho"; // Alterado
        veiculoAlterado.Modelo = "Opala";
        veiculoAlterado.Placa = "ZXC-8524";

        //Act
        Veiculo alterado = estacionamento.AlteraDadosVeiculo(veiculoAlterado);

        //Assert
        Assert.Equal(alterado.Cor, veiculoAlterado.Cor);
    }

    public void Dispose()
    {
        SaidaConsoleHelper.WriteLine("Execução do Cleanup: Limpando os objetos.");
    }
}
