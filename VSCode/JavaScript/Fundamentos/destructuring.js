const pessoa = {
    nome: 'José',
    idade: 30,
    cpf: '436.096.408-04',
    endereço: {
        rua: 'Rua dos bobos',
        numero: 10,
    }
}

//console.log(pessoa)

const {endereço: {rua, numero}} = pessoa //destruturacao de pessoa
const {endereço: {rua: n, numero: i}} = pessoa //destruturacao de pessoa, criando variaveis
const {nome, idade} = pessoa


console.log(n, i)
console.log(nome, idade)
console.log(pessoa.cpf)