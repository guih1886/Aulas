package com.mycompany.ex004;

/*

Exercicio do elevador, com os atributos de andar atual, total de andares, capa-
cidade do elevador e lotação. Possui os métodos para inicializar o elevador, en-
trar, sair, subir e descer os andares.

 */
public class Ex004 {

    public static void main(String[] args) {
        Elevador elevador = new Elevador();
        //testando a classe
        elevador.inicializa(30, 20);
        elevador.entra(29);
        elevador.entra(3);
        elevador.entra(1);
        elevador.sai(30);
        elevador.sai(1);
        elevador.sobe(1);
        elevador.sobe(19);
        elevador.sobe(1);
        elevador.desce(20);

    }
}
