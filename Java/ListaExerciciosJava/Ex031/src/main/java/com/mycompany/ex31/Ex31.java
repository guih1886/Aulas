package com.mycompany.ex31;

import java.util.Scanner;

public class Ex31 {

    public static void main(String[] args) {
        float A = 0.0f;
        float B = 0.0f;
        char C;
        Scanner leitor = new Scanner(System.in);

        System.out.print("Digite o valor A: ");
        A = leitor.nextFloat();
        System.out.print("Digite o valor B: ");
        B = leitor.nextFloat();
        System.out.print("Digite o operador: ");
        C = leitor.next().charAt(0);

        //se a divisor for 0, o sistema cai no else
        if (B != 0) {
            switch (C) {
                case '-':
                    System.out.println(A - B);
                    break;
                case '+':
                    System.out.println(A + B);
                    break;
                case '*':
                    System.out.println(A * B);
                    break;
                case '/':
                    System.out.println(A / B);
                    break;
                case '%':
                    System.out.println(A % B);
                    break;
                default:
                    System.out.println("Operador inválido.");
            }
        } else {
            System.out.println("Divisão por zero!");
        }
    }
}
