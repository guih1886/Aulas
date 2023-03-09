package Ex13;

import java.util.Scanner;

public class App {

    public static void main(String[] args) {
        float n1;
        Scanner leitor = new Scanner(System.in);

        System.out.print("Digite o numero: ");
        n1 = leitor.nextInt();

        if (n1 > 10) {
            System.out.print("Maior que 10!");
        }

    }
}
