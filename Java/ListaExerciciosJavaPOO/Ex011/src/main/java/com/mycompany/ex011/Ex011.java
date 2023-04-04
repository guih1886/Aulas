package com.mycompany.ex011;

/**
 * Exercicio do ingresso, aonde o ingresso vip deve herdar do coum o preço e in-
 * cluir um adicional.
 */
public class Ex011 {

    public static void main(String[] args) {
        //instanciando as classes
        IngressoVip ingresso1 = new IngressoVip(13.50f);
        System.out.println("Valor do ingresso comum: R$" + ingresso1.imprimirValor());
        ingresso1.imprimirValorIngressoVip();
        
        
    }
}
