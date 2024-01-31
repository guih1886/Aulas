using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;
using Alura.Adopet.Console.Servicos.Arquivos;
using Alura.Adopet.Console.Servicos.Http;
using Alura.Adopet.Console.Servicos.Mail;
using Alura.Adopet.Console.Settings;

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
            var httpClientPet = new PetService(new HttpClientFactory(Configurations.ApiSetting.Uri).CreateClient());
            ILeitorDeArquivos<Pet>? leitorDeArquivos = LeitorDeArquivosFactory.CreatePetFrom(args[1]);
            if (leitorDeArquivos is null) return null;
            var import = new Import(httpClientPet, leitorDeArquivos);
            import.DepoisDaExecucao += EnvioDeEmail.Disparar;
            return import;
        }
    }
}
