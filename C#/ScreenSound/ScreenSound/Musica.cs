
class Musica
{
    private string nome;
    private string artista;
    private int duracao;
    private bool disponivel;

    public Musica(string nome, string artista, int duracao, bool disponivel)
    {
        this.nome = nome;
        this.artista = artista;
        this.duracao = duracao;
        this.disponivel = disponivel;
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {this.nome} - Artista: {this.artista} - Duração {this.duracao}s ");
        if (disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Disponível no plano premium.");
        }
    }
}

