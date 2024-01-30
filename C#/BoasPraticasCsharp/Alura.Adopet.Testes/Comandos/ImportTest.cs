using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Results;
using Alura.Adopet.Console.Servicos.Http;
using Alura.Adopet.Testes.Builder;
using Moq;
using Xunit;

namespace Alura.Adopet.Testes.Comandos
{
    public class ImportTest
    {
        [Fact]
        public async void DadaListaVaziaNaoDeveChamarCreatePetAsync()
        {
            //Arrange
            var listaDePet = new List<Pet>();
            var leitorDeArquivo = LeitorDeArquivosMockBuilder.CriaMock(listaDePet);

            var httpClientPet = new Mock<PetService>(MockBehavior.Default, It.IsAny<HttpClient>());
            var import = new Import(httpClientPet.Object, leitorDeArquivo.Object);
            string[] args = { "import", "lista.csv" };
            //Act
            await import.ExecutarAsync();

            //Assert
            httpClientPet.Verify(_ => _.CreateAsync(It.IsAny<Pet>()), Times.Never());
        }

        [Fact]
        public void DadoCaminhoDoArquivoInexistenteDeveLancarErro()
        {
            //Arrange
            List<Pet> listaPet = new();
            var leitor = LeitorDeArquivosMockBuilder.CriaMock(listaPet);
            leitor.Setup(_ => _.RealizaLeitura()).Throws<FileNotFoundException>();

            var httpClientPet = ApiServiceMockBuilder.GetMock();
            string[] args = { "import", "lista.csv" };

            var import = new Import(httpClientPet.Object, leitor.Object);

            //Act
            var resultado = import.ExecutarAsync();

            //Assert
            Assert.False(resultado.IsFaulted);
        }

        [Fact]
        public void QuandoPetEstiverNoArquivoDeveSerImportado()
        {
            //Arrange
            List<Pet> listaPet = new List<Pet>();
            var pet = new Pet(new Guid(), "Adalberto", TipoPet.Cachorro);
            listaPet.Add(pet);

            var leitorArquivo = LeitorDeArquivosMockBuilder.CriaMock(listaPet);
            var httpClientPet = ApiServiceMockBuilder.GetMock();

            var import = new Import(clientPet: httpClientPet.Object, leitor: leitorArquivo.Object);
            string[] args = { "import", "lista.csv" };
            //Act
            var resultado = import.ExecutarAsync();
            //Assert
            Assert.True(resultado.IsCompletedSuccessfully);
            var sucesso = (SucessWithPets)resultado.Result.Successes[0];
            Assert.Equal("Adalberto", sucesso.Data.First().Nome);
        }
    }
}
