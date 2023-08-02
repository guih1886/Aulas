package com.mycompany.ex003;

public class BombaCombustivel {

    private String tipoCombustivel;
    private double valorLitro;
    private double qtdCombustivel;

    public BombaCombustivel(String tipoCombustivel, double valorLitro, double qtdCombustivel) {
        this.tipoCombustivel = tipoCombustivel;
        this.valorLitro = valorLitro;
        this.qtdCombustivel = qtdCombustivel;
    }

    public void abastecerPorValor(double valorAbastecimento) {
        double quantidade = 0;
        quantidade = valorAbastecimento / this.valorLitro;
        if (this.qtdCombustivel >= quantidade) {
            System.out.println("Litros abastecidos: " + quantidade + " L.");
            this.qtdCombustivel -= quantidade;
            System.out.println("Combustivel restante: " + this.qtdCombustivel);
        } else {
            System.out.println("Sem combutível suficiente.");
        }
    }

    public void abastecerPorLitro(double litrosAbastecimento) {
        if (litrosAbastecimento > this.qtdCombustivel) {
            System.out.println("Sem combutível suficiente.");
        } else {
            System.out.println("Valor a pagar: R$"
                    + (litrosAbastecimento * valorLitro) + " por " + litrosAbastecimento
                    + " litros.");
            this.qtdCombustivel -= litrosAbastecimento;
            System.out.println("Combustivel restante: " + this.qtdCombustivel);
        }
    }

    public void alterarValor(double novoValor) {
        this.valorLitro = novoValor;
        System.out.println("Valor do(a) " + tipoCombustivel + " alterado para R$"
                + this.valorLitro);
    }

    public void alterarTipoCombustivel(String novoTipoCombustivel) {
        this.tipoCombustivel = novoTipoCombustivel;
        System.out.println("Tipo do combustível alterado para " + this.tipoCombustivel);
    }

    public void alterarQtdCombustivel(double novoEstoque) {
        if (novoEstoque >= 0) {
            this.qtdCombustivel = novoEstoque;
            System.out.println("Estoque de " + tipoCombustivel + " alterado para "
                    + this.qtdCombustivel);
        } else {
            System.out.println("Quantidade negativa não permitida.");
        }
    }

}
