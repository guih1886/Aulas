// pessoa -> 123 -> (...)
const pessoa = { nome: 'Joao' }
pessoa.nome = 'Pedro'
console.log(pessoa)

//pessoa <- 456 -> (...)
/*pessoa = {nome: 'Ana'}*/

Object.freeze(pessoa)

pessoa.nome = 'maria'
pessoa.end = 'rua abc'
delete pessoa.nome
console.log(pessoa.nome)
console.log(pessoa)

const pessoaConstante = Object.freeze({nome: 'Flavia'})
delete pessoaConstante
console.log(pessoaConstante)

