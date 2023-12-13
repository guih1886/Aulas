using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
using AutoMapper;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private FilmeContext _context;
    private IMapper _mapper;

    public FilmeController(FilmeContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionarFilme([FromBody] CreateFilmeDto filmeDto)
    {
        Filme filme = _mapper.Map<Filme>(filmeDto);
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