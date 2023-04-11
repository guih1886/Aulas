import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core'
import { Curso } from './curso';

@Component({
  selector: 'app-curso',
  templateUrl: './curso.component.html',
  styleUrls: ['./curso.component.less']
})
export class CursoComponent {
  //url base api
  url = '../../../../php'

  //vetor de cursos
  cursos: Curso[] = [];

  constructor(
    private http: HttpClient
  ) { }
  //cadastros
  cadastro(): void {
    alert("Seleção")
  }

  selecao(): void {
    alert("Seleção")
  }
  alterar(): void {
    alert("Alterar")
  }
  remover(): void {
    alert("Remover")
  }
}
