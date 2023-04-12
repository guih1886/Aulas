import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core'
import { CursoService } from './curso.service';
import { Curso } from './curso';

@Component({
  selector: 'app-curso',
  templateUrl: './curso.component.html',
  styleUrls: ['./curso.component.less']
})
export class CursoComponent implements OnInit {
  vetor: Curso[] = [];

  //objeto da classe curso
  public curso = new Curso();

  constructor(
    private http: HttpClient,
    private cursoService: CursoService
  ) { }

  ngOnInit(): void {
    this.selecao();
  }

  //cadastros
  cadastro() {
    this.cursoService.cadastrarCurso(this.curso).subscribe(
      (res: Curso[]) => {
        //adicionando dados ao vetor
        this.vetor = res;
        //limpar os atributos
        this.curso.nomeCurso = null
        this.curso.valorCurso = null
        //atuliazar a listagem
        this.selecao();
      }
    )
  }

  selecao() {
    this.cursoService.obterCursos().subscribe(
      (res: Curso[]) => {
        this.vetor = res;
      }
    );
  }

  alterar() {
    this.cursoService.atualizarCurso(this.curso).subscribe(
      (res) => {
        this.vetor = res

        this.curso.nomeCurso = null
        this.curso.valorCurso = null

        this.selecao();
      }
    )
  }

  remover() {
    this.cursoService.removerCurso(this.curso).subscribe(
      (res: Curso[]) => {
        this.vetor = res
        this.curso.nomeCurso = null
        this.curso.valorCurso = null
      }
    )
  }

  //selecionar curso especifico
  selecionarCurso(c: Curso) {
    this.curso.idCurso = c.idCurso
    this.curso.nomeCurso = c.nomeCurso
    this.curso.valorCurso = c.valorCurso
  }

}
