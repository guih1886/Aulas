using System.Net.Http.Headers;
using System.Net.Http.Json;
using Alura.Adopet.Console.Modelos;

namespace Alura.Adopet.Console.Comandos
{
    [DocComando(instrucao: "import",
        documentacao: "adopet import <arquivo> comando que realiza a importação do arquivo de pets.")]
    public class Import
    {
        HttpClient client;

        public Import()
        {
            client = new Util().ConfiguraHttpClient("http://localhost:5057");
        }
        public async Task ImportacaoArquivoPetAsync(string caminhoDoArquivoDeImportacao)
        {
            LeitorDeArquivo leitor = new LeitorDeArquivo();
            List<Pet> listaDePet = leitor.RealizaLeitura(caminhoDoArquivoDeImportacao);
            foreach (var pet in listaDePet)
            {
                try
                {
                    var resposta = await CreatePetAsync(pet);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }
            System.Console.WriteLine("Importação concluída!");
        }
        Task<HttpResponseMessage> CreatePetAsync(Pet pet)
        {
            HttpResponseMessage? response = null;
            using (response = new HttpResponseMessage())
            {
                return client.PostAsJsonAsync("pet/add", pet);
            }
        }
    }
}
