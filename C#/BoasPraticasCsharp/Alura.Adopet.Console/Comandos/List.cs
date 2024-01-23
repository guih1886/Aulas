using System.Collections.Generic;
using System.Net.Http.Json;
using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos;

namespace Alura.Adopet.Console.Comandos
{

    public class List : IComando
    {
        private readonly HttpClientPet clientPet;

        public List(HttpClientPet clientPet)
        {
            this.clientPet = clientPet;
        }

        public async Task ExecutarAsync(string[] args)
        {
            await ListarPetsAsync();
        }

        private async Task ListarPetsAsync()
        {
            var pets = await clientPet.ListPetsAsync();
            foreach (var pet in pets)
            {
                System.Console.WriteLine(pet);
            }
        }
    }
}
