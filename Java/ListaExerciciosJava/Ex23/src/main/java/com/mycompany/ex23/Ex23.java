package com.mycompany.ex23;

import java.util.Scanner;

public class Ex23 {

    public static void main(String[] args) {
        int num = 0;
        Scanner leitor = new Scanner(System.in);
        
        System.out.print("Digite o número: ");
        num = leitor.nextInt();
        
        if(num > 80 || num < 25 || num == 40){
            System.out.print("Número correto!");
        }
    }
}
