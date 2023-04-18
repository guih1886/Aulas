import chalk from 'chalk';
import fs from 'fs'

function trataErro(erro) {
    throw new Error(erro);
}

function lerArquivo(arquivo) {
    const encoding = 'utf-8'
    fs.readFile(arquivo, encoding, (erro, texto) => {
        if (erro) {
            trataErro(erro)
        } else {
            console.log(chalk.green(texto));
        }
    })
}

lerArquivo("c:\\Users\\guilh\\Documents\\GitHub\\Aulas\\Node\\alura\\texto.md")