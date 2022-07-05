function jurosSimples(inicial,juros,tempo){
    let montante = (inicial * juros) * tempo
    return montante
}

function jurosCompostos(inicial,juros,tempo){
  let montante = 0 
  montante += (inicial * juros) * tempo
  return montante
}

console.log(jurosSimples(10,10,4))
console.log(jurosCompostos(10,10,4))