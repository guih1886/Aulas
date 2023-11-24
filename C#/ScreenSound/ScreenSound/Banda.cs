class Banda(string nome)
{
    public string Nome { get; } = nome;
    private List<Album> albuns = new List<Album>();
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