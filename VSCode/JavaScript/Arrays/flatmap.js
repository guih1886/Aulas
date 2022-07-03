const escola = [{
    nome: 'Turma 1',
    alunos: [{
        nome: 'Ana',
        nota: 3
    }, {
        nome: 'Pedro',
        nota: 5
    }
    ],
        nome: 'Turma 2',
    alunos: [{
        nome: 'José',
        nota: 8
    }, {
        nome: 'Serafim',
        nota: 10
    }]
}]

const getNota = aluno => aluno.nota
const notasDaTurma = turma => turma.alunos.map(getNota)
const notas1 = escola.map(notasDaTurma)
console.log(notas1)

Array.prototype.flatMap = function(callback){
    return Array.prototype.concat.apply([],this.map(callback))
}

const notas2 = escola.flatMap(getNota)
console.log(notas2)