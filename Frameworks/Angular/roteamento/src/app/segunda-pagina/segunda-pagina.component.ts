import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-segunda-pagina',
  templateUrl: './segunda-pagina.component.html',
  styleUrls: ['./segunda-pagina.component.less']
})
export class SegundaPaginaComponent {
  constructor(
    private router: Router
  ) { }

  moverParaPrimeiraPagina() {
    this.router.navigate(["primeira-pagina"]);
  }

}
