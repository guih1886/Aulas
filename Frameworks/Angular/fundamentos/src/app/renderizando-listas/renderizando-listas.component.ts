import { Component } from '@angular/core';
import { Celular } from '../types/Celular';

@Component({
  selector: 'app-renderizando-listas',
  templateUrl: './renderizando-listas.component.html',
  styleUrls: ['./renderizando-listas.component.less']
})
export class RenderizandoListasComponent {
  celulares: Celular[] = [
    { id: 1, nome: "Celular P", descricao: "Celular pequeno", esgotado: false },
    { id: 2, nome: "Celular M", esgotado: false },
    { id: 3, nome: "Celular XL", descricao: "Celular extra grande", esgotado: true },
  ]

}
