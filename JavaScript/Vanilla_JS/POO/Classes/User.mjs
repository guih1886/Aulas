export default class User {

    //# é usado como o private, impedindo o acesso fora classe
    #nome
    #email
    #nascimento
    #role
    #ativo
    constructor(nome, email, nascimento, role, ativo = true) {
        this.#nome = nome
        this.#email = email
        this.#nascimento = nascimento
        this.#role = role || "estudante"
        this.#ativo = ativo
    }

    #montaObjeto() {
        return ({
            nome: this.#nome,
            email: this.#email,
            nascimento: this.#nascimento,
            role: this.#role,
            ativo: this.#ativo
        })
    }

    exibirInfos() {
        return `${this.nome}, ${this.email}, ${this.nascimento},${this.role}, ${this.ativo}`
    }

    get nome() {
        return `Acessando nome atraves do getter ${this.#nome}`
    }

    get email() {
        return this.#email
    }

    get nascimento() {
        return this.#nascimento
    }

    get role() {
        return this.#role
    }

    get ativo() {
        return this.#ativo
    }

    set nome(nome) {
        this.#nome = nome
    }

    set nascimento(nascimento) {
        this.#nascimento = nascimento
    }

    set role(role) {
        this.#role = role
    }

    set email(email) {
        this.#email = email
    }

    set ativo(ativo) {
        this.#ativo = ativo
    }

}


