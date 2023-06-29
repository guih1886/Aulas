import br.com.alura.loja.desconto.CalculadoraDeDescontos;
import br.com.alura.loja.orcamento.ItemOrcamento;
import br.com.alura.loja.orcamento.Orcamento;
import br.com.alura.loja.pedido.GeraPedido;

import java.math.BigDecimal;

public class TesteDescontos {

    public static void main(String[] args) {
        Orcamento orcamento = new Orcamento();
        orcamento.adicionarItem(new ItemOrcamento(new BigDecimal("200")));
        Orcamento orcamento2 = new Orcamento();
        orcamento2.adicionarItem(new ItemOrcamento(new BigDecimal("300")));
        CalculadoraDeDescontos calculadoraDeDescontos = new CalculadoraDeDescontos();
        System.out.println(calculadoraDeDescontos.calcular(orcamento));
        System.out.println(calculadoraDeDescontos.calcular(orcamento2));
    }
}
