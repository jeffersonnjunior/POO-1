namespace ConsoleApp1
{
    public class Podcast
    {
        List<Episodio> episodioList = new();
        public Podcast(string host, string nome)
        {
            Host = host;
            Nome = nome;
        }
        public string Host { get; set; }
        public string Nome { get; set; }
        public int TotalEpisodios => episodioList.Count();


        public void AdicionarEpisodio(Episodio episodio)
        {
            episodioList.Add(episodio);
        }
        public void ExibirDetalhes()
        {
            Console.WriteLine($"Host:{Host} - Nome do podcast:{Nome}");
            foreach(var episode in episodioList)
            {
                Console.WriteLine($"Nome: {episode.Titulo} - Duração: {episode.Duracao}min - Ordem: {episode.Ordem}");
            }
            Console.WriteLine($"Esse podcast tem o total de ep : {TotalEpisodios}");
        }
    }
}
