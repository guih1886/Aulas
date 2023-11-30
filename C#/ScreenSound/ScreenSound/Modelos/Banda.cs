namespace ScreenSound.Modelos;

internal class Banda(string nome) : IAvaliavel
{
    public string Nome { get; } = nome;
    public string? Resumo { get; set; }
    public List<Avaliacao> Notas = new List<Avaliacao>();
    public List<Album> Albuns = new List<Album>();
    public double Media
    {
        get
        {
            if (Notas.Count == 0) return 0;
            else return Notas.Average(a => a.Nota);
        }
    }

    public void AdicionarNota(Avaliacao nota)
    {
        Notas.Add(nota);
    }

    public void AdicionarAlbum(Album album)
    {
        Albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine("Exibindo Discografia");
        foreach (Album album in Albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} - ({album.DuracaoTotal}s)");
        }
    }
}