import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-componente-personalizado',
  templateUrl: './componente-personalizado.component.html',
  styleUrls: ['./componente-personalizado.component.less']
})
export class ComponentePersonalizadoComponent {
  @Input() nome = "";
  @Input() sobrenome = "";

}
