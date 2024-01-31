using Alura.Adopet.Console.Servicos.Http;

namespace Alura.Adopet.Console.Comandos.Factories
{
    public class ListFactory : IComandoFactory
    {
        public bool ConsegueCriarOTipo(Type? tipoComando)
        {
            return tipoComando?.IsAssignableTo(typeof(List)) ?? false;
        }

        public IComando? CriarComando(string[] args)
        {
            var httpClientPetList = new PetService(new HttpClientFactory().CreateClient());
            return new List(httpClientPetList);
        }
    }
}
