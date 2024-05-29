import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-pagina-com-parametros',
  templateUrl: './pagina-com-parametros.component.html',
  styleUrls: ['./pagina-com-parametros.component.less']
})
export class PaginaComParametrosComponent implements OnInit {
  id: number | null = null;
  nome: string | null = null;
  idade: number | null = null;

  constructor(private routes: ActivatedRoute) { }

  ngOnInit(): void {
    this.routes.paramMap.subscribe(param => {
      this.id = Number(param.get("id"));
    });
    this.routes.queryParamMap.subscribe(param => {
      this.nome = param.get("nome");
      this.idade = Number(param.get("idade"));
    })
  }
}
