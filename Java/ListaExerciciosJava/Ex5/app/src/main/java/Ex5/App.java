package Ex5;

import java.util.Scanner;

public class App {

    public static void main(String[] args) {

        float notas = 0.0f;
        Scanner leitor = new Scanner(System.in);
        int i = 0;
        for (; i < 3; i++) {
            System.out.print("Digite a nota " + (i+1) + ": ");
            notas += leitor.nextFloat();
        }
        System.out.print("Media: " + notas / i);
    }
}
