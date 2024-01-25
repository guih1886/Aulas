using Alura.Adopet.Console.Servicos;
using Alura.Adopet.Console.Util;

namespace Alura.Adopet.Console.Comandos
{
    internal class ComandosDoSistema
    {
        public Dictionary<string, IComando> comandosDoSistema;

        public ComandosDoSistema(string caminhoDoArquivo)
        {
            comandosDoSistema = new Dictionary<string, IComando>
            {
                {"help", new Help() },
                {"import", new Import(clientPet: CriarInstanciaHttpPet(), new LeitorDeArquivo(caminhoDoArquivo)) },
                {"list", new List(clientPet: CriarInstanciaHttpPet()) },
                {"show", new Show(new LeitorDeArquivo(caminhoDoArquivo)) },
            };
        }

        public IComando? this[string key] => comandosDoSistema.ContainsKey(key) ? this.comandosDoSistema[key] : null;

        private static HttpClientPet CriarInstanciaHttpPet()
        {
            return new HttpClientPet(new HttpClientFactory().CreateClient());
        }
    }
}
