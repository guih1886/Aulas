using Alura.Adopet.Console.Servicos.Arquivos;
using Xunit;

namespace Alura.Adopet.Testes.Servicos
{
    public class ClientesDoJsonTest : IDisposable
    {
        private readonly string caminhoDoArquivo;

        public ClientesDoJsonTest()
        {
            string conteudo = @"
            [
              {
                ""Id"": ""68286fbf-f6f4-4924-adab-0637511813e0"",
                ""Nome"": ""Mancha"",
                ""Tipo"": 1
              },
              {
                ""Id"": ""68286fbf-f6f4-4924-adab-0637511672e0"",
                ""Nome"": ""Alvo"",
                ""Tipo"": 1
              },
              {
                ""Id"": ""68286fbf-f6f4-1234-adab-0637511672e0"",
                ""Nome"": ""Pinta"",
                ""Tipo"": 1
              }
            ]
        ";
            string nomeRandomico = $"{Guid.NewGuid()}.json";
            File.WriteAllText(nomeRandomico, conteudo);
            caminhoDoArquivo = Path.GetFullPath(nomeRandomico);
        }

        [Fact]
        public void QuandoArquivoExistenteDeveRetornarUmaListaDeClientes()
        {
            //Arrange
            //Act
            var lista = new ClientesDoJson(caminhoDoArquivo).RealizaLeitura();
            //Assert
            Assert.NotNull(lista);
            Assert.Equal(3, lista.Count());
        }

        public void Dispose()
        {
            File.Delete(caminhoDoArquivo);
        }
    }
}
