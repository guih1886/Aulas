import br.com.alura.loja.pedido.GeraPedido;
import br.com.alura.loja.pedido.GeraPedidoHandler;
import br.com.alura.loja.pedido.acao.EnviarEmailPedido;
import br.com.alura.loja.pedido.acao.SalvarPedidoNoBancoDeDados;

import java.math.BigDecimal;
import java.util.Arrays;

public class TestePedidos {

    public static void main(String[] args) {
        String cliente = "Guilherme";
        BigDecimal valorOrcamento = new BigDecimal("500");
        int quantidadeItens = Integer.parseInt("3");

        GeraPedido gerador = new GeraPedido(cliente, valorOrcamento, quantidadeItens);
        GeraPedidoHandler handler = new GeraPedidoHandler(Arrays.asList(new EnviarEmailPedido(), new SalvarPedidoNoBancoDeDados()));
        handler.execute(gerador);
    }

}
