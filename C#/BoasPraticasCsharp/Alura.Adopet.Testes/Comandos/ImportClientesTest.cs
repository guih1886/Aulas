using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Results;
using Alura.Adopet.Testes.Builder;
using Xunit;

namespace Alura.Adopet.Testes.Comandos
{
    public class ImportClientesTest
    {
        [Fact]
        public void QuandoClienteEstiverNoArquivoDeveSerImportado()
        {
            //Arrange
            List<Cliente> listaDeClientes = new List<Cliente>();
            var cliente = new Cliente(Guid.NewGuid(), "Josevaldo Nogueira", "josevaldo@email.com", "13265498");
            listaDeClientes.Add(cliente);
            var mockService = ApiServiceMockBuilder.GetMock<Cliente>();
            var leitor = LeitorDeArquivosMockBuilder.CriaMock(listaDeClientes);
            var import = new ImportClientes(mockService.Object, leitor.Object);
            //Act
            var resultado = import.ExecutarAsync();
            var sucesso = (SuccessWithClientes)resultado.Result.Successes[0];
            //Assert
            Assert.True(resultado.IsCompletedSuccessfully);
            Assert.Equal("Josevaldo Nogueira", sucesso.Data.First().Nome);
        }
    }
}
