package com.mycompany.ex013;

public class Calculadora {

    private float n1 = 0.0f;
    private float n2 = 0.0f;

    public Calculadora(float n1, float n2) {
        this.n1 = n1;
        this.n2 = n2;
    }

    public void soma() {
        System.out.println("Soma dos valores: " + (this.n1 + this.n2));
    }

    public void subtracao() {
        System.out.println("Subtração dos valores: " + (this.n1 - this.n2));
    }

    public void multiplicacao() {
        System.out.println("Multiplicação dos valores: " + (this.n1 * this.n2));
    }

    public void divisao() {
        if (this.n2 == 0) {
            System.out.println("Divisão por zero!");
        } else {
            System.out.println("Divisão dos valores: " + (this.n1 / this.n2));
        }
    }

    public float getN1() {
        return n1;
    }

    public float getN2() {
        return n2;
    }

}
