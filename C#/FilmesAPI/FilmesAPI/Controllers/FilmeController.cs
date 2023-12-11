using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{

    [HttpPost]
    public void AdicionarFilme([FromBody] Filme filme)
    {
        Filme.Filmes.Add(filme);
        Console.WriteLine(filme.Titulo);
        Console.WriteLine(filme.Genero);
        Console.WriteLine(filme.Duracao);
    }

    [HttpGet]
    public List<Filme> ListarFilmes()
    {
        return Filme.Filmes.ToList();
    }
}