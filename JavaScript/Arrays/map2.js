const carrinho = [
    '{"nome": "Borracha", "preco": 3.45}'
]

//retornar um array com os preços
const paraObj = json => JSON.parse(json)
const apenasPreco = produto => produto.preco

const result = carrinho.map(paraObj).map(apenasPreco)
console.log(result)