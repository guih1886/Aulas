//criando objetos de forma literal
const obj = {}
console.log(obj)

//criando objetos em JS
const obj2 = new Object
console.log(obj2)

//funcoes construtoras
function produto(nome, preco, cor, desc) {
    this.nome = nome
    this.preco = preco
    this.cor = cor
    this.getPrecoComDesconto = () => {
        return preco * (1 - desc)
    }
}
const prod1 = new produto('teste', 20, 'branco',1)
console.log(prod1.desc)

//funcao factory
function criarFuncionario(nome, idade, salario){
    return{
        nome,
        idade,
        salario
    }
}
const f1 = criarFuncionario('Joaquim',50,3000)
const f2 = criarFuncionario('Fernando',28,4500)

//object.create
const filha = Object.create(null)
filha.nome = 'ana'
console.log(filha)