package com.mycompany.ex16;

import java.util.Scanner;

public class Ex16 {

    public static void main(String[] args) {
        String nome;
        float notas = 0.0f;
        Scanner leitor = new Scanner(System.in);

        System.out.print("Informe o nome do aluno: ");
        nome = leitor.next();
        int i = 0;
        for (; i < 3; i++) {
            System.out.print("Informe a nota do aluno " + (i + 1) + ": ");
            notas += leitor.nextFloat();
        }
        notas = notas / i;

        if (notas >= 7) {
            System.out.print("Aprovado");
        } else {
            if (notas >= 5.1 && notas <= 6.9) {
                System.out.print("Recuperação");
            } else {
                System.out.print("Reprovado");
            }
        }
    }
}
