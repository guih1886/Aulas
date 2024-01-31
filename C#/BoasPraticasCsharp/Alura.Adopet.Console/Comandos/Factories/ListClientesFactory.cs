using Alura.Adopet.Console.Servicos.Http;

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
            var clienteService = new ClienteService(new HttpClientFactory().CreateClient());
            return new ListClientes(clienteService);
        }
    }
}
