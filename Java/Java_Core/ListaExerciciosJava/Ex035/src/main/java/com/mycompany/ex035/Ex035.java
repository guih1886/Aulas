package com.mycompany.ex035;

import java.util.Scanner;

public class Ex035 {

    public static void main(String[] args) {
        int tipoCliente;
        float qtdHoras;
        Scanner leitor = new Scanner(System.in);

        System.out.print("Digite o tipo do cliente (1 - Residêncial | "
                + "2 - Comercial | 3 - Industrial): ");
        tipoCliente = leitor.nextInt();

        switch (tipoCliente) {
            case 1:
                System.out.print("Quantidade de horas utilizadas: ");
                qtdHoras = leitor.nextFloat();
                System.out.println("Valor da conta: R$" + qtdHoras * 0.60f);
                break;
            case 2:
                System.out.print("Quantidade de horas utilizadas: ");
                qtdHoras = leitor.nextFloat();
                System.out.println("Valor da conta: R$" + qtdHoras * 0.48f);
                break;
            case 3:
                System.out.print("Quantidade de horas utilizadas: ");
                qtdHoras = leitor.nextFloat();
                System.out.println("Valor da conta: R$" + qtdHoras * 1.29f);
                break;
            default:
                System.out.println("Tipo de cliente inválido.");
        }
        leitor.close();
    }
}
