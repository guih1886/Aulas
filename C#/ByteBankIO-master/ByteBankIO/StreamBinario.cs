namespace ByteBankIO;

partial class Program
{
    static void EscritaBinaria()
    {
        using (var fs = new FileStream("testeDeEscrita.csv", FileMode.Create))
        using (var escritor = new BinaryWriter(fs))
        {
            escritor.Write(456);
            escritor.Write(65898);
            escritor.Write(16698.9);
            escritor.Write("guilherme");
        }
    }

    static void LeituraBinaria()
    {
        using (var fs = new FileStream("testeDeEscrita.csv", FileMode.Open))
        using (var leitor = new BinaryReader(fs))
        {
            var agencia = leitor.ReadInt32();
            var numeroConta = leitor.ReadInt32();
            var saldo = leitor.ReadDouble();
            var nome = leitor.ReadString();

            Console.WriteLine($"Agencia {agencia}/{numeroConta} {nome} {saldo}");
        }
    }
}
