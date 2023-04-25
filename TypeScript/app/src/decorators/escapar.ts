export function escapar(
    target: any,
    propertyKey: string,
    descriptor: PropertyDescriptor
) {
    const modeloOrig = descriptor.value
    descriptor.value = function (...args: any[]) {
        let retorno = modeloOrig.apply(this, args)
        if (typeof retorno === 'string') {
            console.log(`Escape em ação na classe ${this.constructor.name} ${modeloOrig.name} `);
            retorno = retorno.replace(/<script>[\s\S]*?<\/script>/, '')
        }
        return retorno
    }
    return descriptor
}