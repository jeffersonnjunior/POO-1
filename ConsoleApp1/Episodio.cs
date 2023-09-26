namespace ConsoleApp1
{
    public class Episodio
    {
        private List<string> Convidados = new();

        public Episodio(string titulo, int duracao, int ordem)
        {
            Titulo = titulo;
            Ordem = ordem;
            Duracao = duracao;
            
        }

        public int Duracao { get; set; }
        public int Ordem { get; set; }
        public string Titulo { get; set; }
        public string Resumo =>
            $"\n Duração: {Duracao}\n Ordem: {Ordem}\n Título: {Titulo}\n Convidado: {string.Join(", ", Convidados)}";

        public void AdicionarConvidado(string convidado)
        {
            Convidados.Add(convidado);
        }
    }
}
