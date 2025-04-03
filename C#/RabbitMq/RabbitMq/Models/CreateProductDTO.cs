namespace RabbitMq.Models;

public class CreateProductDTO
{
    public string Descricao { get; set; } = string.Empty;
    public string Tipo { get; set; } = string.Empty;
    public double Valor { get; set; }
    public DateTime DataCadastro { get; set; } = DateTime.Now;
}
