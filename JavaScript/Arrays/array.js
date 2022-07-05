let aprovados = new Array('Bia', 'Josefa', 'Frederico')
console.log(aprovados)

//forma literal (boa pratica)
aprovados = ['José', 'Raimundo', 'Cleber']
console.log(aprovados[0])
console.log(aprovados[1])
console.log(aprovados[2])
//console.log(aprovados[3])
aprovados[3] = 'Carlos'
console.log(aprovados[3])
aprovados.push('Ronaldo') //
console.log(aprovados.length)
console.log(aprovados)
aprovados.pop()
console.log(aprovados.length)
console.log(aprovados)

//criando um registro no indice 9
aprovados[9] = 'Pedro'
console.log(aprovados) // os valores entre o indice 3 e 9 ficarão como UNDEFINED
console.log(aprovados[8] === undefined)
console.log(aprovados[8] === null)
aprovados.sort() //ordena o array e joga os undefined para o fim
console.log(aprovados)


//metodo splice tanto deleta quanto adiciona no array, a partir de um indice
let reprovados = ['João', 'Mário', 'Danilo']
reprovados.splice(1, 1) //sintaxe - 1 (inicio do indice) , 2 quantidade de deletes , adicionar 
console.log(reprovados)
reprovados.splice(3, 0, 'Raony', 'Nerivan')
console.log(reprovados)