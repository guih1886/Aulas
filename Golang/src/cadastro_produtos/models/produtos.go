package models

import "F-GO/cadastro_produtos/db"

type Produto struct {
	Id, Quantidade  int
	Nome, Descricao string
	Preco           float64
}

func BuscaTodosOsProdutos() []Produto {
	db := db.ConectaBanco()
	selectTodosProdutos, err := db.Query("select * from produtos order by id asc")

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

		p.Id = id
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

func DeletaProduto(idProduto string) {
	db := db.ConectaBanco()
	deletarProduto, err := db.Prepare("delete from produtos where id = ?")
	if err != nil {
		panic(err.Error())
	}
	deletarProduto.Exec(idProduto)
	defer db.Close()
}

func AtualizaProduto(id int, nome string, descricao string, preco float64, quantidade int) {
	db := db.ConectaBanco()
	atualizaProduto, err := db.Prepare("update produtos set nome=?, descricao=?, preco=?, quantidade=? where id = ?")
	if err != nil {
		panic(err.Error())
	}
	atualizaProduto.Exec(nome, descricao, preco, quantidade, id)
	defer db.Close()
}

func BuscarPorId(idProduto string) Produto {
	db := db.ConectaBanco()
	produto, err := db.Query("select * from produtos where id = ?", idProduto)
	if err != nil {
		panic(err.Error())
	}

	produtoBanco := Produto{}

	for produto.Next() {
		var id, quantidade int
		var nome, descricao string
		var preco float64

		err := produto.Scan(&id, &nome, &descricao, &preco, &quantidade)
		if err != nil {
			panic(err.Error())
		}

		produtoBanco.Id = id
		produtoBanco.Nome = nome
		produtoBanco.Descricao = descricao
		produtoBanco.Preco = preco
		produtoBanco.Quantidade = quantidade
	}
	defer db.Close()
	return produtoBanco
}
