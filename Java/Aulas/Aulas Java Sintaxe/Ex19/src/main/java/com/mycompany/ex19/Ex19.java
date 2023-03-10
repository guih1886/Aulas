package com.mycompany.ex19;

import java.util.Scanner;

public class Ex19 {

    public static void main(String[] args) {
        String nome;
        char sexo;
        int contadorMulheres = 0;
        int contadorHomens = 0;
        Scanner leitor = new Scanner(System.in);

        for (int i = 0; i < 3; i++) {
            System.out.print("Informe seu nome: ");
            nome = leitor.next();
            System.out.print("Informe seu sexo M - Masculino | F - Feminino: ");
            sexo = leitor.next().charAt(0);
            if (sexo == 'M' || sexo == 'm') {
                System.out.println(nome + " é um homem.");
                contadorHomens++;
            } else {
                System.out.println(nome + " é uma mulher.");
                contadorMulheres++;
            }
        }
        System.out.println("Quantidade de homens: " + contadorHomens);
        System.out.print("Quantidade de mulheres: " + contadorMulheres);
    }
}
