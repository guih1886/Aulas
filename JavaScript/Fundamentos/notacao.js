console.log(Math.ceil(1.46))

const objt = {}
objt.nome = 'Bola'

console.log(objt.nome)

function Obj(nome){
    this.nome = nome 
    this.exec = function(){
        console.log('Exerc...')
    }
}

const obj2 = new Obj('Cadeira')
const obj3 = new Obj('Mesa')
console.log(obj2.nome)
console.log(obj3.nome)
obj3.exec()