using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Results;
using Alura.Adopet.Console.Servicos.Http;
using Alura.Adopet.Testes.Builder;
using Moq;
using Moq.Protected;
using System.Net.Sockets;
using Xunit;

namespace Alura.Adopet.Testes.Comandos
{
    public class ListTest
    {
        [Fact]
        public async Task ListaPetsDeveRetornarUmaListaNaoVazia()
        {
            //Arrange
            List<Pet> listaDePet = new List<Pet>();
            Pet pet = new Pet(new Guid(), "Adolfo", TipoPet.Gato);
            listaDePet.Add(pet);
            var httpClientMoq = ApiServiceMockBuilder.GetMockList(listaDePet);

            //Act
            var retorno = await new List(httpClientMoq.Object).ExecutarAsync();

            //Assert
            var resultado = (SucessWithPets)retorno.Successes[0];
            Assert.Single(resultado.Data);
        }

        [Fact]
        public async Task QuandoApiForaDeveRetornarExcecao()
        {
            //Arrange
            var handlerMock = new Mock<HttpMessageHandler>();
            handlerMock.Protected().Setup<Task<HttpResponseMessage>>("SendAsync",
                ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>())
                .ThrowsAsync(new SocketException());
            var httpClientMoq = new Mock<HttpClient>(MockBehavior.Default);
            var clientePet = new PetService(httpClientMoq.Object);
            //Act
            //Assert
            await Assert.ThrowsAnyAsync<Exception>(() => clientePet.ListAsync());
        }
    }
}