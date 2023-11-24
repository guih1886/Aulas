class Episodio(int ordem, string titulo, int duracao)
{
    private List<string> convidados = new List<string>();
    public int Ordem { get; } = ordem;
    private string Titulo { get; } = titulo;
    private int Duracao { get; } = duracao;
    public string Resumo => $"{Ordem} - {Titulo} ({Duracao}s) - {string.Join(", ", convidados)}";

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}