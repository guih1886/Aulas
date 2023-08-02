const produtos = [
    { nome: 'Computador', preco: 900, fragil: true },
    { nome: 'Capacete', preco: 900, fragil: false },
    { nome: 'Copo', preco: 1000.50, fragil: true }
]

/*console.log(produtos.filter(function(p){
    return p.preco > 500
}))
console.log(produtos.filter(p => p.preco > 500))*/

const fragil = p => p.fragil == true
const valor = p => p.preco > 500

console.log(produtos.filter(fragil).filter(valor))

