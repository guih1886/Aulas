const user = {
    nome: "Guilherme Henrique",
    email: "guilherme_18henrique@yahoo.com.br",
    nascimento: "07/05/1994",
    role: "admin",
    ativo: true,
    exibirDados: function () {
        console.log(this.nome, this.email);
    }
}

const admin = {
    nome: "Silvana",
    email: "sil@gmail.com",
    role: "admin",
    criarCurso: function () { console.log("curso criado"); }
}

//extendendo a "classe" de user
Object.setPrototypeOf(admin, user)
admin.exibirDados();
admin.criarCurso();


/* const exibir = function () {
    console.log(this.nome);
}

const mostra = exibir.bind(user)

mostra() */