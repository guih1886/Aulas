const valores = [7,7,8.9,9.5]
console.log(valores[0],valores[3])

valores[4] = 10
console.log(valores[4])
console.log(valores.length)

valores.push(false, "teste", null, undefined)
console.log(valores)

console.log(valores.pop())
console.log(valores)

delete valores[0]
console.log(valores)
console.log(typeof valores)



