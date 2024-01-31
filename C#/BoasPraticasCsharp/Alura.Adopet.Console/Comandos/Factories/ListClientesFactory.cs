using Alura.Adopet.Console.Servicos.Http;
using Alura.Adopet.Console.Settings;

namespace Alura.Adopet.Console.Comandos.Factories
{
    public class ListClientesFactory : IComandoFactory
    {
        public bool ConsegueCriarOTipo(Type? tipoComando)
        {
            return tipoComando?.IsAssignableTo(typeof(ListClientes)) ?? false;
        }

        public IComando? CriarComando(string[] args)
        {
            var clienteService = new ClienteService(new HttpClientFactory(Configurations.ApiSetting.Uri).CreateClient());
            return new ListClientes(clienteService);
        }
    }
}
