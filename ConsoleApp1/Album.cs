namespace ConsoleApp1
{
    public class Album
    {
        private List<Musica> musicas = new();

        public Album(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; }
        public int DuracaoTotal => musicas.Sum(n => n.Duracao);
        
        public void AdicionarMuscia(Musica musica)
        {
            musicas.Add(musica);
        }

        public void MostrarMusica()
        {
            Console.WriteLine($"Nome do álbum {Nome}\n");
            
            foreach (var musica in musicas)
            {
                Console.WriteLine($"Música: {musica.Nome}");
            }
            Console.WriteLine($"Duração das músicas: {DuracaoTotal} segundos");
        }
    }
}
