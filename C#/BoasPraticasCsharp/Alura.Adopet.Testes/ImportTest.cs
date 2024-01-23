using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos;
using Alura.Adopet.Console.Util;
using Alura.Adopet.Testes.Builder;
using Moq;
using Xunit;

namespace Alura.Adopet.Testes
{
    public class ImportTest
    {
        [Fact]
        public async void DadaListaVaziaNaoDeveChamarCreatePetAsync()
        {
            //Arrange
            var listaDePet = new List<Pet>();
            var leitorDeArquivo = LeitorDeArquivosMockBuilder.CriaMock(listaDePet);

            var httpClientPet = new Mock<HttpClientPet>(MockBehavior.Default, It.IsAny<HttpClient>());
            var import = new Import(httpClientPet.Object, leitorDeArquivo.Object);
            string[] args = { "import", "lista.csv" };
            //Act
            await import.ExecutarAsync(args: args);

            //Assert
            httpClientPet.Verify(_ => _.CreatePetAsync(It.IsAny<Pet>()), Times.Never());
        }

        [Fact]
        public async void DadoCaminhoDoArquivoInexistenteDeveLancarErro()
        {
            //Arrange
            List<Pet> listaPet = new();
            var leitor = LeitorDeArquivosMockBuilder.CriaMock(listaPet);
            leitor.Setup(_ => _.RealizaLeitura()).Throws<FileNotFoundException>();

            var httpClientPet = HttpClientPetMockBuilder.GetMock();
            string[] args = { "import", "lista.csv" };

            var import = new Import(httpClientPet.Object, leitor.Object);

            //Act + Assert
            await Assert.ThrowsAnyAsync<Exception>(() => import.ExecutarAsync(args));
        }
    }
}
