using Alura.Adopet.Console.Servicos.Abstracoes;

namespace Alura.Adopet.Console.Servicos
{
    public static class LeitorDeArquivosFactory
    {
        public static ILeitorDeArquivos? CreatePetFrom(string caminhoArquivo)
        {
            var extensaoDoArquivo = Path.GetExtension(caminhoArquivo);
            switch (extensaoDoArquivo)
            {
                case ".csv":
                    return new LeitorDeArquivoCsv(caminhoArquivo);
                    break;
                case ".json":
                    return new LeitorDeArquivosJson(caminhoArquivo);
                    break;
                default: return null;
            }
        }
    }
}