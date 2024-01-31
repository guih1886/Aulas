using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;
using Alura.Adopet.Console.Servicos.Arquivos;
using Alura.Adopet.Console.Servicos.Http;

namespace Alura.Adopet.Console.Comandos.Factories
{
    public class ImportFactory : IComandoFactory
    {
        public bool ConsegueCriarOTipo(Type? tipoComando)
        {
            return tipoComando?.IsAssignableTo(typeof(Import)) ?? false;
        }

        public IComando? CriarComando(string[] args)
        {
            var httpClientPet = new PetService(new HttpClientFactory().CreateClient());
            ILeitorDeArquivos<Pet>? leitorDeArquivos = LeitorDeArquivosFactory.CreatePetFrom(args[1]);
            if (leitorDeArquivos is null) return null;
            return new Import(httpClientPet, leitorDeArquivos);
        }
    }
}
