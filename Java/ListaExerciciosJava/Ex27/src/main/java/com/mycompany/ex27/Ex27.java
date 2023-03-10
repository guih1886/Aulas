package com.mycompany.ex27;

import java.util.Scanner;

public class Ex27 {

    public static void main(String[] args) {
        float valorCarro = 0.0f;
        float valorDesconto = 0.0f;
        int combCarro = 0;

        Scanner leitor = new Scanner(System.in);

        System.out.print("Informe o valor do carro: ");
        valorCarro = leitor.nextFloat();
        if (valorCarro != 0) {
            System.out.print("Informe o combustível: ");
            System.out.print("1 - Álcool | 2 - Gasolina | 3 - Diesel: ");
            combCarro = leitor.nextInt();

            switch (combCarro) {
                case 1:
                    valorDesconto = (float) (valorCarro * 0.25);
                    break;
                case 2:
                    valorDesconto = (float) (valorCarro * 0.21);
                    break;
                case 3:
                    valorDesconto = (float) (valorCarro * 0.14);
                    break;
                default:
                    System.out.print("Valor inválido.");
                    break;
            }
            if (combCarro == 1 || combCarro == 2 || combCarro == 3) {
                System.out.println("Valor do desconto: " + valorDesconto);
                System.out.println("Valor do carro: " + (valorCarro - valorDesconto));
            }
        }
    }
}
