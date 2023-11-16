package main

import (
	"F-GO/gin-api-rest/routes"
	"gin-api-rest/database"
)

func main() {
	database.ConectaComBancoDeDados()
	routes.HandleRequests()
}
