package com.mycompany.ex26;

import java.util.Scanner;

public class Ex26 {

    public static void main(String[] args) {
        int num;
        Scanner leitor = new Scanner(System.in);

        System.out.print("Digite o número para escreve-lo por extenso: ");
        num = leitor.nextInt();

        switch (num) {
            case 1:
                System.out.println("Um");
                break;
            case 2:
                System.out.println("Dois");
                break;
            case 3:
                System.out.println("Três");
                break;
            case 4:
                System.out.println("Quatro");
                break;
            case 5:
                System.out.println("Cinco");
                break;
            default:
                System.out.println("Número inválido.");
        }
    }
}
