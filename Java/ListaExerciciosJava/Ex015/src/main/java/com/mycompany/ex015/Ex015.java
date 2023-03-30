package com.mycompany.ex015;

import java.util.Scanner;

public class Ex015 {

    public static void main(String[] args) {
        float n1;
        Scanner leitor = new Scanner(System.in);

        System.out.print("Digite um numero: ");
        n1 = leitor.nextFloat();

        if (n1 >= 100 && n1 <= 200) {
            System.out.print("Esta entre 100 e 200");
        } else {
            System.out.print("Nao esta entre 100 e 200");
        }
    }
}
