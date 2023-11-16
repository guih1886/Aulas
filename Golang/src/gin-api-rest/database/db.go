package database

import (
	"fmt"
	"gin-api-rest/models"
	"log"

	"gorm.io/driver/postgres"
	"gorm.io/gorm"
)

var (
	DB *gorm.DB
)

func ConectaComBancoDeDados() {
	stringConexao := "host=localhost user=root password=root dbname=root port=5432 sslmode=disable"
	DB, _ = gorm.Open(postgres.Open(stringConexao))
	if DB == nil {
		log.Panic("Erro ao conectar com o banco de dados.")
	}
	fmt.Println("Conectado com o banco de dados.")
	DB.AutoMigrate(&models.Aluno{})
}
