//funcao sem retorno de js
function imprimirSoma(a, b) {
    console.log(a + b)
}

imprimirSoma(10, 25)
imprimirSoma(10)
imprimirSoma(10, 5, 7, 6, 9, 8, 7)

imprimirSoma()


//funcao com retorno
function soma(a, b = 0) {
    return a + b
}

console.log(soma(1, 2))
console.log(soma(8))