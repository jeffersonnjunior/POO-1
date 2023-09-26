namespace ConsoleApp1
{
    public class Banda
    {
        public Banda(string nome)
        {
            Nome = nome;
        }

        private List<Album> albuns = new();
        public string Nome { get; }


        public void AdicionarAlbum(Album album)
        {
            albuns.Add(album);
        }

        public void ExbirDiscografia()
        {
            Console.WriteLine($"Discografia da banda {Nome}");
            foreach(Album album in albuns) 
            {
                Console.WriteLine($"Álbum: {album.Nome}");
            }
        }
    }
}
