using Alura.Adopet.Console.Servicos;
using Alura.Adopet.Console.Servicos.Abstracoes;
using Alura.Adopet.Console.Servicos.Arquivos;

namespace Alura.Adopet.Console.Comandos
{
    public static class ComandoFactory
    {
        public static IComando? CriarComando(string[] args)
        {
            if (args is null || args.Length == 0)
            {
                return null;
            }
            var comando = args[0];
            var caminhoDoArquivo = args[1];
            switch (comando)
            {
                case "import":
                    var httpClientPet = new HttpClientPet(new HttpClientFactory().CreateClient());
                    ILeitorDeArquivos? leitorDeArquivos = LeitorDeArquivosFactory.CreatePetFrom(caminhoDoArquivo);
                    if (leitorDeArquivos is null) return null;
                    return new Import(httpClientPet, leitorDeArquivos);
                case "list":
                    var httpClientPetList = new HttpClientPet(new HttpClientFactory().CreateClient());
                    return new List(httpClientPetList);
                case "show":
                    ILeitorDeArquivos? leitorDeArquivosShow = LeitorDeArquivosFactory.CreatePetFrom(caminhoDoArquivo);
                    if (leitorDeArquivosShow is null) return null;
                    return new Show(leitorDeArquivosShow);
                case "help":
                    string? comandoASerExibido = args.Length == 2 ? args[1] : null;
                    return new Help(comandoASerExibido!);
                default: return null;
            }
        }
    }
}