package com.mycompany.ex014;

/**
 * Exercicio de fatura, aonde tem os atributos de numero, descrição, quantidade
 * e preço por item. Possui o método getTotalFatura aonde retorna o total
 *
 */
public class Fatura {

    private String numero;
    private String descricao;
    private int qtdCompradaItem;
    private double precoUn;

    public Fatura(String numero, String descricao, int qtdCompradaItem, double precoUn) {
        this.numero = numero;
        this.descricao = descricao;
        //verifica a quantidade comprada do item, e caso negativa seta 0
        if (qtdCompradaItem < 0) {
            this.qtdCompradaItem = 0;
        } else {
            this.qtdCompradaItem = qtdCompradaItem;
        }
        this.precoUn = precoUn;
    }

    public double getTotalFatura() {
        double total = 0;
        //validação de preço negativo
        if (this.precoUn < 0) {
            this.precoUn = 0;
        } else {
            total = this.precoUn * this.qtdCompradaItem;
        }
        return total;
    }

    public String getNumero() {
        return numero;
    }

    public void setNumero(String numero) {
        this.numero = numero;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    public int getQtdCompradaItem() {
        return qtdCompradaItem;
    }

    public void setQtdCompradaItem(int qtdCompradaItem) {
        this.qtdCompradaItem = qtdCompradaItem;
    }

    public double getPrecoUn() {
        return precoUn;
    }

    public void setPrecoUn(double precoUn) {
        this.precoUn = precoUn;
    }

}
