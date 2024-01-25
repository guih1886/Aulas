using Alura.Adopet.Console.Comandos;
using Xunit;

namespace Alura.Adopet.Testes
{
    public class HelpTest
    {
        [Fact]
        public async Task QuandoMetodoNaoExistirDeveRetornarFalha()
        {
            //Arrange
            var comando = "comando invalido";
            //Act
            //Assert
            await Assert.ThrowsAsync<ArgumentException>(async () => await new Help(comando).ExecutarAsync());
        }

        [Theory]
        [InlineData("help")]
        [InlineData("show")]
        [InlineData("list")]
        [InlineData("import")]
        public async Task QuandoComandoExistirDeveRetornarSucesso(string comando)
        {
            //Arrange
            //Act
            var resultado = await new Help(comando).ExecutarAsync();
            //Assert
            Assert.NotNull(resultado);
            Assert.True(resultado.IsSuccess);
        }
    }
}
