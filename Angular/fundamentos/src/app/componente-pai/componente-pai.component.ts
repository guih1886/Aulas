import { Component } from '@angular/core';

@Component({
  selector: 'app-componente-pai',
  templateUrl: './componente-pai.component.html',
  styleUrls: ['./componente-pai.component.less']
})
export class ComponentePaiComponent {
  sobrenome = "Almeida";

  mostratNomeCompleto(nomeCompleto: any) {
    alert(`${nomeCompleto}`)
  }

}
