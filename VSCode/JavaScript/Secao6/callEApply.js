function getPreco(imposto = 0, moeda = 'R$') {
    return moeda + this.preco * (1 - this.desc) * (1 + imposto)
}

const produto = {
    nome: 'Notebook',
    preco: 2000,
    desc: 0.15,
    getPreco
}

globalThis.preco = 20
globalThis.desc = 0.1
console.log(getPreco());
console.log(produto.getPreco());

const carro = {preco: 49000, desc: 0.3}

console.log(getPreco.call(carro))
console.log(getPreco.apply(carro))


console.log(getPreco.call(carro,0.15,'$')) //passagem de parametro na funcao
console.log(getPreco.apply(carro,[0.2,'$'])) //passagem de parametro dentro do array