const moduloA = require('../../moduloA') //caminho relativo
console.log(moduloA.bemVindo)

const saudacao = require('saudacao') // index em saudacao em node_modules
console.log(saudacao.bomDia)

const http = require('http')
http.createServer((req,res)=>{
    res.write('Bom dia')
    res.end()
}),listen(8080)