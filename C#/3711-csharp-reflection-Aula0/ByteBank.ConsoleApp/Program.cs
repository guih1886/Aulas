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
    Console.WriteLine("3. Executar plugins.");
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
        case 3:
            ExecutarPlugins();
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

    if (metodoProcessar != null)
    {
        metodoProcessar.Invoke(instanciaClasse, new[] { parametroMetodo });
    }

    var novoConstrutor = construtores
    .Single(c => string.Join(",", c.GetParameters().Select(p => p.Name).ToArray()) ==
    "nomeArquivoSaida,dataRelatorio");
}

static void ExecutarPlugins()
{
    //Ler boletos a partir do arquivo CSV
    var leitorDeCSV = new LeitorDeBoleto();
    List<Boleto> boletos = leitorDeCSV.LerBoletos("Boletos.csv");

    //Obter classes de plugin 
    List<Type> classesDePlugin = ObterClassesDePlugin<IRelatorio<Boleto>>();

    foreach (var classe in classesDePlugin)
    {
        // Criar uma instância do plugin
        //var plugin = Activator.CreateInstance(classe, new object[] { "BoletosPorCedente.csv" });
        var plugin = Activator.CreateInstance(classe);

        // Chamar o método Processar usando Reflection
        MethodInfo? metodoSalvar = classe.GetMethod("Processar");
        if (metodoSalvar != null)
        {
            metodoSalvar.Invoke(plugin, new object[] { boletos });
        }
    }
}

static List<Type> ObterClassesDePlugin<T>()
{
    var tipoEncontrados = new List<Type>();

    //Obtendo assembly que está em execução
    Assembly assemblyEmExecucao = Assembly.GetExecutingAssembly();

    //Pegar o assembly onde o tipo é declarado
    Assembly assemblyDosPlugins = typeof(T).Assembly;

    List<Assembly> assemblies = ObterAssembliesDePlugins();

    foreach (Assembly assembly in assemblies)
    {
        Console.WriteLine($"Assembly encontrado: {assembly.FullName}");
        IEnumerable<Type> tiposImplementandoT = ObterTiposDoAssembly<T>(assembly);

        tipoEncontrados.AddRange(tiposImplementandoT);
    }

    return tipoEncontrados;
}

static IEnumerable<Type> ObterTiposDoAssembly<T>(Assembly assembly)
{
    //Obtem os tipos do assembly - 
    var tipos = assembly.GetTypes();

    foreach (Type tipo in tipos)
    {
        Console.WriteLine($"Nome: {tipo.Name}");
        Console.WriteLine($"Nome completo: {tipo.FullName}");
        Console.WriteLine($"É classe: {tipo.IsClass}");
        Console.WriteLine($"É interface: {tipo.IsInterface}");
        Console.WriteLine($"É abstrato: {tipo.IsAbstract}");

        Console.WriteLine($"Interfaces implementadas");
        foreach (var interfaceType in tipo.GetInterfaces())
        {
            Console.WriteLine($"Nome Interface: {interfaceType.Name}");
        }
        Console.WriteLine("");
    }

    //Encontrando tipos que implementam a interface T
    var tiposImplementandoT = tipos.Where(t => typeof(T).IsAssignableFrom(t) && t.IsClass && !t.IsAbstract);
    return tiposImplementandoT;
}

static List<Assembly> ObterAssembliesDePlugins()
{
    var assemblies = new List<Assembly>();

    const string diretorio = @"C:\Plugins";

    //Obter todos os arquivos .dll da pasta
    string[] arquivos = Directory.GetFiles(diretorio, "*.dll");

    foreach (string arquivo in arquivos)
    {
        //Carregar assembly a partir do arquivo DLL
        Assembly assembly = Assembly.LoadFrom(arquivo);
        assemblies.Add(assembly);
    }

    return assemblies;
}