const a = 1
const b = 2
const c = 3
const obj = { a, b, c }
console.log(obj)

const nomeNota = 'Nota'
const valorNota = 7.85

const obj3 = {}
obj3[nomeNota] = valorNota
console.log(obj3)

const obj4 = { [nomeNota]: valorNota }
console.log(obj4)

const obj5 = {
    funcao1: function(){
        //forma antiga
    },
    funcao2(){
        //forma nova
    }
}
console.log(obj5)