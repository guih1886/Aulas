package br.com.alura.loja.pedido;

import br.com.alura.loja.orcamento.ItemOrcamento;
import br.com.alura.loja.orcamento.Orcamento;
import br.com.alura.loja.pedido.acao.AcaoAposGerarPedido;

import java.math.BigDecimal;
import java.time.LocalDate;
import java.util.List;

public class GeraPedido {
    private String cliente;
    private BigDecimal valorOrcamento;
    private int quantidadeItens;


    public GeraPedido(String cliente, BigDecimal valorOrcamento, int quantidadeItens) {
        this.cliente = cliente;
        this.valorOrcamento = valorOrcamento;
        this.quantidadeItens = quantidadeItens;
    }

    public void executa() {
        Orcamento orcamento = new Orcamento();
        orcamento.adicionarItem(new ItemOrcamento(new BigDecimal("600")));
        Pedido pedido = new Pedido(this.cliente, LocalDate.now(), orcamento);
    }

    public String getCliente() {
        return cliente;
    }

    public BigDecimal getValorOrcamento() {
        return valorOrcamento;
    }

    public int getQuantidadeItens() {
        return quantidadeItens;
    }
}
