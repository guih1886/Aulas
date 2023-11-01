package main

import (
	"fmt"
	"os"
)

func main() {
	/* := serve para omitir a declaração de var, o go possui inferencia de tipos*/

	exibeIntroducao()
	exibeMenu()
	comando := leComando()

	switch comando {
	case 1:
		fmt.Println("Monitorando...")
	case 2:
		fmt.Println("Exibindo Logs...")
	case 0:
		fmt.Println("Saindo...")
		os.Exit(0)
	default:
		fmt.Println("Comando inválido.")
	}
}

func exibeIntroducao() {
	nome := "Guilherme"
	fmt.Println("Olá", nome)
}

func exibeMenu() {
	fmt.Println("1- Iniciar Monitoramento")
	fmt.Println("2- Exibir Logs")
	fmt.Println("0- Sair do Programa")
}

func leComando() int {
	var comando int
	fmt.Scan(&comando)
	return comando
}
