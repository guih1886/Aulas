package com.mycompany.ex007;

import java.util.Scanner;

public class Ex007 {

    public static void main(String[] args) {
        float C;
        float F;
        Scanner leitor = new Scanner(System.in);

        System.out.print("Digite a temperatura em Celsius: ");
        C = leitor.nextFloat();
        F = ((9 * C) + 160) / 5;

        System.out.print("Temperatura em Fahrenheit: " + F);
        leitor.close();
    }
}
