package com.mycompany.ex1;

import java.util.Date;

public class Pessoa {

    private String nome;
    private Date dataNascimento;
    private float altura;

    public String imprimeDados() {
        return "Nome: " + this.getNome() + " | Data de nascimento: "
                + this.getDataNascimento() + " | Altura: " + this.getAltura()
                + " m";
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public Date getDataNascimento() {
        return dataNascimento;
    }

    public void setDataNascimento(Date dataNascimento) {
        this.dataNascimento = dataNascimento;
    }

    public float getAltura() {
        return altura;
    }

    public void setAltura(float altura) {
        this.altura = altura;
    }

}
