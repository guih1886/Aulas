class Podcast(string nome, string host)
{
    private List<Episodio> episodios = new List<Episodio>();
    private string Nome { get; } = nome;
    private string Host { get; } = host;
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodios(Episodio epsodio)
    {
        episodios.Add(epsodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");

        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Este podcast possui {TotalEpisodios} episódios.");
    }
}