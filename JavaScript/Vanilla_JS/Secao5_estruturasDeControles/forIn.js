const notas = [6, 7, 9, 8, 6, 2, 4, 6]

/*for(let i in notas){
    console.log(i, notas[i])
}*/

const pessoa ={
    nome: 'Julia',
    idade: 27,
    sexo: 'F',
    altura: '1,67',
    peso: 30
}

for(let atributo in pessoa){
    console.log(atributo, pessoa[atributo])
}