using ConsoleApp1;

Banda morada = new("morada");

Album albumMorada = new("Tudo sobre você");

Musica musica1 = new(morada, "É tudo sobre você")
{
    Duracao = 123,
    Disponivel = true,
};

Musica musica2 = new(morada, "Emaus") 
{
    Duracao = 222,
    Disponivel = true,
};

albumMorada.AdicionarMuscia(musica1);
albumMorada.AdicionarMuscia(musica2);

albumMorada.MostrarMusica();


morada.AdicionarAlbum(albumMorada);
morada.ExbirDiscografia();


Episodio ep1 = new("Podcast-Finanças", 55, 1);
ep1.AdicionarConvidado("Kaka");
ep1.AdicionarConvidado("Jefferson");


Episodio ep2 = new("Podcast-Finanças", 52, 1);
ep2.AdicionarConvidado("Tiago Brunet");
ep2.AdicionarConvidado("Flavio Augusto");

Podcast podcast1 = new("Podcast", "PodCast");
podcast1.AdicionarEpisodio(ep1);
podcast1.AdicionarEpisodio(ep2);
podcast1.ExibirDetalhes();