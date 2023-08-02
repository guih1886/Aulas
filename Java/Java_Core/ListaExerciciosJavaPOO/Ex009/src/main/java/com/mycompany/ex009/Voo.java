package com.mycompany.ex009;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

public class Voo {

    private int numeroVoo;
    private Date data;
    private String[] cadeirasLivres = new String[5];

    public Voo(int numeroVoo, String data) throws ParseException {
        this.numeroVoo = numeroVoo;
        SimpleDateFormat sf = new SimpleDateFormat("dd/MM/yyyy");
        this.data = sf.parse(data);
        //populando os lugares da cadeira
        for (int i = 0; i < this.cadeirasLivres.length; i++) {
            cadeirasLivres[i] = "Livre";
        }
    }

    public void verifica(int numeroCadeira) {
        if (numeroCadeira == 0 || numeroCadeira > cadeirasLivres.length) {
            System.out.println("Número de cadeira inválido.");
        } else {
            if (cadeirasLivres[numeroCadeira - 1] != "Livre") {
                System.out.println("Cadeira " + numeroCadeira + " está ocupada.");
            } else {
                System.out.println("Cadeira " + numeroCadeira + " está livre.");
            }
        }
    }

    public void proximoLivre() {
        for (int i = 0; i < this.cadeirasLivres.length; i++) {
            if (cadeirasLivres[i] == "Livre") {
                System.out.println("Próxima caidera livre: " + (i + 1));
                return;
            }
        }
        System.out.println("Sem cadeiras livres!");
    }

    public void ocupa(int numeroCadeira) {
        if (numeroCadeira <= cadeirasLivres.length) {
            if (cadeirasLivres[numeroCadeira - 1] == "Livre") {
                System.out.println("Cadeira " + numeroCadeira + " ocupada com sucesso.");
                cadeirasLivres[numeroCadeira - 1] = "Ocupada";
            } else {
                System.out.println("Cadeira " + numeroCadeira + " está ocupada.");
            }
        } else {
            System.out.println("Número de cadeira inválido.");
        }

    }

    public void vagas() {
        int vagas = 0;
        for (int i = 0; i < this.cadeirasLivres.length; i++) {
            if (cadeirasLivres[i] == "Livre") {
                vagas++;
            }
        }
        if (vagas == 0) {
            System.out.println("Avião cheio!");
        } else {
            System.out.println("Vagas: " + vagas);
        }
    }

    public void getVoo() {
        System.out.println("Número do Voo: " + this.numeroVoo);
    }

}
