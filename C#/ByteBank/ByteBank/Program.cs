using bytebank.Modelos.Conta;
using ByteBank.Util;

void TestaArrayDeContaCorrente()
{
    ListaDeContaCorrente listaDeContas = new ListaDeContaCorrente();

    listaDeContas.Adicionar(new ContaCorrente(874));
    listaDeContas.Adicionar(new ContaCorrente(974));
    listaDeContas.Adicionar(new ContaCorrente(1074));
    Console.WriteLine(listaDeContas.ContarContas());
}


TestaArrayDeContaCorrente();