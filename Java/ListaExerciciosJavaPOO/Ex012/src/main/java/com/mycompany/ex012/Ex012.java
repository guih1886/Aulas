package com.mycompany.ex012;

/**
 * Exercicio de agenda, aonde é possível armazenadar 10 pessoas e possui métodos
 * para armazenar, remover, buscar, e imprimir as pessoas. Alem de imprimir a a-
 * genda.
 */
public class Ex012 {

    public static void main(String[] args) {
        Agenda agenda1 = new Agenda();
        //populando a agenda
        agenda1.armazenarPessoa("Cleber", 10, 1.50f);
        agenda1.armazenarPessoa("Guilherme", 20, 1.85f);
        agenda1.armazenarPessoa("Paulo", 30, 1.79f);
        agenda1.armazenarPessoa("Cintia", 40, 1.68f);
        //consultas
        agenda1.imprimirPessoa(3);
        agenda1.imprimirPessoa(0);
        agenda1.imprimirPessoa(1);
        agenda1.imprimirPessoa(2);
        agenda1.removerPessoa("Paulo");
        agenda1.imprimirAgenda();
    }
}
