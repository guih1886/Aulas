import { Component } from '@angular/core';
import { LoggerService } from '../services/logger.service';

@Component({
  selector: 'app-exemplo-servico2',
  templateUrl: './exemplo-servico2.component.html',
  styleUrls: ['./exemplo-servico2.component.less']
})
export class ExemploServico2Component {
  produto = "";

  constructor(private logger: LoggerService) { }

  adicionarProduto() {
    this.logger.logar(`O produto ${this.produto} foi adicionado.`);
  }

  mostrarLogs() {
    this.logger.mostrarLogs();
  }


}
