using Alura.Adopet.Console.Comandos;
using System.Reflection;
using Xunit;

namespace Alura.Adopet.Testes.Util
{
    public class GeraDocumentacaoTest
    {
        [Fact]
        public void QuandoExistemComandosDeveRetornarDicionarioNaoVazio()
        {
            //Arrange
            var assemblyComODocComando = Assembly.GetAssembly(typeof(DocComando));
            //Act
            Dictionary<string, DocComando> dicionario = DocumentacaoDoSistema.ToDictionary(assemblyComODocComando!);
            //Assert
            Assert.NotNull(dicionario);
            Assert.NotEmpty(dicionario);
            Assert.Equal(5, dicionario.Count);
        }
    }
}
