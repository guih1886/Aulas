using System.Reflection;

namespace Alura.Adopet.Console.Comandos
{
    [DocComando(instrucao: "help",
        documentacao: "adopet help <parametro> ous simplemente adopet help  " +
                      "comando que exibe informações de ajuda dos comandos.")]
    public class Help : IComando
    {
        private Dictionary<string, DocComando> docs;

        public Help()
        {
            docs = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.GetCustomAttributes<DocComando>().Any())
                .Select(t => t.GetCustomAttribute<DocComando>()!)
                .ToDictionary(d => d.Instrucao);
        }

        public Task ExecutarAsync(string[] args)
        {
            this.MostrarAjuda(args);
            return Task.CompletedTask;
        }

        private void MostrarAjuda(string[] comandosHelp)
        {
            System.Console.WriteLine("Lista de comandos.");
            // se não passou mais nenhum argumento mostra help de todos os comandos
            if (comandosHelp.Length == 1)
            {
                System.Console.WriteLine("Comando possíveis: ");
                foreach (var doc in docs.Values)
                {
                    System.Console.WriteLine(doc.Documentacao);
                }
            }
            // exibe o help daquele comando específico
            else if (comandosHelp.Length == 2)
            {
                string comandoASerExibido = comandosHelp[1];
                if (docs.ContainsKey(comandoASerExibido))
                {
                    var comando = docs[comandoASerExibido];
                    System.Console.WriteLine(comando.Documentacao);
                }

            }
        }
    }
}
