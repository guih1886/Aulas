namespace Alura.Adopet.Console.Comandos.Factories
{
    public interface IComandoFactory
    {
        bool ConsegueCriarOTipo(Type? tipoComando);
        IComando? CriarComando(string[] args);
    }
}
