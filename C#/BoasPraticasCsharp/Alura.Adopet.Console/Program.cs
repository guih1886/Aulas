using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.UI;
using FluentResults;

ComandosDoSistema comandos = new ComandosDoSistema(caminhoDoArquivo: args[1]);


string comando = args[0].Trim();
IComando comandosDoSistema = comandos[comando];
if (comandosDoSistema is not null)
{
    var resultado = await comandosDoSistema.ExecutarAsync(args);
    ConsoleUI.ExibeResultado(resultado);
}
else
{
    ConsoleUI.ExibeResultado(Result.Fail("Comando inválido."));
}