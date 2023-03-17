package com.mycompany.ex1;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

public class Ex1 {

    public static void main(String[] args) throws ParseException {

        Pessoa pessoa = new Pessoa();
        Date data = new SimpleDateFormat("dd/MM/yyyy").parse("07/05/1994");
        pessoa.setNome("Guilherme");
        pessoa.setDataNascimento(data);
        pessoa.setAltura(1.70f);

        System.out.println(pessoa.imprimeDados());
    }
}
