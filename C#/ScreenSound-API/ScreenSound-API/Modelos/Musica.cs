using System.Text.Json.Serialization;

namespace ScreenSound_API.Modelos;

internal class Musica
{
    private string[] tonalidades = ["C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"];
    //anotação para serialização do dados
    [JsonPropertyName("song")]
    public string Nome { get; set; }
    [JsonPropertyName("artist")]
    public string Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    [JsonPropertyName("year")]
    public string? AnoString { get; set; }
    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tonalidade
    {
        get
        {
            return tonalidades[Key];
        }
    }
    public int Ano
    {
        get
        { return int.Parse(AnoString!); }
    }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista - {Artista}");
        Console.WriteLine($"Música - {Nome}");
        Console.WriteLine($"Duração - {Duracao / 1000}s");
        Console.WriteLine($"Genero - {Genero}");
        Console.WriteLine($"Tonalidade - {tonalidades[Key]}");

    }
}
