using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        // Lista de filmes
        public static List<Filme> Filmes = new List<Filme>
       {
            new Filme { Id = 1, Titulo = "Filme 1", Genero = Genero.DRAMA, Duracao = 120 },
            new Filme { Id = 2, Titulo = "Filme 2", Genero = Genero.TERROR, Duracao = 95 },
            new Filme { Id = 3, Titulo = "Filme 3", Genero = Genero.SUSPENSE, Duracao = 95 },
            new Filme { Id = 4, Titulo = "Filme 4", Genero = Genero.DOCUMENTARIO, Duracao = 95 },
            new Filme { Id = 5, Titulo = "Filme 5", Genero = Genero.DOCUMENTARIO, Duracao = 95 },
            new Filme { Id = 6, Titulo = "Filme 6", Genero = Genero.FICCAO, Duracao = 95 },
        };
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O título do filme é obrigatório.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O genero do filme é obrigatório.")]
        public Genero Genero { get; set; }

        [Required(ErrorMessage = "A duração do filme é obrigatório.")]
        [Range(70, 600, ErrorMessage = "A duração deve ser entre 70 e 600 minutos.")]
        public int Duracao { get; set; }
    }
}
