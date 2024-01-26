using System.Net.Http.Headers;
using System;

namespace Alura.Adopet.Console.Servicos.Arquivos
{
    public class HttpClientFactory : IHttpClientFactory
    {
        private string url = "http://localhost:60518";
        public HttpClient CreateClient(string? name)
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