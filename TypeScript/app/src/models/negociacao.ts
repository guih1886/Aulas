export default class Negociacao {
    constructor(
        private _data: Date,
        public readonly quantidade: number,
        public readonly valor: number) {
    }

    get volume(): number {
        return parseFloat((this.quantidade * this.valor).toFixed(2));
    }

    //programação defensiva, retorna o clone da data
    get data(): Date {
        const data = new Date(this._data.getTime())
        return data
    }

    public static criaDe(dataString: string, quantidadeString: string, valorString: string): Negociacao {
        return new Negociacao(
            new Date(dataString.replace("-", ",")),
            parseInt(quantidadeString),
            parseFloat(valorString)
        )
    }
}