const numeros = [1,2,3,4,5,6,7,8,9,10]

for(let x in numeros){
    if(x == 5){
        break
    }
    console.log('X=',+x, 'i=',+ numeros[x])
}

console.log()
console.log()

for(let x in numeros){
    if(x == 5){
        continue
    }
    console.log('X=',+x, 'i=',+ numeros[x])
}