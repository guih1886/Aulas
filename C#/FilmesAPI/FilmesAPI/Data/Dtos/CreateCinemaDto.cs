﻿using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class CreateCinemaDto
{
    [Required(ErrorMessage = "O campo do nome é obrigatório")]
    public string Nome { get; set; }
    [Required(ErrorMessage = "O id do endereço do cinema é obrigatório")]
    public int EnderecoId { get; set; }
}
