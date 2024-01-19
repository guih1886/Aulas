using Alura.Adopet.Console.Util;

namespace Alura.Adopet.Console.Comandos
{
    [DocComando(instrucao: "show",
                documentacao: "adopet show < arquivo > comando que exibe no terminal o conteúdo do arquivo importado.")]
    public class Show : IComando
    {
        public Task ExecutarAsync(string[] args)
        {
            this.MostrarPetsASerImportado(caminhoDoArquivoASerExibido: args[1]);
            return Task.CompletedTask;
        }

        private void MostrarPetsASerImportado(string caminhoDoArquivoASerExibido)
        {
            LeitorDeArquivo leitor = new LeitorDeArquivo();
            var listaDePets = leitor.RealizaLeitura(caminhoDoArquivoASerExibido);
            foreach (var item in listaDePets)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
