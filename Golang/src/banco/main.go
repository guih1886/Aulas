package main

import (
	"banco/contas"
	"fmt"
)

func main() {
	conta1 := contas.ContaCorrente{"Guilherme", 456, 12345, 1500.00}
	conta2 := contas.ContaCorrente{Saldo: 500.00, Titular: "Bruna"}

	fmt.Println(conta1.Saldo)
	fmt.Println(conta1.Sacar(500))
	fmt.Println(conta1.Saldo)

	fmt.Println(conta2.Saldo)
	fmt.Println(conta2.Sacar(-1500))
	fmt.Println(conta2.Saldo)

	fmt.Println(conta1.Depositar(350.50))
	fmt.Println(conta1.Saldo)

	fmt.Println(conta1.Saldo)
	fmt.Println(conta2.Saldo)
	fmt.Println(conta1.Transferir(250, &conta2))
	fmt.Println(conta1.Saldo)
	fmt.Println(conta2.Saldo)

	fmt.Println(conta1, conta2)
}
