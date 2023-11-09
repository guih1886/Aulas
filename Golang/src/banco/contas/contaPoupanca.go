package contas

/* Struct é como uma classe
A váriavel com letra minuscula age como private, enquanto com maiuscula como public
*/
import "banco/clientes"

type ContaPoupanca struct {
	Titular                              clientes.Titular
	NumeroAgencia, NumeroConta, Operacao int
	saldo                                float64
}

func (c *ContaPoupanca) Depositar(valorDeposito float64) (string, float64) {
	if valorDeposito < 0 {
		return "Valor inválido", c.saldo
	}
	c.saldo += valorDeposito
	return "Deposito realizado com sucesso", c.saldo
}

func (c *ContaPoupanca) Sacar(valorSaque float64) string {
	podeSacar := valorSaque <= c.saldo && valorSaque > 0
	if podeSacar {
		c.saldo -= valorSaque
		return "Saque realizado com sucesso"
	} else {
		return "saldo insuficiente"
	}
}

func (c *ContaPoupanca) Transferir(valorTransferencia float64, contaDestino *ContaPoupanca) string {
	if valorTransferencia < c.saldo && valorTransferencia > 0 {
		c.Sacar(valorTransferencia)
		contaDestino.Depositar(valorTransferencia)
		return "Transferência realizada com sucesso"
	}
	return "Saldo insuficiente"
}

func (c *ContaPoupanca) Extrato() float64 {
	return c.saldo
}

type verificaConta interface {
	Sacar(valor float64) string
}

func PagarBoleto(conta verificaConta, valor float64) {
	conta.Sacar(valor)
}
