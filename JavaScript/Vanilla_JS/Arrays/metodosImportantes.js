const frutas = ['Pera', 'Banana', 'Maça']
frutas.pop() //remove do ultimo indice
console.log(frutas)
frutas.push('Abacaxi') // adiciona no ultimo indice
console.log(frutas)

frutas.shift() // remove do primeiro indice
console.log(frutas)
frutas.unshift('Abacate') // adiciona no primeiro indice
console.log(frutas)

//metodo para adicionar e remover
frutas.splice(2, 0, 'Laranja', 'Pera', 'Amora')
console.log(frutas)
frutas.splice(2, 1)
console.log(frutas)

//metodo slice (pedaço)
console.log()
let frutas2 = frutas.slice(2) //pega um pedeço do array apartir do indice do param até o final
console.log(frutas2)
frutas2 = frutas.slice(1, 3) //pega um pedeço do array apartir do indice do param até o segundo indice SEM retornar ele
console.log(frutas2)
