{//nao pode adicinar atributos, porem consegue deletar e modificar os existentes
const produto = Object.preventExtensions({
    nome: 'Primeiro', preco: 2.50, tag: 'Promoção'
})
const produto2 = {}
console.log('Extensivel? ',Object.isExtensible(produto)) //verifica se é extensivel
console.log('Extensivel? ',Object.isExtensible(produto2)) //verifica se é extensivel

produto.nome = 'Segundo'
produto.descricao = 'Número 3'
delete produto.tag
console.log(produto)
}

{//objetct.seal
 //nao é possivel adicionar ou deletar, somente modificar os atributos

 const pessoa = {
     nome: 'Jenifer',
     idade: 30
 }
 Object.seal(pessoa)
console.log('Selado?: ', Object.isSealed(pessoa))

pessoa.sobrenome = 'Silva'
delete pessoa.nome
pessoa.idade = 29
console.log(pessoa)
}

{//freeze - igual o seal, porem sem poder modificar os atributos
    Object.freeze(pessoa)
}