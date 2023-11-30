using ScreenSound_API.Modelos;

namespace ScreenSound_API.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGeneros(List<Musica> musicas)
    {
        var todosOsGeneros = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGeneros)
        {
            Console.WriteLine($"Genero - {genero}");
        }
    }

    public static void FiltrarArtistasPorGenero(List<Musica> musicas, string genero)
    {
        var artistasPorGenero = musicas.Where(musica => musica.Genero.Contains(genero)).OrderBy(musicas => musicas.Artista).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas do genêro músical {genero}");
        foreach (var artista in artistasPorGenero)
        {
            Console.WriteLine($"Artista - {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string artista)
    {
        var musicasDoArtista = musicas.Where(musicas => musicas.Artista!.Equals(artista)).ToList();
        Console.WriteLine($"Musicas do Artista {artista}");
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasPeloAno(List<Musica> musicas, int ano)
    {
        var musicasDoAnoSelecionado = musicas.Where(musicas => musicas.Ano == ano).OrderBy(musicas => musicas.Ano).ToList();
        Console.WriteLine($"Exibindo as músicas do ano {ano}");
        foreach (var musica in musicasDoAnoSelecionado)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarPorTonalidade(List<Musica> musicas, string tonalidade)
    {
        var musicasDaTonalidade = musicas.Where(musica => musica.Tonalidade.Equals(tonalidade)).ToList();
        Console.WriteLine($"Exibindo a lista de músicas da tonalidade {tonalidade}");
        foreach (var musica in musicasDaTonalidade)
        {
            Console.WriteLine($"- {musica.Nome}");
        }

    }
}
