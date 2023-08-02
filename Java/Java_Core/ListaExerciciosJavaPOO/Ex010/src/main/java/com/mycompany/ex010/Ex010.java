package com.mycompany.ex010;
/*

Exercicio do jogador, aonde temos os atributos de nome, posição, data de nasci-
mento, nacionalidade, altura, peso e um computado de idade. Com métodos para cal
cular a idade do jogador e calcular a quanto tempo falta para aposentar.

*/
import java.text.ParseException;

public class Ex010 {

    public static void main(String[] args) throws ParseException {
        //setando os dados do jogador 1
        Jogador j1 = new Jogador();
        System.out.println("Dados do jogador 1: ");
        j1.setNome("Antonio Luis");
        j1.setPosicao("Atacante");
        j1.setDataNascimento("03/05/1990");
        j1.setNacionalidade("Brasileiro");
        j1.setAltura(1.70);
        j1.setPeso(72);
        System.out.println(j1.toString());
        System.out.println("A idade do jogador é de: " + j1.calculaIdade() + " anos.");
        j1.aposentar();
        System.out.println("------------------------------------");
        //setando os dados do jogador 3
        Jogador j2 = new Jogador();
        System.out.println("Dados do jogador 2: ");
        j1.setNome("Gabriel Jesus");
        j1.setPosicao("Meio-campo");
        j1.setDataNascimento("15/03/1998");
        j1.setNacionalidade("Brasileiro");
        j1.setAltura(1.89);
        j1.setPeso(80);
        System.out.println(j1.toString());
        System.out.println("A idade do jogador é de: " + j1.calculaIdade() + " anos.");
        j1.aposentar();
        System.out.println("------------------------------------");
        //setando os dados do jogador 3
        Jogador j3 = new Jogador();
        System.out.println("Dados do jogador 3: ");
        j1.setNome("Pelé");
        j1.setPosicao("Defesa");
        j1.setDataNascimento("01/12/1967");
        j1.setNacionalidade("Brasileiro");
        j1.setAltura(1.54);
        j1.setPeso(65);
        System.out.println(j1.toString());
        System.out.println("A idade do jogador é de: " + j1.calculaIdade() + " anos.");
        j1.aposentar();
    }
}
