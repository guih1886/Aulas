import { Component, OnChanges, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-ciclo-de-vida-pai',
  templateUrl: './ciclo-de-vida-pai.component.html',
  styleUrls: ['./ciclo-de-vida-pai.component.less']
})
export class CicloDeVidaPaiComponent implements OnChanges {
  texto = "";

  ngOnChanges(changes: SimpleChanges): void {
    console.log("O evento OnChanges disparou: " + changes);
  }



}
