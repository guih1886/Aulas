import User from "./User.mjs";

export default class Docente extends User {
    constructor(nome, email, nascimento, role = "docente", ativo = true) {
        super(nome, email, nascimento, role, ativo);
    }

    aprovaEstudante(estudante, curso) {
        return `Estudante ${estudante} aprovado no curso ${curso}.`
    }
}
