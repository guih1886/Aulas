package com.mycompany.ex1;

import java.text.SimpleDateFormat;
import java.util.Date;

public class Pessoa {

    private String nome;
    private String dataNascimento;
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

    public String getDataNascimento() {
        return dataNascimento;
    }

    public void setDataNascimento(Date dataNascimento) {
        SimpleDateFormat sf = new SimpleDateFormat("dd/MM/yyyy");
        String data = sf.format(dataNascimento);
        this.dataNascimento = data;
    }

    public float getAltura() {
        return altura;
    }

    public void setAltura(float altura) {
        this.altura = altura;
    }

}
