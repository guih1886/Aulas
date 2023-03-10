package com.mycompany.ex20;

import java.util.Scanner;

public class Ex20 {

    public static void main(String[] args) {
        int anoCarro;
        int contadorCarro2000 = 0;
        int contadorCarroGeral = 0;
        char opcao;
        float valorCarro = 0.0f;
        float valorDesconto = 0.0f;
        boolean parar = false;
        Scanner leitor = new Scanner(System.in);

        while (!parar) {
            System.out.print("Informe o valor do carro: ");
            valorCarro = leitor.nextFloat();
            System.out.print("Informe o ano do carro: ");
            anoCarro = leitor.nextInt();

            if (anoCarro <= 2000) {
                valorDesconto = (float) (valorCarro * 0.12);
                System.out.println("Valor de desconto no carro: " + valorDesconto);
                System.out.println("Valor final do carro: "
                        + (valorCarro - valorDesconto));
                contadorCarro2000++;
                contadorCarroGeral++;
            } else {
                valorDesconto = (float) (valorCarro * 0.07);
                System.out.println("Valor de desconto no carro: " + valorDesconto);
                System.out.println("Valor final do carro: "
                        + (valorCarro - valorDesconto));
                contadorCarroGeral++;
            }
            System.out.print("Deseja cadastrar novamente? S - Sim | N - Não: ");
            opcao = leitor.next().charAt(0);
            if (opcao == 's' || opcao == 'S') {
                parar = false;
            }
            if (opcao == 'n' || opcao == 'N') {
                parar = true;
            }
        }
        System.out.println("Total de carro com ano até 2000: " + contadorCarro2000);
        System.out.println("Total de carro com ano acima de 2000: " + contadorCarroGeral);
    }
}
