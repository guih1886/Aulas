using Alura.Adopet.Console.Comandos;
using System.Reflection;

namespace Alura.Adopet.Testes
{
    public class DocumentacaoDoSistema
    {
        public static Dictionary<string, DocComando> ToDictionary(Assembly assemblyComODocComando)
        {
            return assemblyComODocComando.GetTypes()
                .Where(t => t.GetCustomAttributes<DocComando>().Any())
                .Select(t => t.GetCustomAttribute<DocComando>()!)
                .ToDictionary(d => d.Instrucao);
        }
    }
}