package com.mycompany.ex007;

public class Funcionario {

    private String primeiroNome;
    private String sobrenome;
    private double salario;

    public Funcionario(String primeiroNome, String sobrenome, double salario) {
        this.primeiroNome = primeiroNome;
        this.sobrenome = sobrenome;
        if (salario < 0) {
            this.salario = 0;
        } else {
            this.salario = salario;
        }
    }

    public String getPrimeiroNome() {
        return primeiroNome;
    }

    public void setPrimeiroNome(String primeiroNome) {
        this.primeiroNome = primeiroNome;
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

    @Override
    public String toString() {
        return "Funcionario{" + "primeiroNome=" + primeiroNome + ", sobrenome=" + sobrenome + ", salario=" + salario + '}';
    }

}
