using bytebank.Modelos.Conta;

namespace ByteBank.Util;

public class ListaDeContaCorrente
{
    private ContaCorrente[] _items = new ContaCorrente[] { };

    public ListaDeContaCorrente(int tamanhoInicial = 5)
    {
        _items = new ContaCorrente[tamanhoInicial];
    }

    public void Adicionar(ContaCorrente conta)
    {
        _items.Append(conta);
    }
    
    public void Remover(ContaCorrente conta)
    {
        //_items.Select(conta => conta == conta);

    }

    public int ContarContas()
    {
        return _items.Length;
    }
}
