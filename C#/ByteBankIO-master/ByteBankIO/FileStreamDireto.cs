using System.Text;

namespace ByteBankIO;

partial class Program
{
    static void FileStreamDireto()
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var numeroDeBytesLidos = -1;

            var buffer = new byte[1024]; //1KB

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, buffer.Length);
                EscreverBuffer(buffer, numeroDeBytesLidos);
            }
            fluxoDoArquivo.Close();
            Console.ReadKey();
        }
    }

    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {
        var utf8 = new UTF8Encoding();
        var texto = utf8.GetString(buffer, 0, bytesLidos);
        Console.Write(texto);
        //foreach (var item in buffer)
        //{
        //    Console.Write(item);
        //    Console.Write(" ");
        //}
    }
}

