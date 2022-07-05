const fs = require('fs') // FILE SYSTEM

const caminho = __dirname + '/arquivo.json'

//sincrono
const conteudo = fs.readFileSync(caminho,'utf-8')
console.log(conteudo)

//assincrono
fs.readFile(caminho,'utf-8',(erro,conteudo)=>{
    const config = JSON.parse(conteudo)
    console.log(`${config.db.host}:${config.db.port}`)
})

const config = require('./arquivo.json')
console.log(config.db)

//leitura de uma pasta
fs.readdir(__dirname,(erro,arquivos)=>{
    console.log('Arquivos da pasta')
    console.log(arquivos)
})