namespace ByteBankIO;

partial class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDoArquivo);

            //var linha = leitor.ReadLine();
            var texto = leitor.ReadToEnd();
            Console.WriteLine(texto);
        }
        Console.ReadKey();
    }
}