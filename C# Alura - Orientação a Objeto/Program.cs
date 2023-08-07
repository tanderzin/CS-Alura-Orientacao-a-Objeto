/*
Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQueen.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();
*/


/*
Banda U2 = new Banda("U2");

Album albumDoU2 = new Album("The Joshua Tree");

Musica musica3 = new Musica(U2, "With Or Without You")
{
    Duracao = 247,
    Disponivel = true,
};

musica3.Duracao = 247;

albumDoU2.AdicionarMusica(musica3);

albumDoU2.ExibirMusicasDoAlbum();
musica3.ExibirFichaTecnica();

U2.AdicionarAlbum(albumDoU2);
U2.ExibirDiscografia();
*/

Episodio ep1 = new(2, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");

Episodio ep2 = new(1, "Técnicas de aprendizado", 67);
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Marcos");
ep2.AdicionarConvidados("Flavia");

Podcast podcast = new("Podcast especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);

podcast.ExibirDetalhes();


