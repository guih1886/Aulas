package com.mycompany.ex006;

import java.util.Scanner;

public class Ex006 {

    public static void main(String[] args) {
        int valorA;
        int valorB;
        int aux;
        Scanner leitor = new Scanner(System.in);

        System.out.print("Digite o valor A: ");
        valorA = leitor.nextInt();
        System.out.print("Digite o valor B: ");
        valorB = leitor.nextInt();
        aux = valorA;
        valorA = valorB;
        valorB = aux;

        System.out.print("Valor A: " + valorA + " | Valor B: " + valorB);
        leitor.close();
    }
}
