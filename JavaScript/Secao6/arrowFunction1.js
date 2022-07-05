let dobro = function (a) {
    return a * 2
}

dobro = (a) => {
    return a * 2
}

dobro = a => a * 2 //arrow com retorno de 'return' implicito

console.log(dobro(4));

ola = () => 'Ola'
console.log(ola());