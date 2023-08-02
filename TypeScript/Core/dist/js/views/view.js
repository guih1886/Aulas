export class View {
    constructor(seletor) {
        if (seletor) {
            this.elemento = document.querySelector(seletor);
        }
        else {
            throw new Error(`Seletor ${seletor} não existe no DOM. Verifique.`);
        }
    }
    update(model) {
        let template = this.template(model);
        this.elemento.innerHTML = template;
    }
}
//# sourceMappingURL=view.js.map