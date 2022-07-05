const fabricantes = ['Volvo', 'BMW', 'Mercedes', 'Ferrari']

function imprimir(fabricante, indice) {
    console.log(indice + 1, '.', fabricante);
}

fabricantes.forEach(imprimir)