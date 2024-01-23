using Alura.Adopet.Console.Util;

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

        public Task ExecutarAsync(string[] args)
        {
            this.MostrarPetsASerImportado(caminhoDoArquivoASerExibido: args[1]);
            return Task.CompletedTask;
        }

        private void MostrarPetsASerImportado(string caminhoDoArquivoASerExibido)
        {
            var listaDePets = leitor.RealizaLeitura();
            foreach (var item in listaDePets)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
