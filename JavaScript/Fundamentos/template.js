const nome = "Rebeca"
const concatenacao = "Olá " + nome + "!"
const template = `Olá ${nome}!`

console.log(concatenacao)

//expressoes
console.log(`1 + 1 = ${1+1}`)


const up = texto => texto.toUpperCase()
console.log(`Ei, ${up("cuidado")}!`)

console.log(`${up(concatenacao)}`)

