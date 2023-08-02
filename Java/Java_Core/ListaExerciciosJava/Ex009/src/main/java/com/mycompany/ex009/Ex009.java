package com.mycompany.ex009;

import java.util.Scanner;

public class Ex009 {

    public static void main(String[] args) {
        float valorDeposito;
        Scanner leitor = new Scanner(System.in);

        System.out.print("Digite o valor do deposito: ");
        valorDeposito = leitor.nextFloat();

        System.out.print("Valor com rendimento: " + (valorDeposito + (valorDeposito * 0.07)));
        leitor.close();
    }
}
