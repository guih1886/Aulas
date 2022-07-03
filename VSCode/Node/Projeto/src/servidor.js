const porta = 3003
const express = require('express')
const app = express()
const bancoDados = require('./bancoDados')
const bodyParser = require('body-parser')

app.use(bodyParser.urlencoded({extended: true}))

app.get('/produtos', (req, res, next) => {
    //res.send({ nome: 'Notebook', preco: 1500 }) //metodo send coverte para json
    res.send(bancoDados.getProdutos())
})

app.get('/produtos:id', (req, res, next) => {
    res.send(bancoDados.getProduto(req.params.id))
})

app.post('/produtos', (req,res,next)=>{
    const produto = bancoDados.salvarProduto({
        nome: req.body.nome,
        preco: req.body.preco
    })
    res.send(produto) //JSON
})

app.listen(porta, () => {
    console.log(`Servidor executando na porta ${porta}.`)
})
