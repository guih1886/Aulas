package com.mycompany.ex16;

import java.util.Scanner;

public class Ex16 {

    public static void main(String[] args) {
        String nome;
        float notas;
        Scanner leitor = new Scanner(System.in);

        System.out.print("Informe o nome do aluno: ");
        nome = leitor.next();
        int i = 0;
        for (; i < 3; i++) {
            System.out.print("Informe o nomã do aluno: ");
            nome = leitor.next();
        }
    }
}
