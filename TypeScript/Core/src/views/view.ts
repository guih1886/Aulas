export abstract class View<T> {

    protected elemento: HTMLElement

    constructor(seletor: string) {
        if (seletor) {
            this.elemento = document.querySelector(seletor) as HTMLElement
        } else {
            throw new Error(`Seletor ${seletor} não existe no DOM. Verifique.`)
        }
    }

    protected abstract template(model: T): string;

    public update(model: T): void {
        let template = this.template(model)
        this.elemento.innerHTML = template
    }

}