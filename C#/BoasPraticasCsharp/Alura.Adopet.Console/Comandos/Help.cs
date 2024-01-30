using Alura.Adopet.Console.Results;
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
        public string? Comando { get; }

        public Help(string comando)
        {
            docs = DocumentacaoDoSistema.ToDictionary(Assembly.GetExecutingAssembly());
            Comando = comando;
        }

        public Task<Result> ExecutarAsync()
        {
            var resultado = GerarDocumentacao();
            return Task.FromResult(Result.Ok().WithSuccess(new SucessWithDocs(resultado)));
        }

        private IEnumerable<string> GerarDocumentacao()
        {
            List<string> resultado = new List<string>();
            // se não passou mais nenhum argumento mostra help de todos os comandos
            if (Comando == null)
            {
                foreach (var doc in docs.Values)
                {
                    resultado.Add(doc.Documentacao);
                }
            }
            // exibe o help daquele comando específico
            else
            {
                if (docs.ContainsKey(Comando))
                {
                    var comando = docs[Comando];
                    resultado.Add(comando.Documentacao);
                }
                else
                {
                    resultado.Add("Comando não encontrado.");
                    throw new ArgumentException("Comando não encontrado.");
                }
            }
            return resultado;
        }
    }
}
