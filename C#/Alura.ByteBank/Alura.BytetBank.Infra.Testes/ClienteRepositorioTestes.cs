using Alura.ByteBank.Dados.Repositorio;
using Alura.ByteBank.Dominio.Entidades;
using Alura.ByteBank.Dominio.Interfaces.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Alura.ByteBank.Infraestrutura.Testes;

public class ClienteRepositorioTestes
{
    private readonly IClienteRepositorio _repositorio;
    public ClienteRepositorioTestes()
    {
        var servico = new ServiceCollection();
        servico.AddTransient<IClienteRepositorio, ClienteRepositorio>();
        var provedor = servico.BuildServiceProvider();
        _repositorio = provedor.GetService<IClienteRepositorio>();
    }

    [Fact]
    public void TestaObterTodosClientesNaoVazios()
    {
        //Arrange
        //Act
        List<Cliente> lista = _repositorio.ObterTodos();

        //Assert
        Assert.NotEmpty(lista);
    }

    [Fact]
    public void TestaObterClientePorId()
    {
        //Arrange
        //Act
        Cliente cliente = _repositorio.ObterPorId(1);
        //Assert
        Assert.NotNull(cliente);
        Assert.Equal("Guilherme H", cliente.Nome);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void TestaObterClientePorVariosId(int id)
    {
        //Arrange
        //Act
        Cliente cliente = _repositorio.ObterPorId(id);
        //Assert
        Assert.NotNull(cliente);
    }
}
