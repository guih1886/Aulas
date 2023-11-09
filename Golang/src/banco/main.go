package main

import (
	"banco/clientes"
	"banco/contas"
	"fmt"
)

func main() {
	pessoaTitular := clientes.Titular{Nome: "Bruna", CPF: "123456789", Profissao: "Desenvolvedor"}
	conta1 := contas.ContaCorrente{Titular: pessoaTitular, NumeroAgencia: 456, NumeroConta: 12345}
	conta2 := contas.ContaCorrente{Titular: pessoaTitular}

	fmt.Println(conta1.Depositar(500))
	fmt.Println(conta1.Sacar(500))
	fmt.Println(conta1.Extrato())

	fmt.Println(conta2.Extrato())
	fmt.Println(conta2.Sacar(-1500))
	fmt.Println(conta2.Extrato())

	fmt.Println(conta1.Depositar(350.50))
	fmt.Println(conta1.Extrato())

	fmt.Println(conta1.Extrato())
	fmt.Println(conta2.Extrato())
	fmt.Println(conta1.Transferir(250, &conta2))
	fmt.Println(conta1.Extrato())
	fmt.Println(conta2.Extrato())

	fmt.Println(conta1, conta2)
	contas.PagarBoleto(&conta1, 50)
	fmt.Println(conta1.Extrato())

}
