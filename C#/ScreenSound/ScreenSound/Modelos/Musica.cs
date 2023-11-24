namespace ScreenSound.Modelos;
class Musica(string nome, Banda artista)
{
    public string Nome { get; } = nome;
    private Banda Artista { get; } = artista;
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}."; //somente get
    public Genero Genero { get; set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome} - Artista: {Artista.Nome} - Duração {Duracao}s ");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Disponível no plano premium.");
        }
    }
}