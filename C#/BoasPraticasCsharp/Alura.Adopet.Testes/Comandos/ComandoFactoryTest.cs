using Alura.Adopet.Console.Comandos;
using Xunit;

namespace Alura.Adopet.Testes.Comandos
{
    public class ComandoFactoryTest
    {
        [Fact]
        public void DadoUmParametroDeveRetornarUmTipoImport()
        {
            //Arrange
            string[] args = { "import", "lista.csv" };
            //Act
            var comando = ComandoFactory.CriarComando(args);
            //Assert
            Assert.IsType<Import>(comando);
        }

        [Fact]
        public void DadoUmParametroInvalidoDeveRetornarNulo()
        {
            //Arrange
            string[] args = { "camarguinho", "lista.csv" };
            //Act
            var comando = ComandoFactory.CriarComando(args);
            //Assert
            Assert.Null(comando);
        }

        [Fact]
        public void DadoUmParametroNuloDeveRetornarNulo()
        {
            //Arrange
            //Act
            var comando = ComandoFactory.CriarComando(null);
            //Assert
            Assert.Null(comando);
        }

        [Fact]
        public void DadoUmParametroVazioDeveRetornarNulo()
        {
            //Arrange
            string[] args = { };
            //Act
            var comando = ComandoFactory.CriarComando(args);
            //Assert
            Assert.Null(comando);
        }

        [Fact]
        public void DadoUmParametroDeveRetornarUmTipoList()
        {
            //Arrange
            string[] args = { "list", "lista.csv" };
            //Act
            var comando = ComandoFactory.CriarComando(args);
            //Assert
            Assert.IsType<List>(comando);
        }
    }
}
