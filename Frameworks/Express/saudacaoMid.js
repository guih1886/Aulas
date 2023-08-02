function saudacao(nome) {
    return function (req, resp, next) {
        console.log(`Olá, seja bem vindo ${nome}!`)
        next()
    }
}

module.exports = saudacao