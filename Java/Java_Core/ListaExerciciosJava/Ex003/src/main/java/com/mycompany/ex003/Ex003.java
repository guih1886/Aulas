package com.mycompany.ex003;

import java.util.Scanner;

public class Ex003 {

    public static void main(String[] args) {
        float distanciaPercorrida;
        float combustivelConsumido;
        float consumoMedio;
        Scanner leitor = new Scanner(System.in);

        System.out.print("Informe a distancia percorrida: ");
        distanciaPercorrida = leitor.nextFloat();
        System.out.print("Informe a quantidade de combustivel consumido: ");
        combustivelConsumido = leitor.nextFloat();

        consumoMedio = distanciaPercorrida / combustivelConsumido;
        System.out.print("Consumo medio foi de: " + consumoMedio + " km/l");
        leitor.close();
    }
}
