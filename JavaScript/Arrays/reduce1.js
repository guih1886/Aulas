const alunos = [
    { nome: 'Ana', nota: 2.5, bolsista: true },
    { nome: 'José', nota: 3, bolsista: false },
    { nome: 'Mário', nota: 9, bolsista: true },
    { nome: 'Pedro', nota: 10, bolsista: false }
]

//reduz um valor do array, como somar o valor das notas por exemplo
console.log(alunos.map(a => a.nota))
const resultado = alunos.map(a=>a.nota).reduce(function(anterior,atual){
    console.log(anterior, atual)
    return anterior+atual
}, /*10 inicializando com 10*/)
console.log(resultado)
