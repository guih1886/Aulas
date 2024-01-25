using Alura.Adopet.Console.Servicos;
using Alura.Adopet.Console.Util;

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
            switch (comando)
            {
                case "import":
                    var httpClientPet = new HttpClientPet(new HttpClientFactory().CreateClient());
                    LeitorDeArquivo? leitorDeArquivos = new LeitorDeArquivo(comando);
                    return new Import(httpClientPet, leitorDeArquivos);
                case "list":
                    var httpClientPetList = new HttpClientPet(new HttpClientFactory().CreateClient());
                    return new List(httpClientPetList);
                case "show":
                    LeitorDeArquivo? leitorDeArquivosShow = new LeitorDeArquivo(comando);
                    return new Show(leitorDeArquivosShow);
                case "help":
                    var comandoASerExibido = args.Length == 2 ? args[1] : null;
                    return new Help(comandoASerExibido);
                default: return null;
            }
        }
    }
}