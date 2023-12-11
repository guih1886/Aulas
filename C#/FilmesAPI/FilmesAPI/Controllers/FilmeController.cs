using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{

    [HttpPost]
    public IActionResult AdicionarFilme([FromBody] Filme filme)
    {
        Filme.Filmes.Add(filme);
        return CreatedAtAction(nameof(GetFilme), new { id = filme.Id }, filme);
    }

    [HttpGet]
    public IEnumerable<Filme> ListarFilmes()
    {
        return Filme.Filmes;
    }

    [HttpGet("{id}")]
    public IActionResult GetFilme(int id)
    {
        var filme = Filme.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        return Ok(filme);
    }
}