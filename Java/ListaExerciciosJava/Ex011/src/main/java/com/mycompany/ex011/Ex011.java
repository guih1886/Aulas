package com.mycompany.ex011;

import java.util.Scanner;

public class Ex011 {

    public static void main(String[] args) {
        float valorCusto;
        float margem;
        float valorVenda;
        Scanner leitor = new Scanner(System.in);

        System.out.print("Informe o valor de custo: ");
        valorCusto = leitor.nextFloat();
        System.out.print("Informe margem de venda: ");
        margem = leitor.nextFloat() / 100;

        valorVenda = valorCusto + (valorCusto * margem);
        System.out.print("Valor de venda: " + valorVenda);

    }
}
