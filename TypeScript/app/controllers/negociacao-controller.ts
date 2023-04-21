import Negociacao from "../models/negociacao.js";
import { Negociacoes } from "../models/negociacoes.js";

export class NegociacaoController {
    private inputData: HTMLInputElement
    private inputQuantidade: HTMLInputElement
    private inputValor: HTMLInputElement
    private negociacoes = new Negociacoes();

    constructor() {
        this.inputData = document.querySelector("#data")
        this.inputQuantidade = document.querySelector("#quantidade")
        this.inputValor = document.querySelector("#valor")
    }

    adiciona(): void {
        const negociacao = new Negociacao(new Date(this.inputData.value.replace("-", ",")), parseInt(this.inputQuantidade.value), parseFloat(this.inputValor.value))
        this.negociacoes.adiciona(negociacao)
        console.log(this.negociacoes.listar());

        this.limparFormulario();
    }

    limparFormulario(): void {
        this.inputData.value = ''
        this.inputQuantidade.value = "1"
        this.inputValor.value = "0.0"
        this.inputData.focus();
    }
}