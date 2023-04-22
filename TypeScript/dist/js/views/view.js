export class View {
    constructor(seletor, escapar) {
        this.escapar = false;
        if (seletor) {
            this.elemento = document.querySelector(seletor);
        }
        else {
            throw new Error(`Seletor ${seletor} não existe no DOM. Verifique.`);
        }
        if (escapar) {
            this.escapar = escapar;
        }
    }
    update(model) {
        let template = this.template(model);
        if (this.escapar) {
            template = template.replace(/<script>[\s\S]*?<\/script>/, '');
        }
        this.elemento.innerHTML = template;
    }
}
