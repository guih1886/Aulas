//estrategia 1 para gerar valor padrao
function soma1(a, b, c) {
    a = a || 1
    b = b || 1
    c = c || 1
    return a + b + c
}
console.log(soma1())
console.log(soma1(1))
console.log(soma1(3, 1, 2))

//estrategia 2, 3 e 4 para gerar valor padrao
function soma2(a, b, c) {
    //a = a !== undefined ? a : 1
    //b = b in arguments ? b : 1
    a = isNaN(a) ? 0 : a
    b = isNaN(b) ? 0 : b
    c = isNaN(c) ? 0 : c
    return a + b + c
}
console.log(soma2(), soma2(3), soma2(1, 2, 3), soma2(0, 0, 0), soma2('a', 'b', 'c'))

function soma3(a = 1, b = 1, c = 1) {
    return a + b + c
}

console.log(soma3(),soma3(1),soma3(2,2,1),soma3(0,0,0),soma3('a','b','c'))
