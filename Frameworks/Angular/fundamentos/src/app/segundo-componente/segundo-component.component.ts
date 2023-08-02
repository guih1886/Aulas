import { Component } from '@angular/core';

@Component({
  selector: 'app-segundo-component',
  templateUrl: './segundo-component.component.html',
  styleUrls: ['./segundo-component.component.less']
})
export class SegundoComponentComponent {
  nome = "Guilherme Henrique";
  dataNascimento = "1994-05-07";
  imgSrc = "./assets/linkedin.jpeg";


  mostrarData() {
    alert(`Data de nascimento ${this.dataNascimento}`);
  }
}
