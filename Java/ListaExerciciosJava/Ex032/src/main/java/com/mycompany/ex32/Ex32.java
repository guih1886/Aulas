package com.mycompany.ex32;

import java.util.Scanner;

public class Ex32 {

    public static void main(String[] args) {
        int A;
        int B;
        int C;
        Scanner leitor = new Scanner(System.in);

        System.out.print("Digite o tamanho do lado A: ");
        A = leitor.nextInt();
        System.out.print("Digite o tamanho do lado B: ");
        B = leitor.nextInt();
        System.out.print("Digite o tamanho do lado C: ");
        C = leitor.nextInt();

        if ((A < B + C) && (B < A + C) && (C < B + A)) {
            if (A == B && A == C) {
                System.out.println("Triângulo é um equilátero.");
            }
            if (A != B && A != C) {
                System.out.println("Triângulo é um escaleno.");
            }
            if ((A == B && A == C) || (B == A && B == C) || (C == A && C == B)) {
                System.out.println("Triângulo é um isócele.");
            }
        } else {
            System.out.println("Não é um triângulo.");
        }
    }
}
