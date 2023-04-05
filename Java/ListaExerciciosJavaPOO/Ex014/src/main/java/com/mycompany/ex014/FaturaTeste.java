package com.mycompany.ex014;

/**
 *
 *
 */
public class FaturaTeste {

    public static void main(String[] args) {
        //populando uma fatura
        Fatura fatura1 = new Fatura("1", "Televisão LG", 2, 500.99);
        Fatura fatura2 = new Fatura("2", "Rádio", 2, -500);
        Fatura fatura3 = new Fatura("3", "Pneu 17", 0, 1500);
        Fatura fatura4 = new Fatura("4", "Fogão", -1, 500.99);
        //exibindo os resultados
        System.out.println("Valor do produto " + fatura1.getDescricao() + ": R$" + fatura1.getTotalFatura());
        System.out.println("Valor do produto " + fatura2.getDescricao() + ": R$" + fatura2.getTotalFatura());
        System.out.println("Valor do produto " + fatura3.getDescricao() + ": R$" + fatura3.getTotalFatura());
        System.out.println("Valor do produto " + fatura4.getDescricao() + ": R$" + fatura4.getTotalFatura());

    }
}
