let isAtivo = true
console.log(isAtivo)

isAtivo = false
console.log(isAtivo)

isAtivo = 1
console.log(!!false)
console.log(!false)

console.log("os verdadeiros")
console.log(!!3)
console.log(!!-1)
console.log(!!" ")
console.log(!!"texto")
console.log(!![]) //ARRAY
console.log(!!{}) //FUNCAO
console.log(!!Infinity)
console.log(!!(isAtivo = true))

console.log("os falsos")
console.log(!!0)
console.log(!!"")
console.log(!!null)
console.log(!!NaN)
console.log(!!undefined)
console.log(!!(isAtivo = false))


let nome = 'mateus';
console.log(nome, "OR", 'Desconhecido')