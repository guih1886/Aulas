using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class ReadEnderecoDto
{
    public int Id { get; set; }
    [Required(ErrorMessage = "O logradouro do endereço é obrigatório")]
    public string Logradouro { get; set; }
    [Required]
    public int Numero { get; set; }
}
