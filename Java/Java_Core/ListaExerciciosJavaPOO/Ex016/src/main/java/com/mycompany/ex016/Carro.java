//
package com.mycompany.ex016;

public class Carro {

    private double tanque = 0;

    public Carro() {
    }

    public void abastecerCarro(double quantidadeGasolina) {
        //limitando o tanque para 50L
        if (quantidadeGasolina > 50) {
            this.tanque = 50;
        } else {
            this.tanque = quantidadeGasolina;
        }
    }

    public void moverCarro(int KM) {
        double autonomia = this.tanque * 15;
        double consumoGasolina = KM / 15.000;
        double gasolinaRestante = this.tanque - consumoGasolina;
        if (KM < autonomia) {
            System.out.println(String.format("O carro andou " + KM + "KM "
                    + "e sobrou %.2fL de combustível.", gasolinaRestante));
        } else {
            System.out.println("O carro andou " + autonomia + ""
                    + "KM e parou por falta de combustível.");
        }
    }

    public double getTanque() {
        return tanque;
    }

    public void setTanque(float tanque) {
        this.tanque = tanque;
    }

}
