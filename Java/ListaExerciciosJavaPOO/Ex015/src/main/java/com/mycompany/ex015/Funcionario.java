//
package com.mycompany.ex015;

public class Funcionario {

    private String nome;
    private String sobrenome;
    private double salario;
    private int passaramPelaEmpresa;

    public Funcionario(String nome, String sobrenome, double salario) {
        this.nome = nome;
        this.sobrenome = sobrenome;
        this.salario = salario;
        exibirSalario();
        this.passaramPelaEmpresa++;
    }

    public void exibirSalario() {
        System.out.println("O salário de " + this.nome + " é de R$"
                + this.salario);
    }

    public void aumentarSalario(int porcemtagem) {
        double reajuste = this.salario * ((double) porcemtagem / 100);
        this.salario = this.salario + reajuste;
        System.out.println("O novo salário de " + this.nome + " anual é de R$"
                + this.salario * 12);
    }

    public void getPassaramPelaEmpresa() {
        System.out.println("Passaram " + this.passaramPelaEmpresa + " funcionários"
                + " pela empresa ao total.");
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getSobrenome() {
        return sobrenome;
    }

    public void setSobrenome(String sobrenome) {
        this.sobrenome = sobrenome;
    }

    public double getSalario() {
        return salario;
    }

    public void setSalario(double salario) {
        this.salario = salario;
    }
}
