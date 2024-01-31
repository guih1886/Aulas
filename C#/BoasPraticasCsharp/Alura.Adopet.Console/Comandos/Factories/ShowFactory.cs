using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;
using Alura.Adopet.Console.Servicos.Arquivos;

namespace Alura.Adopet.Console.Comandos.Factories
{
    public class ShowFactory : IComandoFactory
    {
        public bool ConsegueCriarOTipo(Type? tipoComando)
        {
            return tipoComando?.IsAssignableTo(typeof(Show)) ?? false;
        }

        public IComando? CriarComando(string[] args)
        {
            var leitorDeArquivosShow = LeitorDeArquivosFactory.CreatePetFrom(args[1]);
            if (leitorDeArquivosShow is null) return null;
            return new Show(leitorDeArquivosShow);
        }
    }
}
