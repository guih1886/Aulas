namespace ByteBank.Console.Eventos;

public class SaldoInsuficienteEventArgs : EventArgs
{
    public decimal Saldo { get; set; }
    public decimal Saque { get; set; }

    public SaldoInsuficienteEventArgs(decimal saldo, decimal saque)
    {
        Saldo = saldo;
        Saque = saque;
    }
}
