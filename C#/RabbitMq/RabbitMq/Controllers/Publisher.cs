using Microsoft.AspNetCore.Mvc;
using RabbitMq.Data.Repository;
using RabbitMq.Models;
using RabbitMq.Services;
using System.Text.Json;

namespace RabbitMq.Controllers;

[ApiController]
[Route("[controller]")]
public class Publisher : ControllerBase
{
    private ProductRepository _productRepository;

    public Publisher(ProductRepository productRepository)
    {
        _productRepository = productRepository;
    }


    [HttpPost]
    public async Task<IActionResult> CreateProduct([FromBody] CreateProductDTO produtoDTO)
    {
        var service = await RabbitMqPublishService.CreateAsync();
        var produto = new Product
        {
            Descricao = produtoDTO.Descricao,
            Tipo = produtoDTO.Tipo,
            Valor = produtoDTO.Valor,
            DataCadastro = produtoDTO.DataCadastro
        };

        await _productRepository.CreateProduct(produto);

        await service.PublishMessageAsync(
           exchange: "produtos",
           queue: "createdProducts",
           JsonSerializer.Serialize(produto));

        return Ok();
    }
}
