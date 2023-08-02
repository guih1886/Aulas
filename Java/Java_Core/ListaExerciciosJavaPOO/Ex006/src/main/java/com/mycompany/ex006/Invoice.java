package com.mycompany.ex006;

public class Invoice {

    private int nItem;
    private String descricao;
    private int qtdItem;
    private double precoUn;

    public Invoice(int nItem, String descricao, int qtdItem, double precoUn) {
        this.nItem = nItem;
        this.descricao = descricao;
        this.precoUn = precoUn;
        if (qtdItem < 0) {
            this.qtdItem = 0;
        } else {
            this.qtdItem = qtdItem;
        }
        if (precoUn < 0) {
            this.precoUn = 0.0f;
        } else {
            this.precoUn = precoUn;
        }

    }

    public double getInvoiceAmount() {
        double valorFatura;
        valorFatura = getPrecoUn() * getQtdItem();
        return valorFatura;
    }

    public int getnItem() {
        return nItem;
    }

    public void setnItem(int nItem) {
        this.nItem = nItem;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    public int getQtdItem() {
        return qtdItem;
    }

    public void setQtdItem(int qtdItem) {
        this.qtdItem = qtdItem;
    }

    public double getPrecoUn() {
        return precoUn;
    }

    public void setPrecoUn(float precoUn) {
        this.precoUn = precoUn;
    }

}
