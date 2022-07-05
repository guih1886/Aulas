const pessoa = {
    saudacao: 'Bom dia',
    falar(){
        console.log(this.saudacao); //this referencia o obj do bloco
    }
}

pessoa.falar()
const falar = pessoa.falar
falar() //conflito de paradigmas funcional e OO

const falarDePessoa = pessoa.falar.bind(pessoa) //bind referencia o obj para o this
falarDePessoa()