package com.mycompany.ex013;

public class CalculadoraCientifica extends Calculadora {

    public CalculadoraCientifica(float n1, float n2) {
        super(n1, n2);
    }

    public void raizQuadradaN1() {
        System.out.println("Raiz quadrada de n1: " + Math.sqrt(super.getN1()));
    }

    public void raizQuadradaN2() {
        System.out.println("Raiz quadrada de n2: " + Math.sqrt(super.getN2()));
    }

    public void potencia() {
        System.out.println("Potencia de n1 sobre n2: " + Math.pow(
                super.getN1(), super.getN2()));
    }
}
