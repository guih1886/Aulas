export function tempoExecucao(emSegundos: boolean = false) {
    return function (
        target: any,
        propertyKey: string,
        descriptor: PropertyDescriptor
    ) {
        const metodoOriginal = descriptor.value
        descriptor.value = function (...args: any[]) {
            const t1 = performance.now()
            const retorno = metodoOriginal.apply(this, args)
            const t2 = performance.now()
            emSegundos ?
                console.log(`${propertyKey}, executada em ${(t2 - t1) / 1000} milisegundos`)
                :
                console.log(`${propertyKey}, executada em ${(t2 - t1) / 100} segundos`)
            retorno
        }

        return descriptor
    }
}