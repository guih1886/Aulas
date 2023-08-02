export function tempoExecucao(emSegundos = false) {
    return function (target, propertyKey, descriptor) {
        const metodoOriginal = descriptor.value;
        descriptor.value = function (...args) {
            const t1 = performance.now();
            const retorno = metodoOriginal.apply(this, args);
            const t2 = performance.now();
            emSegundos ?
                console.log(`${propertyKey}, executada em ${(t2 - t1) / 1000} milisegundos`)
                :
                    console.log(`${propertyKey}, executada em ${(t2 - t1) / 100} segundos`);
            retorno;
        };
        return descriptor;
    };
}
//# sourceMappingURL=tempo-de-execucao.js.map