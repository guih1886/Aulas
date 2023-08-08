package br.com.alurafood.pedidos.amqp;

import br.com.alurafood.pedidos.dto.PagamentoDTO;
import org.springframework.amqp.core.Message;
import org.springframework.amqp.rabbit.annotation.RabbitListener;
import org.springframework.messaging.handler.annotation.Payload;
import org.springframework.stereotype.Component;

@Component
public class PagamentoListener {

    //pegando a mensagem da fila e imprimindo no console
    @RabbitListener(queues = "pagamentos.detalhes-pedido")
    public void recebeMessage(@Payload PagamentoDTO pagamentoDTO) {
        String mensagem = """
                ID do pagamento: %s
                Número do pagamento: %s
                Nome: %s
                Valor R$ %s
                Status: %s
                """
                .formatted(pagamentoDTO.getId(), pagamentoDTO.getPedidoId(), pagamentoDTO.getNome(), pagamentoDTO.getValor(), pagamentoDTO.getStatus());
        System.out.println(mensagem);
    }

}
