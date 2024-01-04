using Alura.ByteBank.Dados.Repositorio;
using Alura.ByteBank.Dominio.Entidades;
using Alura.ByteBank.Dominio.Interfaces.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Alura.BytetBank.Infraestrutura.Testes;

public class ContaCorrentRepositorioTestes
{
    private readonly IContaCorrenteRepositorio _repositorio;
    public ContaCorrentRepositorioTestes()
    {
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
}
