function Carro(velocidadeMaxima = 200, aceleracao = 5) {
    //atributo privado
    let velocidadeAtual = 0
    //metodo publico
    this.acelerar = function () {
        if (velocidadeAtual + aceleracao <= velocidadeMaxima) {
            velocidadeAtual += aceleracao
        } else {
            velocidadeAtual = velocidadeMaxima
        }
    }
    //metodo publico
    this.getVelocidadeAtual = function () {
        return velocidadeAtual
    }
}
const uno = new Carro
uno.acelerar()
console.log(uno.getVelocidadeAtual())
