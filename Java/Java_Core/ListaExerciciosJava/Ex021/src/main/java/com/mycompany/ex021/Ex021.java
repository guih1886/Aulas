package com.mycompany.ex021;

import java.util.Scanner;

public class Ex021 {

    public static void main(String[] args) {
        String nome;
        char sexo;
        int idade;
        String saude;
        int contadorAptos = 0;
        int contadorNaoAptos = 0;
        Scanner leitor = new Scanner(System.in);
        char Continue = 'S';

        while (Continue == 's' || Continue == 'S') {
            System.out.println("Informe seu nome: ");
            nome = leitor.next();
            System.out.println("Informe seu sexo (F/M): ");
            sexo = leitor.next().charAt(0);
            System.out.println("Informe sua idade: ");
            idade = leitor.nextInt();
            System.out.println("Informe sua saúde: ");
            saude = leitor.next();
            leitor.close();
            if (sexo == 'm' || sexo == 'M') {
                if (idade >= 18) {
                    contadorAptos++;
                } else {
                    contadorNaoAptos++;
                }
            } else {
                contadorNaoAptos++;
            }
            System.out.println("Quantidade de pessoas aptas: " + contadorAptos);
            System.out.println("Quantidade de pessoas não aptas: " + contadorNaoAptos);
            System.out.println("Nome: +" + nome + " | Saude: " + saude);
        }
        System.out.print("Obrigado por jogar!");
    }
}
