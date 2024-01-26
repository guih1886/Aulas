using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos;
using Moq;

namespace Alura.Adopet.Testes.Builder
{
    public static class LeitorDeArquivosMockBuilder
    {
        public static Mock<LeitorDeArquivoCsv> CriaMock(List<Pet> pets)
        {
            var leitorDeArquivo = new Mock<LeitorDeArquivoCsv>(MockBehavior.Default, It.IsAny<string>());
            leitorDeArquivo.Setup(_ => _.RealizaLeitura()).Returns(pets);

            return leitorDeArquivo;
        }
    }
}