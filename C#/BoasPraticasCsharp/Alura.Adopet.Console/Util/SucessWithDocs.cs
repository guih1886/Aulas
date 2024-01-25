using FluentResults;

namespace Alura.Adopet.Console.Util
{
    public class SucessWithDocs : Success
    {
        public IEnumerable<string> Documentacao { get; }

        public SucessWithDocs(IEnumerable<string> documentacao)
        {
            Documentacao = documentacao;
        }
    }
}