let pontos = [10, 20, 20, 8, 25, 3, 0, 30, 1]

function comparaValores(a) {
    let recorde = 0
    let pior = 0
    let result = []
    for (i in a) {
        if (a[i] > a[i - 1]) {
            recorde++
        }
        if (a[i] < a[i - 1]) {
            if (pior > a[i]) {
                pior = i
            }
        }
    }
    result[0] = recorde
    result[1] = pior
    return console.log(result)
}
comparaValores(pontos)