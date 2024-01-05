using Alura.ByteBank.Infraestrutura.Testes.Servico.DTO;

namespace Alura.ByteBank.Infraestrutura.Testes.Servico;

public interface IPixRepositorio
{
    public PixDTO consultaPix(Guid pix);
}