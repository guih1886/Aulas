package br.com.alura.loja.desconto;

import br.com.alura.loja.orcamento.Orcamento;

import java.math.BigDecimal;

public class CalculadoraDeDescontos {

    public BigDecimal calcular(Orcamento orcamento) {
        //chain of responsability
        Desconto desconto = new DescontoMaiorQueQuinheintos(new DescontoMaisQueCintoItens(new SemDesconto()));

        return desconto.calcular(orcamento);
    }
}
