package br.com.alura.loja.orcamento.situacao;

import br.com.alura.loja.exception.DomainException;
import br.com.alura.loja.orcamento.Orcamento;

import java.math.BigDecimal;

public class SituacaoOrcamento {

    public BigDecimal CalcularDescontoExtra(Orcamento orcamento) {
        return BigDecimal.ZERO;
    }

    public void aprovar(Orcamento orcamento) {
        throw new DomainException("Não foi possível aprovar o orçamento");
    }

    public void reprovar(Orcamento orcamento) {
        throw new DomainException("Não foi possível reprovar o orçamento");
    }

    public void finalizar(Orcamento orcamento) {
        throw new DomainException("Não foi possível finalizar o orçamento");
    }


}
