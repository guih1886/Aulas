const notas = [7, 6.5, 8, 5, 9, 2, 3.5, 2, 0]

//sem callback
let notasBaixas = []
for(let i in notas){
    if(notas[i]<7){
        notasBaixas.push(notas[i])
    }
}
console.log(notasBaixas);

//com callback
const notasRuins = notas => notas < 7
const notasBaixas2 = notas.filter(notasRuins)
console.log(notasBaixas2)