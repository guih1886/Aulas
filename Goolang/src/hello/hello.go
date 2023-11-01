package main

import (
	"fmt"
)

func main() {
	/* := serve para omitir a declaração de var, o go possui inferencia de tipos*/
	nome := "Guilherme"
	fmt.Println("Olá", nome)

	fmt.Println("1- Iniciar Monitoramento")
	fmt.Println("2- Exibir Logs")
	fmt.Println("0- Sair do Programa")
	var comando int

	fmt.Scan(&comando)
}
