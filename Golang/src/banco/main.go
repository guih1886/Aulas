package main

import (
	"fmt"
)

func main() {
	pessoaTitular := Titular{Nome: "Bruna", CPF: "123456789", Profissao: "Desenvolvedor"}
	conta1 := ContaCorrente{pessoaTitular, 456, 12345, 1500.00}
	conta2 := ContaCorrente{saldo: 500.00, Titular: pessoaTitular}

	fmt.Println(conta1.saldo)
	fmt.Println(conta1.Sacar(500))
	fmt.Println(conta1.saldo)

	fmt.Println(conta2.saldo)
	fmt.Println(conta2.Sacar(-1500))
	fmt.Println(conta2.saldo)

	fmt.Println(conta1.Depositar(350.50))
	fmt.Println(conta1.saldo)

	fmt.Println(conta1.saldo)
	fmt.Println(conta2.saldo)
	fmt.Println(conta1.Transferir(250, &conta2))
	fmt.Println(conta1.saldo)
	fmt.Println(conta2.saldo)

	fmt.Println(conta1, conta2)
	conta1.saldo = 100
	fmt.Println(conta1.Extrato())
	PagarBoleto(&conta1, 50)
	fmt.Println(conta1.Extrato())

}

/*
	Struct é como uma classe

A váriavel com letra minuscula age como private, enquanto com maiuscula como public
*/
type Titular struct {
	Nome, CPF, Profissao string
}

type ContaCorrente struct {
	Titular                    Titular
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

type ContaPoupanca struct {
	Titular                              Titular
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
