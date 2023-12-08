namespace ByteBankIO;

partial class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDoArquivo);

            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                var contaCorrente = ConverterStringParaContaCorrente(linha);
                Console.WriteLine($"Conta: {contaCorrente.Numero} - AG: {contaCorrente.Agencia} - Saldo: {contaCorrente.Saldo}");
            }
            EscritaBinaria();
            LeituraBinaria();
        }
        Console.ReadKey();
    }

    static ContaCorrente ConverterStringParaContaCorrente(string linha)
    {
        var campos = linha.Split(',');

        var agencia = int.Parse(campos[0]);
        var numero = int.Parse(campos[1]);
        var saldoComoDouble = double.Parse(campos[2].Replace('.', ','));
        var nomeTitular = campos[3];

        var resultado = new ContaCorrente(agencia, numero);
        resultado.Depositar(saldoComoDouble);
        resultado.Titular = new Cliente(nomeTitular);
        return resultado;
    }
}