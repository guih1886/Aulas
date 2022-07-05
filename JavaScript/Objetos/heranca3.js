const pai = { nome: 'Pedro', corCabelo: 'Loiro' }

const filha1 = Object.create(pai)
//filha1.nome = 'Paula'
console.log(filha1.corCabelo)

const filha2 = Object.create(pai,{
    nome: {value: 'Bia', writable: false, enumerable: true},
    idade: {value: 28, writable: true, enumerable: true}
})
console.log(filha2)
filha2.nome = 'Clara'
console.log(`${filha2.nome} tem cor de cabelo ${filha2.corCabelo}`)

console.log(Object.keys(filha1))
console.log(Object.keys(filha2))

for(let key in filha2){
    filha2.hasOwnProperty(key) ?
        console.log(key) : console.log(`Por herança ${key}`)
}