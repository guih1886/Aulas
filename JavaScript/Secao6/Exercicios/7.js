function bhaskara(ax2, bx, c) {
    let delta = (bx ** 2) - 4 * ax2 * c
    let div = 2 * ax2
    let retorno = []
    if (Math.sign(delta) == -1) {
        return console.log('Delta é negativo')
    } else {
        retorno[0] = (-bx + Math.sqrt(delta)) / div
        retorno[1] = (-bx - Math.sqrt(delta)) / div
        return console.log(retorno)
    }
}
bhaskara(1, 8, -9)
