package main

import (
	"html/template"
	"net/http"
)

type Produto struct {
	Nome, Descricao string
	Preco           float64
	Quantidade      int
}

var templates = template.Must(template.ParseGlob("templates/*.html"))

func main() {
	http.HandleFunc("/", index)
	http.ListenAndServe(":8000", nil)
}

func index(w http.ResponseWriter, r *http.Request) {
	produtos := []Produto{
		{Nome: "Camiseta", Descricao: "Camiseta boa", Preco: 35.99, Quantidade: 20},
		{"Tenis Bom", "Tenis muito bom", 299.99, 4},
		{"Fone de Ouvido", "Fone muito bom", 299.99, 2},
	}

	templates.ExecuteTemplate(w, "index.html", produtos)
}
