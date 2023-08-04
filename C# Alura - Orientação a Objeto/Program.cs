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








