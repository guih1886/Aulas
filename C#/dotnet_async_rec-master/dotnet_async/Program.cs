using System.Text;

void LerArquivo()
{
    var conteudo = File.ReadAllText("voos.txt", Encoding.UTF8);
    Console.WriteLine($"Conteudo: {conteudo}");
}

void ExibirRelatorio()
{
    Console.WriteLine("Exibindo relatorio de compra de passagens.");
    Thread.Sleep(10000);
}

var threadLerArquivo = new Thread(() => LerArquivo());
var threadExibirRelatorio = new Thread(() => ExibirRelatorio());

void InicializarThreads()
{
    threadLerArquivo.Start();
    threadExibirRelatorio.Start();
}

InicializarThreads();

Console.WriteLine("Outras operações.");