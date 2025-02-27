using SerenattoEnsaio.Dados;
using SerenattoEnsaio.Modelos;

namespace Serenatto;

static class LinqSintaxeMetodo
{
    static List<Cliente> clientes = DadosClientes.GetClientes().ToList();

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




}
