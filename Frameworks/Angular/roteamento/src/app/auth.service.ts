import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  token = "tokendeautenticacao";
  constructor() { }

  estaAutenticado(): boolean {
    return !!sessionStorage.getItem("acess-token");
  }

  login(email: string, senha: string): boolean {
    if (email === "admin@gmail.com" && senha === "123456") {
      sessionStorage.setItem("acess-token", this.token)
      return true
    } else {
      return false
    }

  }

  logout() {
    sessionStorage.clear();
  }
}
