function User(nome, email) {
    this.nome = nome
    this.email = email
    this.exibirInfo = () => { return `${this.nome} ${this.email}` }
}


const novoUser = new User("Guilherme", "g@g.com")
console.log(novoUser.exibirInfo());

//faz a chamada dos prototipos de user por meio do call para Admin
function Admin(role) {
    User.call(this, 'juliana', 'j@j.com')
    this.role = role || 'estudante'
}

//o prototipo do admin recebe os de user mais o 'role'
Admin.prototype = Object.create(User.prototype);
const novoUserAdmin = new Admin('admin');
console.log(novoUserAdmin.exibirInfo());
console.log(novoUserAdmin.role);

{
    const user = {
        init: function (nome, email) {
            this.nome = nome
            this.email = email
        },
        exibirInfo: function (nome) {
            return nome
        }
    }

    const novoUser3 = Object.create(user)
    console.log(novoUser3.exibirInfo("Guilherme Oliveira"));
    console.log(user.isPrototypeOf(novoUser3));
}

{
    const user = {
        init: function (nome, email) {
            this.nome = nome
            this.email = email
        },
        exibirInfo: function () {
            return this.email
        }
    }
    //init age como um construtor da classe
    const novoUser4 = Object.create(user)
    novoUser4.init("Guilherme", "Almeida")
    console.log(novoUser4.exibirInfo());
}