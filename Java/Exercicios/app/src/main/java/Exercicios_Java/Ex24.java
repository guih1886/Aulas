package Exercicios_Java;
//verificar se um número passado é zero, positivo ou negativo.

import java.util.Scanner;

public class Ex24 {

    public static void main(String[] args) {
        Scanner leitor = new Scanner(System.in);

        char Continue = 'S';
        int numero;

        while (Continue == 's' || Continue == 'S') {
            System.out.print("Digite um numero: ");
            numero = leitor.nextInt();
            if (numero == 0) {
                System.out.println("O número é zero.");
            } else {
                if (numero > 0) {
                    System.out.println("O número é positivo.");
                } else {
                    System.out.println("O número é negativo.");
                }
            }
            System.out.print("Deseja continuar? S/N ");
            Continue = leitor.next().charAt(0);
        }
        System.out.print("Obrigado por jogar!");
    }
}