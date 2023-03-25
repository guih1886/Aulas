package com.mycompany.ex30;

import java.util.Scanner;

public class Ex30 {

    public static void main(String[] args) {
        //Escreva um algoritmo que leia três valores inteiros
        //distintos e os escreva em ordem crescente
        int[] valores = new int[3];
        Scanner leitor = new Scanner(System.in);

        //populando o array
        for (int i = 0; i < 3; i++) {
            System.out.print("Digite o valor inteiro " + (i + 1) + ": ");
            valores[i] = leitor.nextInt();
        }

        //ordenando
        for (int i = 0; i < valores.length - 1; i++) {
            for (int j = 0; j < valores.length - 1; j++) {
                if (valores[j] > valores[j + 1]) {
                    int aux = valores[j];
                    valores[j] = valores[j + 1];
                    valores[j + 1] = aux;
                }
            }
        }
                
        //exibindo ordenado
        for (int num : valores) {
            System.out.print(num + " ");
        }

    }
}
