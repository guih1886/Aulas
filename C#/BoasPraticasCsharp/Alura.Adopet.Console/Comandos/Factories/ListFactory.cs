using Alura.Adopet.Console.Servicos.Http;
using Alura.Adopet.Console.Settings;

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
            var httpClientPetList = new PetService(new HttpClientFactory(Configurations.ApiSetting.Uri).CreateClient());
            return new List(httpClientPetList);
        }
    }
}
