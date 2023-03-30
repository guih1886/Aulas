package com.mycompany.ex008;

import java.util.Scanner;

public class Ex008 {

    public static void main(String[] args) {
        float cotacaoDolar;
        float qtdDolar;
        Scanner leitor = new Scanner(System.in);

        System.out.print("Cotacao do dolar: ");
        cotacaoDolar = leitor.nextFloat();
        System.out.print("Quantidade em dolares: ");
        qtdDolar = leitor.nextFloat();

        System.out.print("Quantidade em reais: " + qtdDolar * cotacaoDolar);
    }
}
