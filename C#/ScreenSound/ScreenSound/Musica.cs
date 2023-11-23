
namespace ScreenSound
{
    class Musica
    {
        public string Nome { get; set; }
        public string Artista { get; set; }
        public int Duracao { get; set; }
        private bool Disponivel { get; }
        public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}."; //somente get


        public Musica(string nome, string artista, int duracao, bool disponivel)
        {
            Nome = nome;
            Artista = artista;
            Duracao = duracao;
            Disponivel = disponivel;
        }

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome} - Artista: {Artista} - Duração {Duracao}s ");
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
}