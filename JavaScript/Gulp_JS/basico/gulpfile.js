const gulp = require('gulp')
const { series, parallel } = require('gulp')

const raiz = gulp.src(['pastaA/arquivo1.txt','pastaA/arquivo2.txt']) // selecao especifico
const raiz2 = gulp.src(['pastaA/**/*.txt']) // selecao geral

const inicio = cb => {
    console.log('Iniciando a Task.')
    return cb()
}

function copiar(cb) {
    console.log('Copy task.')
    raiz.pipe(gulp.dest('pastaB'))
    raiz2.pipe(gulp.dest('pastaB'))
    return cb()
}

const fim = cb => {
    console.log('Terminando a Task.')
    return cb()
}

module.exports.default = series(inicio, copiar, fim)