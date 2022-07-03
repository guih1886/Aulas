function meuObjeto(){}
//console.log(meuObjeto.prototype)

const obj1 = new meuObjeto
const obj2 = new meuObjeto
//console.log(obj1.__proto__ === obj2.__proto__)
//console.log(meuObjeto.prototype === obj1.__proto__)

meuObjeto.prototype.nome = 'Anonimo'
meuObjeto.prototype.falar = function (){
    console.log(`Boa noite, meu nome é ${this.nome}`)
}

obj1.falar()
obj2.nome = 'Felipe'
obj2.falar()

const obj3 = {}
obj3.__proto__ = meuObjeto.prototype //mudando de objeto.prototype para meuobjeto.prototype
obj3.nome = 'Lucas'
obj3.falar()
