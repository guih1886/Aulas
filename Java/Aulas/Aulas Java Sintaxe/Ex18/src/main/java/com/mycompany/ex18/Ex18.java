package com.mycompany.ex18;

import java.util.Scanner;

public class Ex18 {

    public static void main(String[] args) {
        int idade;
        Scanner leitor = new Scanner(System.in);

        for (int i = 0; i < 75; i++) {
            System.out.print("Informe a idade da pessoa: ");
            idade = leitor.nextInt();

            if (idade >= 18) {
                System.out.println("Maior de idade.");
            } else {
                System.out.println("Menor de idade.");
            }
        }
    }
}
