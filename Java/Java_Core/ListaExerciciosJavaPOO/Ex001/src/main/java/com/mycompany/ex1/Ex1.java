package com.mycompany.ex1;

/*
Exercicio de pessoa, aonde contenha os atributos de nome, data de nascimento e 
altura. Possuir métodos para imprimir os dados da pessoa e calcular sua idade.
 */
import java.text.ParseException;

public class Ex1 {

    public static void main(String[] args) throws ParseException {

        Pessoa pessoa = new Pessoa();
        pessoa.setNome("Guilherme Henrique");
        pessoa.setDataNascimento("07/05/1994");
        pessoa.setAltura(1.70f);

        System.out.println(pessoa.imprimeDados());
        System.out.println(pessoa.calculaIdade());
    }
}
