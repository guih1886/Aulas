using Alura.Adopet.Console.UI;
using Alura.Adopet.Console.Util;
using FluentResults;

namespace Alura.Adopet.Console.Comandos
{
    [DocComando(instrucao: "show",
                documentacao: "adopet show < arquivo > comando que exibe no terminal o conteúdo do arquivo importado.")]
    public class Show : IComando
    {
        private readonly LeitorDeArquivo leitor;

        public Show(LeitorDeArquivo leitor)
        {
            this.leitor = leitor;
        }

        public Task<Result> ExecutarAsync(string[] args)
        {
            return MostrarPetsASerImportado(caminhoDoArquivoASerExibido: args[1]);
        }

        private Task<Result> MostrarPetsASerImportado(string caminhoDoArquivoASerExibido)
        {
            var listaDePets = leitor.RealizaLeitura();
            return Task.FromResult(Result.Ok().WithSuccess(new SucessWithPets(listaDePets, "Leitura realizada com sucesso.")));
        }
    }
}
