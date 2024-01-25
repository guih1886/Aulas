using Alura.Adopet.Console.Servicos;
using Alura.Adopet.Console.Util;
using FluentResults;

namespace Alura.Adopet.Console.Comandos
{

    public class List : IComando
    {
        private readonly HttpClientPet clientPet;

        public List(HttpClientPet clientPet)
        {
            this.clientPet = clientPet;
        }

        public async Task<Result> ExecutarAsync(string[] args)
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
