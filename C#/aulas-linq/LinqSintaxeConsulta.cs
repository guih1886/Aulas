using SerenattoEnsaio.Dados;

namespace Serenatto;

static class LinqSintaxeConsulta
{
    static List<string> formasPagamento = DadosFormaDePagamento.FormasDePagamento;

    public static void ConsultaFormaPagamentos()
    {
        Console.WriteLine("Relatório formas de pagamento");

        var pesquisa = from p in formasPagamento
                       where p.Contains('c')
                       select p;

        Console.WriteLine(string.Join(" - ", pesquisa));
    }


}
