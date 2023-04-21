export default class Negociacao {
    constructor(_data, quantidade, valor) {
        this._data = _data;
        this.quantidade = quantidade;
        this.valor = valor;
    }
    get volume() {
        return parseFloat((this.quantidade * this.valor).toFixed(2));
    }
    //programação defensiva, retorna o clone da data
    get data() {
        const data = new Date(this._data.getTime());
        return data;
    }
}
