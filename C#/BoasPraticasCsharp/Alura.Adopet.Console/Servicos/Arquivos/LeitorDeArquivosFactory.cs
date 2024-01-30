using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;

namespace Alura.Adopet.Console.Servicos.Arquivos
{
    public static class LeitorDeArquivosFactory
    {
        public static ILeitorDeArquivos<Pet>? CreatePetFrom(string caminhoArquivo)
        {
            var extensaoDoArquivo = Path.GetExtension(caminhoArquivo);
            switch (extensaoDoArquivo)
            {
                case ".csv":
                    return new PetDoCsv(caminhoArquivo);
                case ".json":
                    return new LeitorDeArquivosJson<Pet>(caminhoArquivo);
                default: return null;
            }
        }
        public static ILeitorDeArquivos<Cliente>? CreateClienteFrom(string caminhoArquivo)
        {
            var extensaoDoArquivo = Path.GetExtension(caminhoArquivo);
            switch (extensaoDoArquivo)
            {
                case ".csv":
                    return new ClientesDoCsv(caminhoArquivo);
                case ".json":
                    return new LeitorDeArquivosJson<Cliente>(caminhoArquivo);
                default: return null;
            }
        }
    }
}