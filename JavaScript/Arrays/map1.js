const nums = [1, 2, 3, 4, 10]

//é um for com proposito. Retorna um array com a mesma quantida de indice com uma funcao
let result = nums.map(e => e * 2)

console.log(result)

const soma10 = e => e + 10
const triplo = e => e * 3
const paraDinheiro = e => `R$${parseFloat(e).toFixed(2).replace('.',',')}`

resultado = result.map(triplo).map(soma10).map(paraDinheiro)
console.log(resultado)