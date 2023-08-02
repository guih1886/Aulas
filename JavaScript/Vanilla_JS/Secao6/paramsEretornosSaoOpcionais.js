function area(largura, altura) {
    const area = altura * largura
    if(area > 20){
        console.log('Valor da area excedido')
    }else{
        return area
    }
}

console.log(area(2,3))
console.log(area(2)) //operacao com undefined
console.log(area()) //operacao com undefined
console.log(area(2,3,4,5)) //ignora apos o segundo
console.log(area(10,20))
