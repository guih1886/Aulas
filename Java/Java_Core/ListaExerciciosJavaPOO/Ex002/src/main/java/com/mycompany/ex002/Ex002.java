package com.mycompany.ex002;

/*

Exercicio conta corrente, criar uma classe onde contenha os atributos número da
conta, nome do correntista e saldo. Com métodos para alterar o nome, depósito e 
saque.

 */
public class Ex002 {

    public static void main(String[] args) {

        //testando conta com saldo inicial
        ContaCorrente conta1 = new ContaCorrente(1000, 6514, ""
                + "Guilherme Henrique");
        conta1.deposito(150f);
        conta1.deposito(300f);
        conta1.saque(150f);
        System.out.println(conta1.toString());
        conta1.alterarNome("Pedro Miguel");
        System.out.println(conta1.toString());
        System.out.println("-----------------------------------------------");

        //testando conta sem saldo inicial
        ContaCorrente conta2 = new ContaCorrente(1346, "José");
        conta2.deposito(2000f);
        conta2.saque(2050);
        System.out.println(conta2.toString());
    }
}
