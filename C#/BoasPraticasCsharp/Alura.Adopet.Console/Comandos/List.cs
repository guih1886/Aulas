using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos.Abstracoes;
using Alura.Adopet.Console.Servicos.Arquivos;
using Alura.Adopet.Console.Results;
using FluentResults;

namespace Alura.Adopet.Console.Comandos
{
    [DocComando(instrucao: "list",
        documentacao: "adopet list <arquivo> " + 
                      "comando que lista os pets no arquivo.")]
    public class List : IComando 
    {
        private readonly IApiService<Pet> clientPet;

        public List(IApiService<Pet> clientPet)
        {
            this.clientPet = clientPet;
        }

        public async Task<Result> ExecutarAsync()
        {
            return await ListarPetsAsync();
        }

        private async Task<Result> ListarPetsAsync()
        {
            IEnumerable<Pet>? pets = await clientPet.ListAsync();
            return Result.Ok().WithSuccess(new SuccessWithPets(pets!, "Listagem executada com sucesso."));
        }
    }
}
