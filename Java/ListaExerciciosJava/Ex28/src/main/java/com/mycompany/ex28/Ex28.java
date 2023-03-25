package com.mycompany.ex28;

import java.util.Scanner;

public class Ex28 {

    public static void main(String[] args) {
        String nome;
        float salario = 0.0f;
        float salarioMin = 0.0f;
        float reajuste = 0.0f;
        float aumentoDaFolha = 0.0f;
        Scanner leitor = new Scanner(System.in);

        System.out.print("Digite o salário minímo atual: ");
        salarioMin = leitor.nextFloat();

        for (int i = 0; i < 584; i++) {
            System.out.println("Digite seu nome: ");
            nome = leitor.next();
            System.out.println("Digite seu salário: ");
            salario = leitor.nextFloat();

            if (salario < (salarioMin * 3)) {
                reajuste = salario * 0.50f;
            }
            if (salario >= (salarioMin * 3) && salario <= (salarioMin * 10)) {
                reajuste = salario * 0.20f;
            }
            if (salario > (salarioMin * 1) && salario <= (salarioMin * 20)) {
                reajuste = salario * 0.15f;
            }
            if (salario > (salarioMin * 20)) {
                reajuste = salario * 0.10f;
            }

            System.out.println("Nome: " + nome);
            System.out.println("Reajuste: " + reajuste);
            System.out.println("Novo salário: " + (salario + reajuste));
            aumentoDaFolha += reajuste;
            System.out.println("-----------------------------");
            System.out.println("Valor total de reajuste na folha de pagamento:"
                    + " " + aumentoDaFolha);
        }
    }
}
