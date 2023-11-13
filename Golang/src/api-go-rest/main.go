package main

import (
	"F-GO/api-go-rest/models"
	"F-GO/api-go-rest/routes"
)

func main() {
	models.Personalidades = []models.Personalidade{
		{Nome: "Nome 1", Historia: "Historia 1"},
		{Nome: "Nome 2", Historia: "Historia 2"},
		{Nome: "Nome 3", Historia: "Historia 3"},
	}
	routes.HandleRequest()
}
