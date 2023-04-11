package com.mycompany.ex013;

/**
 * Exercicio da calculadora, onde na classe principal possui as operações bási-
 * cas e em uma outra classe as operações para a calculadora ciêntifica.
 *
 */
public class Ex013 {

    public static void main(String[] args) {
        //instanciando uma conta
        CalculadoraCientifica conta1 = new CalculadoraCientifica(3, 10);
        conta1.soma();
        conta1.subtracao();
        conta1.multiplicacao();
        conta1.divisao();
        conta1.raizQuadradaN1();
        conta1.raizQuadradaN2();
        conta1.potencia();
        //instanciando outra conta
        CalculadoraCientifica conta2 = new CalculadoraCientifica(13, 3);
        conta2.soma();
        conta2.subtracao();
        conta2.multiplicacao();
        conta2.divisao();
        conta2.raizQuadradaN1();
        conta2.raizQuadradaN2();
        conta2.potencia();
    }
}
