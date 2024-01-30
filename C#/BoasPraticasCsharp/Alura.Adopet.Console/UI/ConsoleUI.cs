using Alura.Adopet.Console.Results;
using FluentResults;

namespace Alura.Adopet.Console.UI
{
    public static class ConsoleUI
    {
        public static void ExibeResultado(Result resultado)
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
            try
            {
                if (resultado.IsFailed)
                {
                    ExibeFalha(resultado);
                }
                else
                {
                    ExibeSucesso(resultado);
                }
            }
            catch (Exception)
            {

                throw;
            }
            System.Console.ForegroundColor = ConsoleColor.White;
        }

        private static void ExibeSucesso(Result resultado)
        {
            var sucesso = resultado.Successes.First();
            switch (sucesso)
            {
                case SucessWithPets s:
                    ExibirPets(s);
                    break;
                case SucessWithDocs d:
                    ExibeDocumentacao(d);
                    break;
            }
        }

        private static void ExibeDocumentacao(SucessWithDocs documentacaoComando)
        {
            foreach (var doc in documentacaoComando.Documentacao)
            {
                System.Console.WriteLine(doc);
            }

        }

        private static void ExibirPets(SucessWithPets sucesso)
        {
            foreach (var pet in sucesso.Data)
            {
                System.Console.WriteLine(pet);
            }
            System.Console.WriteLine(sucesso.Mensagem);
        }

        private static void ExibeFalha(Result resultado)
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            var erro = resultado.Errors[0];
            System.Console.WriteLine($"Aconteceu um exceção: {erro.Message}");
        }
    }
}
