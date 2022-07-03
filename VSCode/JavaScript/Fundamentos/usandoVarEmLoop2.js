const funcs = []
const funcs2 = []

for (var i = 0; i < 10; i++) {
    funcs.push(function () {
        console.log(i)
    })
}

funcs[2]()
funcs[8]()

for (let a = 0; a < 10; a++) {
    funcs2.push(function () {
        console.log(a)
    })
}

funcs2[2]()
funcs2[8]()