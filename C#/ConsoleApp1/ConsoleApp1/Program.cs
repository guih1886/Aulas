// Screen Sound
//List<string> bandas = new List<string>();
Dictionary<string, List<int>> bandasCadastradas = new Dictionary<string, List<int>>();

void ExibirLogo()
{
    Console.WriteLine(@"
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
}

void ExibirOpcoesDoMenu()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("Digite sua opção: ");
    string opcao = Console.ReadLine();
    int opcaoInt = int.Parse(opcao);
    switch (opcaoInt)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ExibirBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            ExibeMediaBanda();
            break;
        case -1:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

}
void ExibirTituloDaOpcao(string titulo)
{
    int qtd = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qtd, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Cadastrar bandas");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasCadastradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"Banda {nomeDaBanda} cadastrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo as bandas cadastradas");
    foreach (string item in bandasCadastradas.Keys)
    {
        Console.WriteLine($"Banda: {item}");
    }
    Console.ReadKey();
    ExibirOpcoesDoMenu();
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite a banda que deseja avaliar: ");
    string bandaSelecionada = Console.ReadLine()!;
    if (bandasCadastradas.ContainsKey(bandaSelecionada))
    {
        Console.Write($"Qual a nota para {bandaSelecionada}?: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasCadastradas[bandaSelecionada].Add(nota);
        Console.WriteLine($"A nota {nota} foi cadastrada com sucesso.");
        Thread.Sleep(3500);
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {bandaSelecionada} não foi encontrada.");
        Thread.Sleep(3500);
        ExibirOpcoesDoMenu();
    }

}

void ExibeMediaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo média de notas da banda");
    Console.Write("Digite a banda que deseja exibir a média de avaliação: ");
    string bandaSelecionada = Console.ReadLine()!;
    if (bandasCadastradas.ContainsKey(bandaSelecionada))
    {
        double media = bandasCadastradas[bandaSelecionada].Average();
        Console.Write($"A nota média da banda {bandaSelecionada} é de {media} ");
        Thread.Sleep(3500);
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {bandaSelecionada} não foi encontrada.");
        Thread.Sleep(3500);
        ExibirOpcoesDoMenu();
    }
}


ExibirOpcoesDoMenu();
Console.ReadLine();