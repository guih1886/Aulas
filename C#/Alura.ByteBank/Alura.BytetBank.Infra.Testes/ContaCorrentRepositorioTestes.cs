using Alura.ByteBank.Dados.Repositorio;
using Alura.ByteBank.Dominio.Entidades;
using Alura.ByteBank.Dominio.Interfaces.Repositorios;
using Alura.ByteBank.Infraestrutura.Testes.Servico;
using Alura.ByteBank.Infraestrutura.Testes.Servico.DTO;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Xunit;
using Xunit.Abstractions;

namespace Alura.ByteBank.Infraestrutura.Testes;

public class ContaCorrentRepositorioTestes: IDisposable
{
    public ITestOutputHelper SaidaConsoleTeste;
    private readonly IContaCorrenteRepositorio _repositorio;
    public ContaCorrentRepositorioTestes(ITestOutputHelper _saidaConsoleTeste)
    {
        SaidaConsoleTeste = _saidaConsoleTeste;
        SaidaConsoleTeste.WriteLine("Construtor invocado.");
        var servico = new ServiceCollection();
        servico.AddTransient<IContaCorrenteRepositorio, ContaCorrenteRepositorio>();
        var provedor = servico.BuildServiceProvider();
        _repositorio = provedor.GetService<IContaCorrenteRepositorio>();
    }

    [Fact]
    public void TestaObterContasNaoVazias()
    {
        //Arrange
        //Act
        List<ContaCorrente> contas = _repositorio.ObterTodos();
        //Assert
        Assert.NotEmpty(contas);
    }

    [Fact]
    public void TestaObterContaPorId()
    {
        //Act
        ContaCorrente conta = _repositorio.ObterPorId(1);
        //Assert
        Assert.NotNull(conta);
    }

    [Fact]
    public void TestaAtualizaSaldoConta()
    {
        //Arrange
        var conta = _repositorio.ObterPorId(1);
        double saldoNovo = 15;
        conta.Saldo = saldoNovo;
        //Act
        var atualizado = _repositorio.Atualizar(1, conta);
        //Assert
        Assert.True(atualizado);
    }

    [Fact]
    public void TestaInserirNovaContaBD()
    {
        //Arrange
        var conta = new ContaCorrente()
        {
            Saldo = 10,
            Identificador = Guid.NewGuid(),
            Cliente = new Cliente()
            {
                Nome = "Guilherme H",
                CPF = "866.074.210-91",
                Identificador = Guid.NewGuid(),
                Profissao = "Analista",
                Id = 1
            },
            Agencia = new Agencia()
            {
                Id = 1,
                Numero = 105,
                Nome = "Bradesco",
                Endereco = "Rua Luis Carlos Andradre",
                Identificador = Guid.NewGuid()
            }
        };
        //Act
        var retorno = _repositorio.Adicionar(conta);
        //Assert
        Assert.True(retorno);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public void TestaObterContaPorVariosId(int id)
    {
        //Act
        ContaCorrente conta = _repositorio.ObterPorId(id);
        //Assert
        Assert.NotNull(conta);
    }

    // Testes com Mock
    [Fact]
    public void TestaObterContasMock()
    {
        //Arange
        var bytebankRepositorioMock = new Mock<IByteBankRepositorio>();
        var mock = bytebankRepositorioMock.Object;

        //Act
        var lista = mock.BuscarContasCorrentes();

        //Assert - Verificando o comportamento
        bytebankRepositorioMock.Verify(b => b.BuscarContasCorrentes());
    }

    [Fact]
    public void TestaConsultaPixPorChaveMock()
    {
        //Arange
        var pixRepositorioMock = new Mock<IPixRepositorio>();
        var mock = pixRepositorioMock.Object;

        //Act
        var lista = mock.consultaPix(new Guid("a0b80d53-c0dd-4897-ab90-c0615ad80d5a"));

        //Assert - Verificando o comportamento
        pixRepositorioMock.Verify(b => b.consultaPix(new Guid("a0b80d53-c0dd-4897-ab90-c0615ad80d5a")));
    }

    [Fact]
    public void TestaConsultaTodosPixStub()
    {

        //Arange
        var guid = new Guid("a0b80d53-c0dd-4897-ab90-c0615ad80d5a");
        var pix = new PixDTO() { Chave = guid, Saldo = 10 };

        var pixRepositorioMock = new Mock<IPixRepositorio>();
        pixRepositorioMock.Setup(x => x.consultaPix(It.IsAny<Guid>())).Returns(pix);

        var mock = pixRepositorioMock.Object;

        //Act
        var saldo = mock.consultaPix(guid).Saldo;

        //Assert
        Assert.Equal(10, saldo);
    }

    public void Dispose()
    {
        SaidaConsoleTeste.WriteLine("Destrutor invocado.");
    }
}
