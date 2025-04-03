using Microsoft.AspNetCore.Mvc;
using RabbitMq.Data.Repository;
using RabbitMq.Services;

namespace RabbitMq.Controllers;

[ApiController]
[Route("[controller]")]
public class Consumer : ControllerBase
{
    private ProductRepository _productRepository;
    public Consumer(ProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetConsumer1()
    {
        var service = await RabbitMqPublishService.CreateAsync();
        var produto = await service.ConsumeAsync("createdProducts");
        await _productRepository.AddProductToConsumer(produto);
        return Ok("Produto salvo para o consumidor 1 com sucesso.");
    }

}
