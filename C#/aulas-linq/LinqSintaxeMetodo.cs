using SerenattoEnsaio.Dados;
using SerenattoEnsaio.Modelos;
using SerenattoPreGravacao.Dados;

namespace Serenatto;

static class LinqSintaxeMetodo
{
    static List<Cliente> clientes = DadosClientes.GetClientes().ToList();
    static List<Produto> produtosCardapio = DadosCardapio.GetProdutos();
    static IEnumerable<int> dadosPedidos = DadosPedidos.QuantidadeItensPedidosPorDia.SelectMany(lista => lista);

    public static void ConsultaClientes()
    {
        Console.WriteLine("Relatório dados clientes");

        foreach (var cliente in clientes)
        {
            Console.WriteLine($"{cliente.Id} - {cliente.Nome} - {cliente.Telefone}");
        }
    }

    public static void ConsultaClientesPorNome(string nome)
    {
        Console.WriteLine("RELATÓRIO CLIENTES POR NOME");

        IEnumerable<Cliente> clientesPorNome = clientes.Where(c => c.Nome.Contains(nome));

        foreach (var cliente in clientesPorNome)
        {
            Console.WriteLine(cliente.Nome);
        }
    }

    public static void ConsultaProdutosPorNome()
    {
        Console.WriteLine("Dados produtos por nome");
        var produtosPorNome = produtosCardapio.Select(p => p.Nome);

        foreach (var item in produtosPorNome)
        {
            Console.WriteLine(item);
        }
    }

    public static void ConsultaProdutosPorNomeEPreco()
    {
        Console.WriteLine("Dados produtos por nome e preço");
        var produtosPorNome = produtosCardapio.Select(p => new
        {
            Nome = p.Nome,
            Preco = p.Preco
        });

        foreach (var item in produtosPorNome)
        {
            Console.WriteLine($"{item.Nome} - R$ {item.Preco}");
        }
    }

    public static void ProdutoPrecoCombo()
    {
        Console.WriteLine("Produtos preço combo LV4P3");

        //Projeção anônima
        var produtosPrecoCombo = produtosCardapio.Select(p => new
        {
            Nome = p.Nome,
            PrecoCombo = p.Preco * 3
        });

        foreach (var item in produtosPrecoCombo)
        {
            Console.WriteLine($"{item.Nome} - R$ {item.PrecoCombo}");
        }
    }

    public static void RelatorioQuantidadeProdutosPedidosMes()
    {
        Console.WriteLine("Produtos pedidos no mês");
        foreach (var item in dadosPedidos)
        {
            Console.Write($"{item} ");
        }
    }
}
