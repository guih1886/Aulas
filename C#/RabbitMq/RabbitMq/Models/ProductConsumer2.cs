namespace RabbitMq.Models;

public class ProductConsumer2
{
    public Guid Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public string Tipo { get; set; } = string.Empty;
    public double Valor { get; set; }
    public DateTime DataCadastro { get; set; } = DateTime.MinValue;
}
