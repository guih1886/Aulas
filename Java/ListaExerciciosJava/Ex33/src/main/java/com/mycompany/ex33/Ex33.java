package com.mycompany.ex33;

import java.util.Scanner;

public class Ex33 {

    public static void main(String[] args) {
        int nivel;
        float qtdHorasTrabalhadas = 0.0f;
        Scanner leitor = new Scanner(System.in);

        System.out.print("Digite o seu nível (1 | 2 | 3): ");
        nivel = leitor.nextInt();

        switch (nivel) {
            case 1:
                System.out.print("Digite a quantidade de horas "
                        + "trabalhadas: ");
                qtdHorasTrabalhadas = leitor.nextFloat();
                System.out.println("Salário: R$ " + qtdHorasTrabalhadas * 12);
                break;
            case 2:
                System.out.print("Digite a quantidade de horas "
                        + "trabalhadas: ");
                qtdHorasTrabalhadas = leitor.nextFloat();
                System.out.println("Salário: R$ " + qtdHorasTrabalhadas * 17);
                break;
            case 3:
                System.out.print("Digite a quantidade de horas "
                        + "trabalhadas: ");
                qtdHorasTrabalhadas = leitor.nextFloat();
                System.out.println("Salário: R$ " + qtdHorasTrabalhadas * 25);
                break;
            default:
                System.out.println("Nível inválido.");
        }

    }
}
