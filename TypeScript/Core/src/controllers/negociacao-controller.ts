import { domInject } from "../decorators/domInject.js";
import { tempoExecucao } from "../decorators/tempo-de-execucao.js";
import { DiasDaSemana } from "../enums/diasDaSemana.js";
import Negociacao from "../models/negociacao.js";
import { Negociacoes } from "../models/negociacoes.js";
import { NegociacoesService } from "../services/negociacoes-service.js";
import { imprimir } from "../utils/imprimir.js";
import { MensagemView } from "../views/mensagem-view.js";
import { NegociacoesView } from "../views/negociacoesView.js";

export class NegociacaoController {
    @domInject("#data")
    private inputData: HTMLInputElement
    @domInject("#quantidade")
    private inputQuantidade: HTMLInputElement
    @domInject("#valor")
    private inputValor: HTMLInputElement
    private negociacoes = new Negociacoes();
    private negociacoesView = new NegociacoesView("#negociacoesView");
    private mensagemView = new MensagemView("#mensagemView")
    private negociacoesService = new NegociacoesService()

    constructor() {
        //comentado por conta do dominject
        /* //casting das duas formas, no final e no começo do retorno
        this.inputData = document.querySelector("#data") as HTMLInputElement
        this.inputQuantidade = <HTMLInputElement>document.querySelector("#quantidade")
        this.inputValor = document.querySelector("#valor") as HTMLInputElement */
        this.negociacoesView.update(this.negociacoes)
    }

    @tempoExecucao()
    public adiciona(): void {
        const negociacao = Negociacao.criaDe(this.inputData.value, this.inputQuantidade.value, this.inputValor.value)
        if (!this.eDiaSemana(negociacao.data)) {
            this.mensagemView.update("Somente dias úteis são permitidos para negociações.")
        } else {
            this.negociacoes.adiciona(negociacao)
            imprimir(negociacao, this.negociacoes)
            this.limparFormulario();
            this.atualizaView();
        }
    }

    private eDiaSemana(data: Date): boolean {
        return data.getDay() > DiasDaSemana.DOMINGO && data.getDay() < DiasDaSemana.SABADO
    }

    private limparFormulario(): void {
        this.inputData.value = ''
        this.inputQuantidade.value = "1"
        this.inputValor.value = "0.0"
        this.inputData.focus();
    }

    private atualizaView(): void {
        this.negociacoesView.update(this.negociacoes)
        this.mensagemView.update("Negociação adicionada com sucesso!")
    }

    importaDados(): void {
        this.negociacoesService.obterNegociacoes()
            .then(negociacoesDeHoje => {
                return negociacoesDeHoje.filter(negociacoesDeHoje => {
                    return !this.negociacoes.listar().some(negociacao => negociacao.ehIgual(negociacoesDeHoje))
                })
            }).then(negociacoesDeHoje => {
                for (let negociacao of negociacoesDeHoje) {
                    this.negociacoes.adiciona(negociacao)
                }
                this.negociacoesView.update(this.negociacoes)
            })
    }
}