import { Component, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-componente-filho',
  templateUrl: './componente-filho.component.html',
  styleUrls: ['./componente-filho.component.less']
})
export class ComponenteFilhoComponent {
  @Input() sobrenome = "";
  nome = "Guilherme";
  @Output() mostraNome = new EventEmitter();
}
