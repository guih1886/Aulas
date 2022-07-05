function aula(nome, videoId) {
    this.nome = nome
    this.videoId = videoId
}

const aula1 = new aula('Bem vindo', 123)
const aula2 = new aula('Até logo', 456)
console.log(aula1, aula2)

//simulando o new
function novo(f, ...params) {
    const obj = {}
    obj.__proto__ = f.prototype
    f.apply(obj, params)
    return obj
}

const aula3 = novo(aula, 'Ola', 123)
const aula4 = novo(aula, 'Teste', 456)
console.log(aula3, aula4)

