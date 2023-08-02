package br.com.alura.loja.pedido;

import br.com.alura.loja.orcamento.Orcamento;

import java.time.LocalDate;

public class Pedido {
    private String cliente;
    private LocalDate data;
    private Orcamento orcamento;

    public Pedido(String cliente, LocalDate data, Orcamento orcamento) {
        this.cliente = cliente;
        this.data = data;
        this.orcamento = orcamento;
    }

    public String getCliente() {
        return cliente;
    }

    public LocalDate getData() {
        return data;
    }

    public Orcamento getOrcamento() {
        return orcamento;
    }
}
