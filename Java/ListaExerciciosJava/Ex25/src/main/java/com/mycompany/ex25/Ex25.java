package com.mycompany.ex25;

import java.util.Scanner;

public class Ex25 {

    public static void main(String[] args) {
        int valorA = 0;
        int valorB = 0;
        Scanner leitor = new Scanner(System.in);

        System.out.print("Informe o valor A: ");
        valorA = leitor.nextInt();
        System.out.print("Informe o valor B: ");
        valorB = leitor.nextInt();

        if (valorA == valorB) {
            System.out.print("Os valores são iguais.");
        } else {
            System.out.println("Os valores são diferentes.");
            if (valorA > valorB) {
                System.out.print("Valor A maior que valor B.");
            } else {
                System.out.print("Valor B maior que valor A.");
            }
        }
    }
}
