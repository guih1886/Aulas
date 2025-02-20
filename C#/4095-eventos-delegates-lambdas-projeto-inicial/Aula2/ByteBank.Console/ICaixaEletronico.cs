using ByteBank.Console.Eventos;

public delegate void SaldoInsuficienteEventHandler(object? sender, SaldoInsuficienteEventArgs e, string msg);

public interface ICaixaEletronico
{
    void Saldo();
    void Extrato();
    void Depositar(decimal valor);
    void Sacar(decimal valor);
    void AplicarPoupanca(decimal valor);

    event SaldoInsuficienteEventHandler? OnSaldoInsuficiente;
}