using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos;
using Alura.Adopet.Console.Util;
using FluentResults;

namespace Alura.Adopet.Console.Comandos
{
    [DocComando(instrucao: "import",
        documentacao: "adopet import <arquivo> comando que realiza a importação do arquivo de pets.")]
    public class Import : IComando
    {
        private readonly HttpClientPet clientPet;
        private readonly LeitorDeArquivo leitor;

        public Import(HttpClientPet clientPet, LeitorDeArquivo leitor)
        {
            this.clientPet = clientPet;
            this.leitor = leitor;
        }

        public async Task<Result> ExecutarAsync()
        {
            return await ImportacaoArquivoPetAsync();
        }

        private async Task<Result> ImportacaoArquivoPetAsync()
        {
            try
            {
                List<Pet> listaDePet = leitor.RealizaLeitura();
                foreach (var pet in listaDePet)
                {
                    try
                    {
                        await clientPet.CreatePetAsync(pet);
                    }
                    catch (Exception ex)
                    {
                        System.Console.WriteLine(ex.Message);
                    }
                }
                return Result.Ok().WithSuccess(new SucessWithPets(listaDePet, "Importação realizada com sucesso."));

            }
            catch (Exception e)
            {
                return Result.Fail(new Error(e.Message).CausedBy(e));
            }
        }
    }
}
