const anonimo = process.argv.indexOf('-a') !== -1

if (anonimo) {
    process.stdout.write('Fala anonimo!')
    process.exit()
} else {
    process.stdout.write('Informe seu nome: ')
    process.stdin.on('data', data => {
        const nome = data.toString()

        process.stdout.write(`Fala ${nome}!`)
        process.exit()
    })

}