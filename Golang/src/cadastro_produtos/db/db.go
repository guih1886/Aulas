package db

import (
	"database/sql"
	"fmt"

	_ "github.com/go-sql-driver/mysql"
)

func ConectaBanco() *sql.DB {
	// Configurar a string de conexão com o MySQL
	connectionString := "root:@tcp(localhost:3306)/alura_loja"

	// Abrir uma conexão com o banco de dados MySQL
	db, err := sql.Open("mysql", connectionString)
	if err != nil {
		panic(err.Error())
	}
	fmt.Println("Conexão bem-sucedida!")
	return db
}
