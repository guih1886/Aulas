package com.mycompany.ex001;

import java.util.Scanner;

public class Ex1 {

    public static void main(String[] args) {
        float n1;
        float n2;
        float result;
        Scanner leitor = new Scanner(System.in);

        System.out.print("Digite o numero 1: ");
        n1 = leitor.nextInt();
        System.out.print("Digite o numero 2: ");
        n2 = leitor.nextInt();
        result = n1 + n2;
        System.out.print("Resultado: " + result);
    }
}
