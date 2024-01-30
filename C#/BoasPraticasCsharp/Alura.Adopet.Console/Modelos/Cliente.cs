namespace Alura.Adopet.Console.Modelos;

public class Cliente
{

    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string? CPF { get; set; }
    public Cliente(Guid id, string nome, string email, string? Cpf)
    {
        Id = id;
        Nome = nome;
        Email = email;
        CPF = Cpf;
    }

    public override string? ToString()
    {
        return $"{Id} - {Nome} - {Email}";
    }
}
