package com.mycompany.ex17;

import java.util.Scanner;

public class Ex17 {

    public static void main(String[] args) {
        int contador = 0;
        float numero = 0.0f;
        Scanner leitor = new Scanner(System.in);

        for (int i = 0; i < 80; i++) {
            System.out.print("Informe o número " + (i + 1) + ": ");
            numero = leitor.nextFloat();
            if (numero >= 10 && numero <= 150) {
                contador++;
            }
        }
        System.out.print("Quantidade de números entre 10 e 150: " + contador);
    }
}
