using FilmesAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class UpdateFilmeDto
{
    [Required(ErrorMessage = "O título do filme é obrigatório.")]
    public string? Titulo { get; set; }

    [Required(ErrorMessage = "O genero do filme é obrigatório.")]
    public Genero Genero { get; set; }

    [Required(ErrorMessage = "A duração do filme é obrigatório.")]
    [Range(70, 600, ErrorMessage = "A duração deve ser entre 70 e 600 minutos.")]
    public int Duracao { get; set; }
}
