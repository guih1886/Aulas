using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;

namespace Alura_Estacionamento_Testes;

public class PatioTeste
{
    [Fact]
    public void ValidaFaturamento()
    {
        //Arrange
        Patio estacionamento = new Patio();
        Veiculo veiculo = new Veiculo();
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
        Patio estacionamento = new Patio();
        Veiculo veiculo = new Veiculo();
        veiculo.Proprietario = proprietario;
        veiculo.Tipo = TipoVeiculo.Automovel;
        veiculo.Cor = cor;
        veiculo.Modelo = modelo;
        veiculo.Placa = placa;
        estacionamento.Veiculos.Add(veiculo);
        estacionamento.RegistrarEntradaVeiculo(veiculo);
        estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);
        //Act
        double faturamento = estacionamento.TotalFaturado();
        //Assert
        Assert.Equal(2, faturamento);
    }
}
