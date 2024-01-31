
namespace Alura.Adopet.Console.Comandos.Factories
{
    public class HelpFactory : IComandoFactory
    {
        public bool ConsegueCriarOTipo(Type? tipoComando)
        {
            return tipoComando?.IsAssignableTo(typeof(Help)) ?? false;
        }

        public IComando? CriarComando(string[] args)
        {
            string? comandoASerExibido = args.Length == 2 ? args[1] : null;
            return new Help(comandoASerExibido!);
        }
    }
}
