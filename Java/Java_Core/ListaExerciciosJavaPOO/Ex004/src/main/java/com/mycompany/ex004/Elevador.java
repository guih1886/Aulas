package com.mycompany.ex004;

public class Elevador {

    private int andarAtual = 0;
    private int totalAndares = 0;
    private int capacidade = 0;
    private int lotacao = 0;

    public void inicializa(int capacidade, int totalAndares) {
        this.totalAndares = totalAndares;
        this.capacidade = capacidade;
    }

    public void entra(int qtdPessoas) {
        if (qtdPessoas <= (this.capacidade - this.lotacao)) {
            System.out.println("Entrou " + qtdPessoas + " no elevador.");
            this.lotacao += qtdPessoas;
        } else if ((this.capacidade - this.lotacao) == 0) {
            System.out.println("Sem espaço, elevador cheio.");
        } else {
            System.out.println("Sem espaço, pode-se entrar " + (this.capacidade - this.lotacao) + " pessoas.");
        }
    }

    public void sai(int qtdPessoas) {
        if (qtdPessoas <= this.lotacao) {
            System.out.println("Saiu " + qtdPessoas + " pessoas.");
            this.lotacao -= qtdPessoas;
        } else if (qtdPessoas > this.lotacao) {
            System.out.println("Sem pessoas suficiente no elevador.");
        }
    }

    public void sobe(int subir) {
        if (andarAtual == totalAndares) {
            System.out.println("Já está no último andar.");
        } else if (subir > totalAndares) {
            System.out.println("Só temos " + totalAndares + " andares!");
        } else if ((andarAtual + subir) > totalAndares) {
            System.out.println("Não temos tudo isso de andares.");
        } else {
            andarAtual += subir;
            System.out.println("Subiu para o andar " + andarAtual);
        }

    }

    public void desce(int descer) {
        if (andarAtual == 0) {
            System.out.println("Já estamos no térreo.");
        } else if (descer <= andarAtual) {
            andarAtual -= descer;
            System.out.println("Desceu para o andar " + andarAtual);
        } else {
            System.out.println("Não temos como descer tudo isso.");
        }

    }

}
