package com.mycompany.ex008;
/*

Exercicio de data, aonde é possivel acessar os métodos para comparar com a data
atual, buscar o dia, buscar o mês, buscar o ano, verificar se o ano é bissexto e
um clone, aonde é informado a nova data.

*/
import java.text.ParseException;

public class Ex008 {

    public static void main(String[] args) throws ParseException {
        Data d1 = new Data("31/01/2024");
        System.out.println(d1.compara());
        System.out.println(d1.getDia());
        System.out.println(d1.getMes());
        System.out.println(d1.getAno());
        d1.getMesExtenso();
        System.out.println(d1.isBissexto());
        
        
        d1.clone("08/10/2005");
        d1.getMesExtenso();
    }
}
