// par nome/valor
const saudacao = 'Opa' //contexto lexico 1

function exerc() {
    const saudacao = 'Fala ai' //contexto lexico 2
    return saudacao
}

//objetos sao grupos aninhados de pares nome/valor
const cliente = {
    nome: 'Pedro',
    idade: 32,
    peso: 90,
    endereco: {
        logradouro: 'Rua dos bobos',
        numero: 0
    }
}

console.log(saudacao)
console.log(exerc())
console.log(cliente)
