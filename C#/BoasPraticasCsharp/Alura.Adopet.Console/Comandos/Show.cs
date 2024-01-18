namespace Alura.Adopet.Console.Comandos
{
    [DocComando(instrucao: "show",
                documentacao: "adopet show < arquivo > comando que exibe no terminal o conteúdo do arquivo importado.")]
    public class Show
    {
        public void MostrarPetsASerImportado(string caminhoDoArquivoASerExibido)
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
