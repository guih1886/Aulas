import { Modelo } from "../interfaces/modelo.js";

export default class Negociacao implements Modelo<Negociacao>{
    constructor(
        private _data: Date,
        public readonly quantidade: number,
        public readonly valor: number) { }

    public paraTexto(): string {
        return `${this.data}`
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

    public ehIgual(negociacao: Negociacao): boolean {
        return this.data.getDate() === negociacao.data.getDate() &&
            this.data.getMonth() === negociacao.data.getMonth() &&
            this.data.getFullYear() === negociacao.data.getFullYear()
    }
}