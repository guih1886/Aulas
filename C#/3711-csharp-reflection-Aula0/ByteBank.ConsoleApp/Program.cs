using ByteBank.Common;
using System.Reflection;

MostrarBanner();

while (true)
{
    MostrarMenu();

    if (int.TryParse(Console.ReadLine(), out int escolha))
    {
        ExecutarEscolha(escolha);
    }
    else
    {
        Console.WriteLine("Opção inválida. Tente novamente.");
    }
}

static void MostrarBanner()
{
    Console.WriteLine(@"


     _           _       _                 _    
    | |         | |     | |               | |   
    | |__  _   _| |_ ___| |__   __ _ _ __ | | __
    | '_ \| | | | __/ _ \ '_ \ / _` | '_ \| |/ /
    | |_) | |_| | ||  __/ |_) | (_| | | | |   < 
    |_.__/ \__, |\__\___|_.__/ \__,_|_| |_|_|\_\
            __/ |                               
           |___/                                
                                
                                
        ");
}

static void MostrarMenu()
{
    Console.WriteLine("\nEscolha uma opção:");
    Console.WriteLine();
    Console.WriteLine("1. Ler arquivo de boletos");
    Console.WriteLine("2. Gravar arquivo com boletos agrupados por cedente");
    Console.WriteLine();
    Console.Write("Digite o número da opção desejada: ");
}

static void ExecutarEscolha(int escolha)
{
    switch (escolha)
    {
        case 1:
            LerArquivoBoletos();
            break;
        case 2:
            GravarGrupoBoletos();
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}

static void LerArquivoBoletos()
{
    Console.WriteLine("Lendo arquivo de boletos...");

    var leitorDeBoleto = new LeitorDeBoleto();
    List<Boleto> boletos = leitorDeBoleto.LerBoletos("Boletos.csv");

    foreach (var boleto in boletos)
    {
        Console.WriteLine($"Cedente: {boleto.CedenteNome}, Valor: {boleto.Valor:#0.00}, Vencimento: {boleto.DataVencimento}");
    }
}

static void GravarGrupoBoletos()
{
    Console.WriteLine("Gravando arquivo de boletos...");
    var leitorDeBoleto = new LeitorDeBoleto();
    List<Boleto> boletos = leitorDeBoleto.LerBoletos("Boletos.csv");

    //RelatorioDeBoleto gravadorDeCSV = new RelatorioDeBoleto("BoletosPorCedente.csv");
    //gravadorDeCSV.Processar(boletos);

    var nomeParametroConstrutor = "nomeArquivoSaida";
    var parametroConstrutor = "BoletosPorCedente.csv";
    var nomeMetodo = "Processar";
    var parametroMetodo = boletos;

    ProcessarDinamicamente(nomeParametroConstrutor, parametroConstrutor,
        nomeMetodo, parametroMetodo);
}

static void ProcessarDinamicamente(string nomeParametroConstrutor, string parametroConstrutor,
    string nomeMetodo, object parametroMetodo)
{
    Type tipo = typeof(RelatorioDeBoleto);
    ConstructorInfo[] construtores = tipo.GetConstructors();

    foreach (var item in construtores)
    {
        Console.WriteLine($"Construtor: {item.Name}");
        Console.WriteLine($"Parametros: {item.GetParameters().Length}");
    }

    //Requisitos:
    //1 - Pegar o construtor que tenha apenas um parametro
    //2 - Nome do parametro seja 'nomeArquivoSaida'

    ConstructorInfo construtor = construtores.Single(p => p.GetParameters().Length == 1 &&
                                              p.GetParameters().Any(p => p.Name == nomeParametroConstrutor));

    object instanciaClasse = construtor.Invoke(new object[] { parametroConstrutor });

    MethodInfo? metodoProcessar = tipo.GetMethod(nomeMetodo);

    metodoProcessar.Invoke(instanciaClasse, new[] { parametroMetodo });
}