//funcoes middlewares

const express = require("express")
const app = express()
const bodyParser = require("body-parser")
const saudacao = require("./saudacaoMid.js")
const usuarioApi = require("./api/usuarios")
const param = require("./api/produtos")(app, "com param!")

app.use(saudacao("Guilherme"))

app.get("/param", param.obter)


app.post("/usuario", usuarioApi.salvar)
app.get("/usuario", usuarioApi.obter)

app.use(bodyParser.text())
app.use(bodyParser.json())
app.use(bodyParser.urlencoded({ extended: true }))

app.post("/corpo", (req, resp) => {
    /*     let corpo = ""
        req.on("data", function (parte) {
            corpo += parte
        })
        req.on("end", function () {
            resp.send(corpo)
        }) */
    resp.send(req.body)
})

app.get("/clientes/relatorio", (req, resp) => {
    resp.send(`Cliente relatório: completo = ${req.query.completo} ano = ${req.query.ano}`)
})

app.use("/clientes/:id", (req, resp, next) => {
    resp.send(`Cliente ${req.params.id} selecionado!`)
    next()
})

app.use("/opa", (req, resp, next) => {
    console.log("Executando passo 1...");
    next()
})

app.use("/opa", (req, resp, next) => {
    console.log("Executando passo 2...");
    resp.json({
        name: "iPhone",
        price: 1800.99,
        discount: 0.12,
        color: "Black"
    })
    next()
})

app.use("/opa", (req, resp) => {
    console.log("Executando passo 3...");
    //resp.send("<h1>Estou enviando respostas no passo 3!</h1>")
})

app.listen(3000, () => {
    console.log("Backend executando.");
})