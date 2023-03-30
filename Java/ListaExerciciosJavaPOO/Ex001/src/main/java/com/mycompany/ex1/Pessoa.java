package com.mycompany.ex1;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import java.util.GregorianCalendar;

public class Pessoa {

    private String nome;
    private Date dataNascimento;
    private float altura;

    public String imprimeDados() {
        return "Nome: " + this.getNome() + " | Data de nascimento: "
                + this.getDataNascimento() + " | Altura: " + this.getAltura()
                + " m";
    }

    public String calculaIdade() {
        int anoAtual;
        int anoNasc;
        int mesAtual;
        int mesNasc;
        int idade;
        Calendar dataNasc = new GregorianCalendar();
        dataNasc.setTime(this.dataNascimento);
        mesNasc = dataNasc.get(Calendar.MONTH);
        anoNasc = dataNasc.get(Calendar.YEAR);

        //pegando o mês e ano atual
        Calendar hoje = Calendar.getInstance();
        mesAtual = hoje.get(Calendar.MONTH);
        anoAtual = hoje.get(Calendar.YEAR);

        //calculando a idade
        idade = anoAtual - anoNasc;
        if (mesAtual < mesNasc) {
            idade--;
        }
        return "A idade de " + this.nome + " é: " + idade + " anos.";
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getDataNascimento() {
        SimpleDateFormat sf = new SimpleDateFormat("dd/MM/yyyy");
        String data = sf.format(this.dataNascimento);
        return data;
    }

    public void setDataNascimento(String nascimento) throws ParseException {
        SimpleDateFormat sf = new SimpleDateFormat("dd/MM/yyyy");
        this.dataNascimento = sf.parse(nascimento);
    }

    public float getAltura() {
        return altura;
    }

    public void setAltura(float altura) {
        this.altura = altura;
    }
}
