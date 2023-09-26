namespace ConsoleApp1
{
    public class Musica
    {
        public Musica(Banda artista, string nome)
        {
            Artista = artista;
            Nome = nome;
        }

        public string Nome { get; }
        public Banda Artista { get; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }
        public string DescricaoResumida =>
            $"A música {Nome} tem o artista {Artista}";

        public void FichaTecnica()
        {
            Console.WriteLine(Nome);
            Console.WriteLine(Artista.Nome);
            Console.WriteLine(Duracao);
            if(Disponivel)
            {
                Console.WriteLine("Está disponível");
            }else Console.WriteLine("Ñão está disponível");
        }
    }
}
