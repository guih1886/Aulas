//armazenando uma funcao em uma variavel
const imprimirSoma = function (a, b) {
    console.log(a + b)
}
imprimirSoma(2, 5)

//armazenando uma funcao arrow em uma variavel
const soma = (a, b) => {
    return a + b
}
console.log(soma(8, 9))

//retorno implicito
const subtracao = (a, b) => a - b
console.log(subtracao(5, 10))

const imprimir = a => console.log(a)

imprimir('Nossa tia que maneiro')