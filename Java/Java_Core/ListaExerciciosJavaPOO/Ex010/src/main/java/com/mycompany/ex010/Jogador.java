package com.mycompany.ex010;


import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import java.util.GregorianCalendar;

public class Jogador {

    private String nome = "";
    private String posicao = "";
    private Date dataNascimento;
    private String nacionalidade = "";
    private double altura = 0;
    private double peso = 0;
    private int idade = 0;

    @Override
    public String toString() {
        return "Jogador{" + "nome=" + nome + ", posicao=" + posicao + ", dataNascimento=" + getDataNascimento() + ", nacionalidade=" + nacionalidade + ", altura=" + altura + ", peso=" + peso + '}';
    }

    public int calculaIdade() throws ParseException {
        SimpleDateFormat sf = new SimpleDateFormat("dd/MM/yyyy");
        String data = sf.format(this.dataNascimento);
        if (data.matches("^(0?[1-9]|[12][0-9]|3[01])[\\/\\-](0?[1-9]|1[012])[\\/\\-]\\d{4}$")) {
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
                this.idade = idade;
            }
            this.idade = idade;
            return idade;

        } else {
            return 0;
        }
    }

    public void aposentar() throws ParseException {
        if (this.posicao == "Atacante") {
            if ((35 - this.idade) == 0) {
                System.out.println("Jogador se aposenta esse ano.");
            } else if ((35 - this.idade) < 0) {
                System.out.println("Jogador já aposentado.");
            } else {
                System.out.println("Faltam " + (35 - this.idade) + " anos para o jogador se aposentar.");
            }
        } else if (this.posicao == "Meio-campo") {
            if ((38 - this.idade) == 0) {
                System.out.println("Jogador se aposenta esse ano.");
            } else if ((38 - this.idade) < 0) {
                System.out.println("Jogador já aposentado.");
            } else {
                System.out.println("Faltam " + (38 - this.idade) + " anos para o jogador se aposentar.");
            }
        } else if (this.posicao == "Defesa") {
            if ((40 - this.idade) == 0) {
                System.out.println("Jogador se aposenta esse ano.");
            } else if ((40 - this.idade) < 0) {
                System.out.println("Jogador já aposentado.");
            } else {
                System.out.println("Faltam " + (40 - this.idade) + " anos para o jogador se aposentar.");
            }
        } else {
            System.out.println("Posição inválida!");
        }
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getPosicao() {
        return posicao;
    }

    public void setPosicao(String posicao) {
        this.posicao = posicao;
    }

    public String getDataNascimento() {
        SimpleDateFormat sf = new SimpleDateFormat("dd/MM/yyyy");
        return sf.format(this.dataNascimento);
    }

    //seta a data de nascimento e já calcula a idade do jogador
    public void setDataNascimento(String dataNascimento) throws ParseException {
        SimpleDateFormat sf = new SimpleDateFormat("dd/MM/yyyy");
        this.dataNascimento = sf.parse(dataNascimento);
        calculaIdade();
    }

    public String getNacionalidade() {
        return nacionalidade;
    }

    public void setNacionalidade(String nacionalidade) {
        this.nacionalidade = nacionalidade;
    }

    public double getAltura() {
        return altura;
    }

    public void setAltura(double altura) {
        this.altura = altura;
    }

    public double getPeso() {
        return peso;
    }

    public void setPeso(double peso) {
        this.peso = peso;
    }

}
