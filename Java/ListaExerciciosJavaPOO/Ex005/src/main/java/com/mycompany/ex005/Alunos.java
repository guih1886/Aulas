package com.mycompany.ex005;

public class Alunos {

    private int matricula;
    private String nome;
    private double p1;
    private double p2;
    private double t1;

    public Alunos(int matricula, String nome, double p1, double p2, double t1) {
        this.matricula = matricula;
        this.nome = nome;
        this.p1 = p1;
        this.p2 = p2;
        this.t1 = t1;
    }

    public void media() {
        double media = ((this.p1 * 2.5) + (this.p2 * 2.5) + (this.t1 * 2)) / 7;
        System.out.println("Média de " + this.nome + ": " + media);
    }

    public void provaFinal() {
        //sem peso para a prova final
    }

}
