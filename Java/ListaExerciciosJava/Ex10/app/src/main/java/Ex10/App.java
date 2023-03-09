package Ex10;

import java.util.Scanner;

public class App {

    public static void main(String[] args) {
        float valorCompra;
        Scanner leitor = new Scanner(System.in);

        System.out.print("Informe o valor de compra: ");
        valorCompra = leitor.nextFloat();

        System.out.print("Valor das prestacoes: " + valorCompra / 5);
    }
}
