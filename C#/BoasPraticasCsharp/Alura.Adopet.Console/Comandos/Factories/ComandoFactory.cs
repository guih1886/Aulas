using Alura.Adopet.Console.Extensions;
using System;
using System.Reflection;

namespace Alura.Adopet.Console.Comandos.Factories
{
    public static class ComandoFactory
    {
        public static IComando? CriarComando(string[]? args)
        {
            if (args is null || args.Length == 0)
            {
                return null;
            }
            Type? tipoRetornado = Assembly.GetExecutingAssembly().GetTipoComando(args[0]);
            var listaDeFabricas = Assembly.GetExecutingAssembly().GetFabricas();
            var fabrica = listaDeFabricas.FirstOrDefault(t => t!.ConsegueCriarOTipo(tipoRetornado));
            if (fabrica == null) return null;
            return fabrica.CriarComando(args);
        }
    }
}