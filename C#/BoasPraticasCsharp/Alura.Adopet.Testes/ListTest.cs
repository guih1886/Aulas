using Alura.Adopet.Console.Servicos;
using Xunit;

namespace Alura.Adopet.Testes
{
    public class ListTest
    {
        [Fact]
        public async Task ListaPetsDeveRetornarUmaListaNaoVazia()
        {
            //Arrange
            var clientePet = new HttpClientPet();
            //Act
            var lista = await clientePet.ListPetsAsync();
            //Assert
            Assert.NotNull(lista);
            Assert.NotEmpty(lista);
        }

        [Fact]
        public async Task QuandoApiForaDeveRetornarExcecao()
        {
            //Arrange
            var clientePet = new HttpClientPet("http://localhost:1111");
            //Act
            //Assert
            await Assert.ThrowsAnyAsync<Exception>(() => clientePet.ListPetsAsync());
        }
    }
}