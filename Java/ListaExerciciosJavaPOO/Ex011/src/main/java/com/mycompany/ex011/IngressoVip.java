package com.mycompany.ex011;

public class IngressoVip extends Ingresso {

    private float valorIngressoVip = 0.0f;

    public IngressoVip(float valor) {
        super(valor);
    }

    public void imprimirValorIngressoVip() {
        this.valorIngressoVip = (float) (super.imprimirValor()+ super.imprimirValor()* 0.3);
        System.out.println("Valor do ingresso vip: R$" + this.valorIngressoVip);
    }

}
