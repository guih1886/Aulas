const pessoa = {
    Nome: 'Ana',
    Idade: 27,
    Sexo: 'F'
}
console.log(Object.keys(pessoa))
console.log(Object.values(pessoa))
console.log(Object.entries(pessoa)) //chave, valor

Object.defineProperty(pessoa, 'DataNascimento', {
    enumerable: true,
    whitable: false,
    value: '01/01/2020'
})
pessoa.DataNascimento = '01/01/2019'
console.log(pessoa.DataNascimento)
console.log(Object.keys(pessoa))

//concatena objetos
const objDestino = { a: 1 }
const obj = { b: 3, c: 4 }
const obj2 = { d: 5, e: 8, a: 5 } //a será sobrescrito pelo ultimo valor
Object.assign(objDestino, obj, obj2)
console.log(objDestino)

Object.freeze(objDestino) //congela o obj e nao deixa ser alterado
objDestino.a = 10
console.log(objDestino)