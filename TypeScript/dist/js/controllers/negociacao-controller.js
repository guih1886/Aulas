import Negociacao from "../models/negociacao.js";
import { Negociacoes } from "../models/negociacoes.js";
export class NegociacaoController {
    constructor() {
        this.negociacoes = new Negociacoes();
        this.inputData = document.querySelector("#data");
        this.inputQuantidade = document.querySelector("#quantidade");
        this.inputValor = document.querySelector("#valor");
    }
    adiciona() {
        const negociacao = new Negociacao(new Date(this.inputData.value.replace("-", ",")), parseInt(this.inputQuantidade.value), parseFloat(this.inputValor.value));
        this.negociacoes.adiciona(negociacao);
        console.log(this.negociacoes.listar());
        this.limparFormulario();
    }
    limparFormulario() {
        this.inputData.value = '';
        this.inputQuantidade.value = "1";
        this.inputValor.value = "0.0";
        this.inputData.focus();
    }
}
