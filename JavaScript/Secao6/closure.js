//closure é o escopo criando quando uma função é declarada
//esse escopo permite a funcao acessar e manipular variaveis externas a funcao
const x = 'Global'

function fora(){
    const x = 'Local'
    function dentro(){
        return x
    }
    return dentro()
}
const minhaFuncao = fora()
console.log(minhaFuncao)