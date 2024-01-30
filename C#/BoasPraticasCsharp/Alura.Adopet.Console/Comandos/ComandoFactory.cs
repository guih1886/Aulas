using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;
using Alura.Adopet.Console.Servicos.Arquivos;
using Alura.Adopet.Console.Servicos.Http;
using System.Runtime.CompilerServices;

namespace Alura.Adopet.Console.Comandos
{
    public static class ComandoFactory
    {
        private static string? Comando { get; set; }
        private static string? CaminhoDoArquivo { get; set; }
        public static IComando? CriarComando(string[]? args)
        {
            if (args is null || args.Length == 0)
            {
                return null;
            }
            if (args.Length == 1)
            {
                Comando = args[0];
            }
            else
            {
                Comando = args[0];
                CaminhoDoArquivo = args[1];
            }
            switch (Comando)
            {
                case "import":
                    var httpClientPet = new PetService(new HttpClientFactory().CreateClient());
                    ILeitorDeArquivos<Pet>? leitorDeArquivos = LeitorDeArquivosFactory.CreatePetFrom(CaminhoDoArquivo!);
                    if (leitorDeArquivos is null) return null;
                    return new Import(httpClientPet, leitorDeArquivos);
                case "import-clientes":
                    var httpClientCliente = new ClienteService(new HttpClientFactory().CreateClient());
                    var leitorDeArq = LeitorDeArquivosFactory.CreateClienteFrom(CaminhoDoArquivo!);
                    if (leitorDeArq is null) return null;
                    return new ImportClientes(httpClientCliente, leitorDeArq);
                case "list":
                    var httpClientPetList = new PetService(new HttpClientFactory().CreateClient());
                    return new List(httpClientPetList);
                case "show":
                    ILeitorDeArquivos<Pet>? leitorDeArquivosShow = LeitorDeArquivosFactory.CreatePetFrom(CaminhoDoArquivo!);
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