using ScreenSound_API.Modelos;
using ScreenSound_API.Filtros;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{

    try
    {
        string baseName = "https://guilhermeonrails.github.io/api-csharp-songs/songs.json";
        string resposta = await client.GetStringAsync(baseName);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[59].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGeneros(musicas);
        //LinqOrder.OrdenarListaDeArtista(musicas);
        //LinqFilter.FiltrarArtistasPorGenero(musicas, "pop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Korn");
        //LinqFilter.FiltrarMusicasPeloAno(musicas, 2012);
        LinqFilter.FiltrarPorTonalidade(musicas, "F");

        var musicasPreferidas = new MusicasPreferidas("Guilherme");
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[20]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[30]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[40]);
        musicasPreferidas.ExibirMusicasFavoritas();
        musicasPreferidas.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}