package Ex14;

import java.util.Scanner;

public class App {

    public static void main(String[] args) {
        float n1;
        float n2;
        Scanner leitor = new Scanner(System.in);

        System.out.print("Digite o numero 1: ");
        n1 = leitor.nextInt();
        System.out.print("Digite o numero 2: ");
        n2 = leitor.nextInt();

        if (n1 > n2) {
            System.out.print("Numero 1 e maior que o 2!");
        } else {
            System.out.print("Numero 2 e maior que o 1!");
        }

    }
}
