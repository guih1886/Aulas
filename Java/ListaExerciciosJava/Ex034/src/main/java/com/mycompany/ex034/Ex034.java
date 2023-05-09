package com.mycompany.ex034;

import java.util.Scanner;

public class Ex034 {

    public static void main(String[] args) {
        int idade;
        Scanner leitor = new Scanner(System.in);

        System.out.println("Digite sua idade: ");

        idade = leitor.nextInt();
        if (idade >= 5 && idade <= 7) {
            System.out.println("Infantil A");
        }
        if (idade >= 8 && idade <= 10) {
            System.out.println("Infantil B");
        }
        if (idade >= 11 && idade <= 13) {
            System.out.println("Juvenil A");
        }
        if (idade >= 14 && idade <= 17) {
            System.out.println("Juvenil B");
        }
        if (idade >= 18 && idade <= 25) {
            System.out.println("Senior");
        }
        if ((idade >= 0 && idade < 5) || idade >= 26) {
            System.out.println("Idade fora da faixa.");
        }
        leitor.close();
    }
}
