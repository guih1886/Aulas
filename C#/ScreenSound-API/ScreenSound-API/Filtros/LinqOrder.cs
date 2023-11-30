using ScreenSound_API.Modelos;

namespace ScreenSound_API.Filtros;

internal class LinqOrder
{
    public static void OrdenarListaDeArtista(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musicas => musicas.Artista).Select(musica => musica.Artista).Distinct().ToList();
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"Artistas - {artista}");
        }
    }
}
