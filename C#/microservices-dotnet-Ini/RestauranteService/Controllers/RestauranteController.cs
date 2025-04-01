using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestauranteService.Data;
using RestauranteService.Dtos;
using RestauranteService.ItemServiceHttpClient;
using RestauranteService.Models;
using RestauranteService.RabbitMqClient;
using System.Text.Json.Serialization;

namespace RestauranteService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RestauranteController : ControllerBase
{
    private readonly IRestauranteRepository _repository;
    private readonly IMapper _mapper;
    private IItemServiceHttpClient _itemServiceHttpClient;
    private AwsSqs _awsClient;

    public RestauranteController(
        IRestauranteRepository repository,
        IMapper mapper, IItemServiceHttpClient itemServiceHttpClient, AwsSqs awsClient)
    {
        _repository = repository;
        _mapper = mapper;
        _itemServiceHttpClient = itemServiceHttpClient;
        _awsClient = awsClient;
    }

    [HttpGet]
    public ActionResult<IEnumerable<RestauranteReadDto>> GetAllRestaurantes()
    {

        var restaurantes = _repository.GetAllRestaurantes();

        return Ok(_mapper.Map<IEnumerable<RestauranteReadDto>>(restaurantes));
    }

    [HttpGet("{id}", Name = "GetRestauranteById")]
    public ActionResult<RestauranteReadDto> GetRestauranteById(int id)
    {
        var restaurante = _repository.GetRestauranteById(id);
        if (restaurante != null)
        {
            return Ok(_mapper.Map<RestauranteReadDto>(restaurante));
        }

        return NotFound();
    }

    [HttpDelete("{id}", Name = "DeleteRestauranteById")]
    public ActionResult<RestauranteReadDto> DeleteRestauranteById(int id)
    {
        Restaurante restaurante = _repository.GetRestauranteById(id);
        _repository.DeleteRestauranteById(restaurante);
        return NoContent();
    }

    [HttpPost]
    public async Task<ActionResult<RestauranteReadDto>> CreateRestaurante(RestauranteCreateDto restauranteCreateDto)
    {
        var restaurante = _mapper.Map<Restaurante>(restauranteCreateDto);
        _repository.CreateRestaurante(restaurante);
        _repository.SaveChanges();

        var restauranteReadDto = _mapper.Map<RestauranteReadDto>(restaurante);

        //_rabbitMqClient.PublicaRestaurante(restauranteReadDto);
        await _awsClient.SendMessageAsync(JsonConvert.SerializeObject(restauranteReadDto));

        return CreatedAtRoute(nameof(GetRestauranteById), new { restauranteReadDto.Id }, restauranteReadDto);
    }
}
