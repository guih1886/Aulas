package main

import (
	"F-GO/api-go-rest/database"
	"F-GO/api-go-rest/models"
	"F-GO/api-go-rest/routes"
)

func main() {
	models.Personalidades = []models.Personalidade{
		{Id: 1, Nome: "Nome 1", Historia: "Historia 1"},
		{Id: 2, Nome: "Nome 2", Historia: "Historia 2"},
		{Id: 3, Nome: "Nome 3", Historia: "Historia 3"},
	}
	database.ConectaComBancoDeDados()
	routes.HandleRequest()
}
