using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Comandos.Factories;
using Alura.Adopet.Console.UI;
using FluentResults;

IComando? comandosDoSistema = ComandoFactory.CriarComando(args);
if (comandosDoSistema is not null)
{
    var resultado = await comandosDoSistema.ExecutarAsync();
    ConsoleUI.ExibeResultado(resultado);
}
else
{
    ConsoleUI.ExibeResultado(Result.Fail("Comando inválido."));
}