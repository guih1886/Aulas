using ScreenSound.Modelos;

Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica("Musica1", queen)
{
    Duracao = 120,
    Disponivel = true,
    Genero = new Genero("Rock")

};
Musica musica2 = new Musica("Musica2", queen)
{
    Duracao = 354,
    Disponivel = false,
    Genero = new Genero("Rock")
};


albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

albumDoQueen.ExibirMusicasDoAlbum();

queen.ExibirDiscografia();

Episodio ep1 = new Episodio(2, "SOLID", 450);
ep1.AdicionarConvidados("João");
ep1.AdicionarConvidados("Pedro");
ep1.AdicionarConvidados("Maria");
Console.WriteLine(ep1.Resumo);

Episodio ep2 = new Episodio(1, "Outro", 450);
ep2.AdicionarConvidados("João");
ep2.AdicionarConvidados("Pedro");
ep2.AdicionarConvidados("Maria");
Console.WriteLine(ep2.Resumo);

Podcast podcast1 = new Podcast("Podcast 1", "Guilherme");
podcast1.AdicionarEpisodios(ep1);
podcast1.AdicionarEpisodios(ep2);
podcast1.ExibirDetalhes();