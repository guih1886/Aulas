package Exercicios;
//Verificar se um número está entre 100 e 200

import java.util.Scanner;

public class Ex15 {

    public static void main(String[] args) {
        int numero = 0;
        Scanner leitor = new Scanner(System.in);
        System.out.print("Digite o numero: ");
        numero = leitor.nextInt();

        if (numero >= 100 && numero <= 200) {
            System.out.println("Esta entre 100 e 200");
        } else {
            System.out.println("Nao esta entre 100 e 200");
        }
    }
}
