import { Injectable } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar'

@Injectable({
  providedIn: 'root'
})
export class NotificacaoService {

  constructor(
    private snakeBar: MatSnackBar
  ) { }

  notificar(mensagem: string) {
    this.snakeBar.open(mensagem, "Fechar", {
      duration: 3000,
      verticalPosition: "top",
      horizontalPosition: 'center'
    })

  }
}
