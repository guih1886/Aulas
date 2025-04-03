using RabbitMq.Models;

namespace RabbitMq.Data.Repository;

public class ProductRepository
{
    private AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task CreateProduct(Product product)
    {
        try
        {
            _context.Product.Add(product);
            await _context.SaveChangesAsync();
        }
        catch (Exception)
        {
            Console.WriteLine("Erro ao adicionar o produto.");
        }

    }

    public async Task AddProductToConsumer(Product produto)
    {
        ProductConsumer produtoConsumer = new ProductConsumer
        {
            Id = produto.Id,
            Descricao = produto.Descricao,
            Tipo = produto.Tipo,
            Valor = produto.Valor,
            DataCadastro = produto.DataCadastro
        };

        _context.ProductsConsumer.Add(produtoConsumer);
        await _context.SaveChangesAsync();
    }
}
