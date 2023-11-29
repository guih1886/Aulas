namespace ScreenSound.Modelos;

internal class Banda(string nome) : IAvaliavel
{
    public string Nome { get; } = nome;
    public string? Resumo { get; set; }
    private List<Avaliacao> notas = new List<Avaliacao>();
    private List<Album> albuns = new List<Album>();
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine("Exibindo Discografia");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} - ({album.DuracaoTotal}s)");
        }
    }
}