export function domInject(seletor: string) {
    return function (target: any, propertyKey: string) {
        let elemento: HTMLElement

        const getter = function () {
            if (!elemento) {
                elemento = <HTMLElement>document.querySelector(seletor)
                console.log(`Acessando domInjector`);

            }
            return elemento
        }

        //modifica o getter do método
        Object.defineProperty(target, propertyKey, { get: getter })
    }
}