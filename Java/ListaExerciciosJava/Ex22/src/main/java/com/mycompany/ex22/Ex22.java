package com.mycompany.ex22;

import java.util.Scanner;

public class Ex22 {

    public static void main(String[] args) {

        String nomeProduto;
        float precoCusto;
        float precoVenda;
        float custoTotal = 0;
        float vendaTotal = 0;
        int qtdProdutos = 0;
        Scanner leitor = new Scanner(System.in);

        System.out.print("Informe quantos produtos vai cadastrar: ");
        qtdProdutos = leitor.nextInt();

        for (int i = 0; i < qtdProdutos; i++) {
            System.out.print("Informe a descrição do produto: ");
            nomeProduto = leitor.next();

            System.out.print("Informe o custo do produto: ");
            precoCusto = leitor.nextFloat();

            System.out.print("Informe a venda do produto: ");
            precoVenda = leitor.nextFloat();

            if (precoCusto == precoVenda) {
                System.out.println("Ouve um Empate");
            } else {
                if (precoCusto > precoVenda) {
                    System.out.println("Tivemos Prejuizo");
                } else {
                    System.out.println("Tivemos Lucro");
                }
            }

            custoTotal += precoCusto;
            vendaTotal += precoVenda;
        }
        System.out.println("Custo médio dos produtos: " + custoTotal / qtdProdutos);
        System.out.println("Venda média dos produtos: " + vendaTotal / qtdProdutos);

    }
}
