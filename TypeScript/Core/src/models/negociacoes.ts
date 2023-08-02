import { Modelo } from "../interfaces/modelo.js";
import Negociacao from "./negociacao.js";

export class Negociacoes implements Modelo<Negociacoes> {
    private negociacoes: Negociacao[] = []

    public adiciona(negociacao: Negociacao) {
        this.negociacoes.push(negociacao)
    }

    public listar(): readonly Negociacao[] {
        return [...this.negociacoes]
    }

    public paraTexto(): string {
        return `${this.negociacoes}`
    }

    ehIgual(objeto: Negociacoes): boolean {
        return JSON.stringify(this.negociacoes) === JSON.stringify(objeto.listar())
    }
}