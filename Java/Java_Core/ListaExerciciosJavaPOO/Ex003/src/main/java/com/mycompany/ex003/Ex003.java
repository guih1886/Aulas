package com.mycompany.ex003;

/*

Exercicio bomba de combustivel, que contem os atibutos tipo de combustivel, valor
do litro e quantidade de combustivel. Possui os métodos para abastecer por valor,
abastecer por litro, alterar valor, alterar tipo do combustivel e alterar a qua-
ntidade de combustivel.

*/

public class Ex003 {

    public static void main(String[] args) {
        //testando a classe
        BombaCombustivel bomba1 = new BombaCombustivel("Gasolina", 5.12, 5);
        bomba1.abastecerPorValor(51.2);
        bomba1.abastecerPorLitro(5);
        bomba1.alterarValor(5.35);
        bomba1.alterarTipoCombustivel("Diesel");
        bomba1.alterarQtdCombustivel(-5);
        bomba1.alterarQtdCombustivel(50);

    }
}
