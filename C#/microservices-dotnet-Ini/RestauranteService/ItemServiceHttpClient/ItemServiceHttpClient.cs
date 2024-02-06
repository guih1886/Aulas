using RestauranteService.Dtos;
using System.Text;
using System.Text.Json;

namespace RestauranteService.ItemServiceHttpClient
{
    public class ItemServiceHttpClient : IItemServiceHttpClient
    {
        private readonly HttpClient client;
        public readonly IConfiguration _configuration;

        public ItemServiceHttpClient(HttpClient client, IConfiguration configuration)
        {
            this.client = client;
            _configuration = configuration;
        }
        public async void EnviaRestauranteParaItemService(RestauranteReadDto readDto)
        {
            var conteudoHttp = new StringContent
                (
                    JsonSerializer.Serialize(readDto),
                    Encoding.UTF8,
                    "application/json"
                );
            await client.PostAsync(_configuration["ItemService"], conteudoHttp);
        }
    }
}
