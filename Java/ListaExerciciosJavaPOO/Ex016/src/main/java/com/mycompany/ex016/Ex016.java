package com.mycompany.ex016;

/**
 * Exercicio do carro, aonde é possivel abastecer-lo e mover-lo. Ao move-lo será
 * exibida a quantidade percorrida, e se houver, a quantidade de combustí- vel
 * restante.
 *
 */
public class Ex016 {

    public static void main(String[] args) {
        //instanciando os carros
        Carro carro1 = new Carro();
        Carro carro2 = new Carro();
        //abastecendo os carros
        carro1.abastecerCarro(20);
        carro2.abastecerCarro(30);
        //movendo os carros
        carro1.moverCarro(200);
        carro2.moverCarro(400);
    }
}
