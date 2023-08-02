package com.mycompany.ex002;

public class ContaCorrente {

    private int numeroConta;
    private String nomeCorrentista;
    private float saldo = 0.0f;

    public ContaCorrente(int numeroConta, String nomeCorrentista) {
        this.numeroConta = numeroConta;
        this.nomeCorrentista = nomeCorrentista;
    }

    public ContaCorrente(float saldo, int numeroConta, String nomeCorrentista) {
        this.saldo = saldo;
        this.numeroConta = numeroConta;
        this.nomeCorrentista = nomeCorrentista;
    }

    public void alterarNome(String novoNome) {
        this.nomeCorrentista = novoNome;
    }

    public void deposito(float valorDeposito) {
        try {
            this.saldo += valorDeposito;
            System.out.println("Depósito de R$" + valorDeposito + " efetuado com sucesso.");
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }

    public void saque(float valorSaque) {
        try {
            if (valorSaque > saldo) {
                System.out.println("Saldo insuficiente.");
            } else {
                this.saldo -= valorSaque;
                System.out.println("Saque de R$" + valorSaque + " efetuado com sucesso.");
            }
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }

    @Override
    public String toString() {
        return "ContaCorrente{" + "numeroConta=" + numeroConta + ", nomeCorrentista=" + nomeCorrentista + ", saldo=" + saldo + '}';
    }

}
