using Alura.Adopet.Console.Servicos.Abstracoes;
using Moq;

namespace Alura.Adopet.Testes.Builder
{
    public static class LeitorDeArquivosMockBuilder
    {
        public static Mock<ILeitorDeArquivos<T>> CriaMock<T>(List<T> pets)
        {
            var leitorDeArquivo = new Mock<ILeitorDeArquivos<T>>(MockBehavior.Default);
            leitorDeArquivo.Setup(_ => _.RealizaLeitura()).Returns(pets);
            return leitorDeArquivo;
        }
    }
}