package com.mycompany.ex1;

public class Ex1 {

    public static void main(String[] args) {
        Pessoa pessoa = new Pessoa();
        pessoa.setNome("Guilherme");
        pessoa.setAltura(1.70f);
        System.out.println(pessoa.imprimeDados());
    }
}
