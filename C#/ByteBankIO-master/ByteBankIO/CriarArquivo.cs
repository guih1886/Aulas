using System.Text;

namespace ByteBankIO;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoDoArquivo = "contasExportadas.csv";

        using (var fluxoArquivo = new FileStream(caminhoDoArquivo, FileMode.Create))
        {
            var contaComoString = "456,65798,4785.40,Gustavo";
            var enconding = Encoding.UTF8;

            var bytes = enconding.GetBytes(contaComoString);

            fluxoArquivo.Write(bytes, 0, bytes.Length);
        }
    }

    static void CriarArquivoComWhiter()
    {
        var caminhoDoArquivo = "contasExportadas2.csv";

        using (var fluxoArquivo = new FileStream(caminhoDoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoArquivo))
        {
            escritor.Write("456,65798,4785.40,Gustavo");
        }
    }

    static void TestaEscrita()
    {
        var caminhoDoArquivo = "teste.txt";

        using (var fluxoArquivo = new FileStream(caminhoDoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoArquivo))
        {
            for (int i = 0; i < 10000; i++)
            {
                escritor.WriteLine($"linha {i}");
                escritor.Flush();
                Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter....");
                Console.ReadLine();
            }

        }
    }
}
