export class Negociacoes {
    constructor() {
        this.negociacoes = [];
    }
    adiciona(negociacao) {
        this.negociacoes.push(negociacao);
    }
    listar() {
        return [...this.negociacoes];
    }
    paraTexto() {
        return `${this.negociacoes}`;
    }
    ehIgual(objeto) {
        return JSON.stringify(this.negociacoes) === JSON.stringify(objeto.listar());
    }
}
//# sourceMappingURL=negociacoes.js.map