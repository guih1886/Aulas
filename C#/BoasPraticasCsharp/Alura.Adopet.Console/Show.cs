namespace Alura.Adopet.Console
{
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
