class lancamento {
    constructor(nome = 'Generico', valor = 0) {
        this.nome = nome
        this.valor = valor
    }
}

class cicloFinanceiro {
    constructor(mes, ano) {
        this.mes = mes
        this.ano = ano
        this.lancamentos = []
    }

    
    addLancamentos(...lancamentos) {
        lancamentos.forEach(l => this.lancamentos.push[l])
    }


    sumario() {
        let valorConsolidado = 0
        this.lancamentos.forEach(l => {
            valorConsolidado += l.valor
        })
        return valorConsolidado
    }
}

const salario = new lancamento('Salario', 45000)
const contaLuz = new lancamento('Luz', 220)

const contas = new cicloFinanceiro(5, 2022)
contas.addLancamentos(salario)
console.log(contas.sumario())