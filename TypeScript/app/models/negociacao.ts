export default class Negociacao {
    constructor(
        private _data: Date,
        private readonly quantidade: number,
        private readonly valor: number) {
    }

    get volume(): number {
        return parseFloat((this.quantidade * this.valor).toFixed(2));
    }

    //programação defensiva, retorna o clone da data
    get data(): Date {
        const data = new Date(this._data.getTime())
        return data
    }
}