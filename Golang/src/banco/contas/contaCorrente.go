package contas

/* Struct é como uma classe
A váriavel com letra minuscula age como private, enquanto com maiuscula como public
*/
import "banco/clientes"

type ContaCorrente struct {
	Titular                    clientes.Titular
	NumeroAgencia, NumeroConta int
	saldo                      float64
}

func (c *ContaCorrente) Sacar(valorSaque float64) string {
	podeSacar := valorSaque <= c.saldo && valorSaque > 0
	if podeSacar {
		c.saldo -= valorSaque
		return "Saque realizado com sucesso"
	} else {
		return "saldo insuficiente"
	}
}

func (c *ContaCorrente) Depositar(valorDeposito float64) (string, float64) {
	if valorDeposito < 0 {
		return "Valor inválido", c.saldo
	}
	c.saldo += valorDeposito
	return "Deposito realizado com sucesso", c.saldo
}

func (c *ContaCorrente) Transferir(valorTransferencia float64, contaDestino *ContaCorrente) string {
	if valorTransferencia < c.saldo && valorTransferencia > 0 {
		c.Sacar(valorTransferencia)
		contaDestino.Depositar(valorTransferencia)
		return "Transferência realizada com sucesso"
	}
	return "Saldo insuficiente"
}

func (c *ContaCorrente) Extrato() float64 {
	return c.saldo
}
