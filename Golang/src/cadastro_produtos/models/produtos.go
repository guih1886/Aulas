package models

import "F-GO/cadastro_produtos/db"

type Produto struct {
	Id, Quantidade  int
	Nome, Descricao string
	Preco           float64
}

func BuscaTodosOsProdutos() []Produto {
	db := db.ConectaBanco()
	selectTodosProdutos, err := db.Query("select * from produtos")

	if err != nil {
		panic(err.Error())
	}

	p := Produto{}
	produtos := []Produto{}

	for selectTodosProdutos.Next() {
		var id int
		var nome, descricao string
		var preco float64
		var quantidade int

		err := selectTodosProdutos.Scan(&id, &nome, &descricao, &preco, &quantidade)
		if err != nil {
			panic(err.Error())
		}

		p.Nome = nome
		p.Descricao = descricao
		p.Preco = preco
		p.Quantidade = quantidade

		produtos = append(produtos, p)

	}
	defer db.Close()
	return produtos
}

func CriaNovoProduto(nome string, descricao string, preco float64, quantidade int) {
	db := db.ConectaBanco()
	criaProduto, err := db.Prepare("insert into produtos (nome, descricao, preco, quantidade) values (?, ?, ?, ?)")
	if err != nil {
		panic(err.Error())
	}
	criaProduto.Exec(nome, descricao, preco, quantidade)
	defer db.Close()
}
