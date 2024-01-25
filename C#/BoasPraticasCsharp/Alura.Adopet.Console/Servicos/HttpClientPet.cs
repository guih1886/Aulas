using Alura.Adopet.Console.Modelos;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Alura.Adopet.Console.Servicos
{
    public class HttpClientPet
    {
        private HttpClient client;

        public HttpClientPet(HttpClient client)
        {
            this.client = client;
        }
        public virtual async Task<IEnumerable<Pet>?> ListPetsAsync()
        {
            HttpResponseMessage response = await client.GetAsync("pet/list");
            return await response.Content.ReadFromJsonAsync<IEnumerable<Pet>>();
        }

        public virtual Task<HttpResponseMessage> CreatePetAsync(Pet pet)
        {
            return client.PostAsJsonAsync("pet/add", pet);
        }
    }
}