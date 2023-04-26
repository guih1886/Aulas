export default class Negociacao {
    constructor(_data, quantidade, valor) {
        this._data = _data;
        this.quantidade = quantidade;
        this.valor = valor;
    }
    paraTexto() {
        return `${this.data}`;
    }
    get volume() {
        return parseFloat((this.quantidade * this.valor).toFixed(2));
    }
    get data() {
        const data = new Date(this._data.getTime());
        return data;
    }
    static criaDe(dataString, quantidadeString, valorString) {
        return new Negociacao(new Date(dataString.replace("-", ",")), parseInt(quantidadeString), parseFloat(valorString));
    }
    ehIgual(negociacao) {
        return this.data.getDate() === negociacao.data.getDate() &&
            this.data.getMonth() === negociacao.data.getMonth() &&
            this.data.getFullYear() === negociacao.data.getFullYear();
    }
}
//# sourceMappingURL=negociacao.js.map