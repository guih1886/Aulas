using Alura.Adopet.Console.Comandos;
using Alura.Adopet.Console.Comandos.Factories;
using System.Reflection;

namespace Alura.Adopet.Console.Extensions
{
    public static class ComandoExtension
    {
        public static Type? GetTipoComando(this Assembly assembly, string comando)
        {
            return assembly
                //lista de tipos
                .GetTypes()
                //filtrar apenas os tipos concretos que são comandos
                .Where(t => !t.IsInterface && t.IsAssignableTo(typeof(IComando)))
                .FirstOrDefault(t => t.GetCustomAttributes<DocComando>()
                .Any(d => d.Instrucao.Equals(comando)));
        }

        public static IEnumerable<IComandoFactory?> GetFabricas(this Assembly assembly)
        {
            return assembly
                .GetTypes()
                //filtra os tipos que implementam a interface icomandofactory
                .Where(t => !t.IsInterface && t.IsAssignableTo(typeof(IComandoFactory)))
                //cria a instancia de cada factory
                .Select(f => Activator.CreateInstance(f) as IComandoFactory);
        }
    }
}
