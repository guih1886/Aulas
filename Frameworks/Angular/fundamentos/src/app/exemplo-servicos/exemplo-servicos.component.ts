import { Component } from '@angular/core';
import { LoggerService } from '../services/logger.service';

@Component({
  selector: 'app-exemplo-servicos',
  templateUrl: './exemplo-servicos.component.html',
  styleUrls: ['./exemplo-servicos.component.less']
})
export class ExemploServicosComponent {
  nome = "";

  constructor(private logger: LoggerService) { }

  adicionarNome() {
    this.logger.logar(`O usuário ${this.nome} foi adicionado.`)
  }

}
