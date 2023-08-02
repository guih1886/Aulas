import User from "./User.mjs";

export default class Admin extends User {
    constructor(nome, email, nascimento, role = "admin", ativo = true) {
        super(nome, email, nascimento, role, ativo);
    }

    exibirInfos() {
        return `Polimorfismo acessando ${this.nome}, ${this.ativo}`
    }

    criarCurso(nomeDoCurso, vagas) {
        return `Curso de ${nomeDoCurso} criado com ${vagas} vagas.`
    }
}

