using ScreenSound;

Musica musica1 = new Musica("Musica1", "Artista1", 120, true);
Musica musica2 = new Musica("Musica2", "Artista2", 240, false);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
Console.WriteLine(musica2.DescricaoResumida);