function verificaLados(lado1, lado2, lado3) {
    if (lado1 == lado2 && lado2 == lado3) {
        console.log('Equilátero')
    } else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1) {
        console.log('Isósceles')
    } else
    console.log('Escaleno')
}

verificaLados(1,1,1)
verificaLados(1,1,2)
verificaLados(1,2,3)