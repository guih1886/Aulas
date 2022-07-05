const fs = require('fs')

const produto = {
    nome: 'Faca',
    preco: 15.99,
    comissao: 3
}

fs.writeFile(__dirname + '/arquivoGerado.json',JSON.stringify(produto), err => {
    console.log(err)
})