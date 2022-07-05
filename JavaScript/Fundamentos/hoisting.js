//hoisting é o içamento, aonde o depurador joga a variavel para o topo de modo a ficar acessivel

console.log('a = ', a)

var a = 0

console.log('a = ', a)

/* o códifo acima é posso se fosse
var a
console.log('a = ', a)
a = 0
console.log('a = ', a)
*/