namespace ScreenSound.Modelos;

internal class Album : IAvaliavel
{

    private List<Musica> musicas = new List<Musica>();
    private List<Avaliacao> notas = new();
    public string Nome { get; set; }
    public static int ContadorDeObjetos = 0;
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }

    public Album(string nome)
    {
        Nome = nome;
        ContadorDeObjetos++;
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine(musica.Nome);
        }
        Console.WriteLine($"Duração total do album: {DuracaoTotal}s");
    }

    public void AdicionarNota(Avaliacao a)
    {
        notas.Add(a);
    }
}
