package Ex12;

import java.util.Scanner;

public class App {

    public static void main(String[] args) {
        float custoCarro = 0;
        float percentualImposto = 0.45f;
        float percentualDistribuidor = 0.28f;
        Scanner leitor = new Scanner(System.in);

        System.out.print("Informe o valor de custo do carro: ");
        custoCarro = leitor.nextFloat();
        custoCarro = custoCarro + (custoCarro * percentualImposto);
        custoCarro = custoCarro + (custoCarro * percentualDistribuidor);

        System.out.print("Valor do carro ao consumidor: " + custoCarro);
    }
}