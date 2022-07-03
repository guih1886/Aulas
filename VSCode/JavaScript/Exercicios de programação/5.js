function maiorOuIgual(primeiro, segundo) {
    if(typeof primeiro != typeof segundo) return false
    return primeiro >= segundo
    }
    

maiorOuIgual(0, 0)
maiorOuIgual(0, '0')
maiorOuIgual(5, 8)