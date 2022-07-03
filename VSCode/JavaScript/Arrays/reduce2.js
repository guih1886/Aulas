const alunos = [
    { nome: 'Ana', nota: 2.5, bolsista: true },
    { nome: 'José', nota: 3, bolsista: true },
    { nome: 'Mário', nota: 9, bolsista: true },
    { nome: 'Pedro', nota: 10, bolsista: false }
]

//desafio 1: Todos os alunos são bolsistas?
const todosBolsistas = function (resultado, bolsista) {
    return resultado && bolsista
}
if (alunos.map(a => a.bolsista).reduce(todosBolsistas) == false) {
    console.log('Não são todos bolsistas.')
} else
    console.log('São todos bolsistas!')

//desafio 2: algum aluno é bolsista
const algumBolsista = (resultado, bolsista) => resultado || bolsista
if (alunos.map(a => a.bolsista).reduce(algumBolsista) == true) {
    console.log('Temos bolsistas.')
} else
    console.log('Não temos bolsistas!')