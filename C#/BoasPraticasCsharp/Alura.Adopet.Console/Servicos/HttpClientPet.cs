using System.Net.Http.Headers;

namespace Alura.Adopet.Console.Servicos
{
    public class HttpClientPet
    {
        public HttpClient ConfiguraHttpClient(string url)
        {
            HttpClient _client = new HttpClient();
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            _client.BaseAddress = new Uri(url);
            return _client;
        }
    }
}