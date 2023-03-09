package Ex2;

import java.util.Scanner;

public class App {

    public static void main(String[] args) {
        float n1;
        float n2;
        float soma;
        float subtracao;
        float multiplicacao;
        float divisao;
        Scanner leitor = new Scanner(System.in);

        System.out.print("Digite o numero 1: ");
        n1 = leitor.nextFloat();
        System.out.print("Digite o numero 2: ");
        n2 = leitor.nextFloat();
        soma = n1 + n2;
        System.out.println("Soma: " + soma);
        subtracao = n1 - n2;
        System.out.println("Subtracao: " + subtracao);
        multiplicacao = n1 * n2;
        System.out.println("Multiplicacao: " + multiplicacao);
        divisao = n1 / n2;
        System.out.println("Divisao: " + divisao);
    }
}
