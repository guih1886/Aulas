using Alura.Adopet.Console.Comandos;

ComandosDoSistema comandos = new(caminhoDoArquivo: args[1]);

try
{
    string comando = args[0].Trim();
    IComando comandosDoSistema = comandos[comando]!;
    if (comandosDoSistema is not null)
    {
        await comandosDoSistema.ExecutarAsync(args);
    }
    else
    {
        Console.WriteLine("Comando inválido!");
    }
}
catch (Exception ex)
{
    // mostra a exceção em vermelho
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Aconteceu um exceção: {ex.Message}");
}
finally
{
    Console.ForegroundColor = ConsoleColor.White;
}