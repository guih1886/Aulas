using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Results;
using Alura.Adopet.Testes.Builder;
using Xunit;

namespace Alura.Adopet.Testes.Comandos
{
    public class ShowTest
    {
        [Fact]
        public async Task QuandoArquivoExistenteDeveRetornarMensagemDeSucesso()
        {
            //Arrange
            List<Pet> listaDePet = new List<Pet>();
            Pet pet = new Pet(new Guid(), "Adolfo", TipoPet.Gato);
            listaDePet.Add(pet);
            var leitor = LeitorDeArquivosMockBuilder.CriaMock(listaDePet);
            leitor.Setup(_ => _.RealizaLeitura());
            //Act
            var resultado = await new Show(leitor.Object).ExecutarAsync();
            var sucesso = (SucessWithPets)resultado.Successes[0];
            //Assert
            Assert.NotNull(resultado);
            Assert.Equal("Leitura realizada com sucesso.", sucesso.Mensagem);
        }
    }
}
