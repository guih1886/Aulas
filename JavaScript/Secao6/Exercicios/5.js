function recebe(valorQuebrado){
     valorCorreto = 'R$' + valorQuebrado.toFixed(2).toString().replace('.',',')
     return console.log(valorCorreto)
}
recebe(0.300002)