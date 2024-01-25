using Alura.Adopet.Console.Util;
using Alura.Adopet.Testes;
using FluentResults;
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
            docs = DocumentacaoDoSistema.ToDictionary(Assembly.GetExecutingAssembly());
        }

        public Task<Result> ExecutarAsync(string[] args)
        {
            var resultado = GerarDocumentacao(args);
            return Task.FromResult(Result.Ok().WithSuccess(new SucessWithDocs(resultado)));
        }

        private IEnumerable<string> GerarDocumentacao(string[] comandosHelp)
        {
            List<string> resultado = new List<string>();
            // se não passou mais nenhum argumento mostra help de todos os comandos
            if (comandosHelp == null)
            {
                foreach (var doc in docs.Values)
                {
                    resultado.Add(doc.Documentacao);
                }
            }
            if (comandosHelp.Length == 1)
            {
                foreach (var doc in docs.Values)
                {
                    resultado.Add(doc.Documentacao);
                }
            }
            // exibe o help daquele comando específico
            else if (comandosHelp.Length == 2)
            {
                string comandoASerExibido = comandosHelp[1];
                if (docs.ContainsKey(comandoASerExibido))
                {
                    var comando = docs[comandoASerExibido];
                    resultado.Add(comando.Documentacao);
                }
                else
                {
                    resultado.Add("Comando não encontrado.");
                }

            }
            return resultado;
        }
    }
}
