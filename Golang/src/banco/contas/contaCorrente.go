package contas

/* Struct é como uma classe
A váriavel com letra minuscula age como private, enquanto com maiuscula como public
*/
type ContaCorrente struct {
	Titular       string
	NumeroAgencia int
	NumeroConta   int
	Saldo         float64
}

func (c *ContaCorrente) Sacar(valorSaque float64) string {
	podeSacar := valorSaque <= c.Saldo && valorSaque > 0
	if podeSacar {
		c.Saldo -= valorSaque
		return "Saque realizado com sucesso"
	} else {
		return "Saldo insuficiente"
	}
}

func (c *ContaCorrente) Depositar(valorDeposito float64) (string, float64) {
	if valorDeposito < 0 {
		return "Valor inválido", c.Saldo
	}
	c.Saldo += valorDeposito
	return "Deposito realizado com sucesso", c.Saldo
}

func (c *ContaCorrente) Transferir(valorTransferencia float64, contaDestino *ContaCorrente) string {
	if valorTransferencia < c.Saldo && valorTransferencia > 0 {
		c.Sacar(valorTransferencia)
		contaDestino.Depositar(valorTransferencia)
		return "Transferência realizada com sucesso"
	}
	return "Saldo insuficiente"
}
