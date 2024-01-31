using Alura.Adopet.Console.Servicos.Arquivos;
using Alura.Adopet.Console.Servicos.Http;
using Alura.Adopet.Console.Settings;

namespace Alura.Adopet.Console.Comandos.Factories
{
    public class ImportClientesFactory : IComandoFactory
    {
        public bool ConsegueCriarOTipo(Type? tipoComando)
        {
            return tipoComando?.IsAssignableTo(typeof(ImportClientes)) ?? false;
        }

        public IComando? CriarComando(string[] args)
        {
            var httpClientCliente = new ClienteService(new HttpClientFactory(Configurations.ApiSetting.Uri).CreateClient());
            var leitorDeArq = LeitorDeArquivosFactory.CreateClienteFrom(args[1]);
            if (leitorDeArq is null) return null;
            return new ImportClientes(httpClientCliente, leitorDeArq);
        }
    }
}
