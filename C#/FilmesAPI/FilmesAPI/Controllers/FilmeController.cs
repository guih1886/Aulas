using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using FilmesAPI.Data;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private FilmeContext _context;

    public FilmeController(FilmeContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult AdicionarFilme([FromBody] Filme filme)
    {
        _context.Filmes.Add(filme);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetFilme), new { id = filme.Id }, filme);
    }

    [HttpGet]
    public IEnumerable<Filme> ListarFilmes()
    {
        return _context.Filmes;
    }

    [HttpGet("{id}")]
    public IActionResult GetFilme(int id)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        return Ok(filme);
    }
}