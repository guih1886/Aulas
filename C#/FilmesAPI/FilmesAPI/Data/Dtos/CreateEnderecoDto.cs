using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class CreateEnderecoDto
{
    [Required(ErrorMessage = "O logradouro do endereço é obrigatório")]
    public string Logradouro { get; set; }
    [Required]
    public int Numero { get; set; }
}
