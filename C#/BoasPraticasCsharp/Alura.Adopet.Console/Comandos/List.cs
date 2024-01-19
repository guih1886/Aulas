using System.Collections.Generic;
using System.Net.Http.Json;
using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Servicos;

namespace Alura.Adopet.Console.Comandos
{

    public class List : IComando
    {
        public async Task ExecutarAsync(string[] args)
        {
            await ListarPetsAsync();
        }

        private async Task ListarPetsAsync()
        {
            var pets = await ListPetsAsync();
            foreach (var pet in pets)
            {
                System.Console.WriteLine(pet);
            }
        }

        private async Task<IEnumerable<Pet>?> ListPetsAsync()
        {
            var client = new HttpClientPet().ConfiguraHttpClient("http://localhost:5057");
            HttpResponseMessage response = await client.GetAsync("pet/list");
            return await response.Content.ReadFromJsonAsync<IEnumerable<Pet>>();
        }
    }
}
