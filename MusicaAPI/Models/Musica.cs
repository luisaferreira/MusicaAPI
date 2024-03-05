namespace MusicaAPI.Models
{
    public class Musica
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public string Genero { get; set; }
        public DateTime DataLancamento { get; set; }
        public string Album { get; set; }
        public string Gravadora { get; set; }

        public Musica(string titulo, string artista, string genero,
            DateTime dataLancamento, string album, string gravadora)
        {
            this.Titulo = titulo;
            this.Artista = artista;
            this.Genero = genero;
            this.DataLancamento = dataLancamento;
            this.Album = album;
            this.Gravadora = gravadora;
        }
    }
}
