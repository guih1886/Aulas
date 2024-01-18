using System.Collections.Generic;
using System.Net.Http.Json;
using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console.Comandos
{

    public class List
    {
        HttpClient client;
        public List()
        {
            client = new Util().ConfiguraHttpClient("http://localhost:5057");
        }
        public async Task ListarPetsAsync()
        {
            var pets = await ListPetsAsync();
            foreach (var pet in pets)
            {
                System.Console.WriteLine(pet);
            }
        }

        async Task<IEnumerable<Pet>?> ListPetsAsync()
        {
            HttpResponseMessage response = await client.GetAsync("pet/list");
            return await response.Content.ReadFromJsonAsync<IEnumerable<Pet>>();
        }
    }
}
