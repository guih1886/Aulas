using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos;
using Alura.Adopet.Testes.Builder;
using Xunit;

namespace Alura.Adopet.Testes
{
    public class ImportIntegrationTest
    {
        [Fact]
        public async void QuandoApiEstaNoArDeveRetornarUmaListaDePet()
        {
            //Arrange
            var listaDePet = new List<Pet>();
            var leitorDeArquivo = LeitorDeArquivosMockBuilder.CriaMock(listaDePet);

            var httpClientPet = new HttpClientPet(new HttpClientFactory().CreateClient());
            var import = new Import(httpClientPet, leitorDeArquivo.Object);

            string[] args = { "import", "lista.csv" };
            //Act
            await import.ExecutarAsync();
            //Assert
            var listaPet = await httpClientPet.ListPetsAsync();
            Assert.NotNull(listaPet);
            Assert.NotEmpty(listaPet);
        }
    }
}
