using Alura.Adopet.Console.Servicos.Arquivos;
using Alura.Adopet.Console.Util;
using FluentResults;

namespace Alura.Adopet.Console.Comandos
{
    [DocComando(instrucao: "list",
        documentacao: "adopet list <arquivo> " + 
                      "comando que lista os pets no arquivo.")]
    public class List : IComando 
    {
        private readonly HttpClientPet clientPet;

        public List(HttpClientPet clientPet)
        {
            this.clientPet = clientPet;
        }

        public async Task<Result> ExecutarAsync()
        {
            return await ListarPetsAsync();
        }

        private async Task<Result> ListarPetsAsync()
        {
            var pets = await clientPet.ListPetsAsync();
            return Result.Ok().WithSuccess(new SucessWithPets(pets, "Listagem executada com sucesso."));
        }
    }
}
